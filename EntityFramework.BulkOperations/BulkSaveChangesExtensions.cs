using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace EntityFramework.BulkOperations
{
    public static class BulkSaveChangesExtensions
    {
        private static ConcurrentDictionary<Type, EfMapping> _mappingCache = new ConcurrentDictionary<Type, EfMapping>();

        public static int BatchSaveChanges(this DbContext dbContext)
        {
            var connection = dbContext.Database.Connection;
            if (!(connection.CreateCommand() is SqlCommand))
                return dbContext.SaveChanges();

            /*if (Transaction.Current == null)
            {
                throw new InvalidOperationException("TransactionScope required");
            }*/

            var mapping = _mappingCache.GetOrAdd(dbContext.GetType(), key => new EfMapping(dbContext));

            var context = ((IObjectContextAdapter) dbContext).ObjectContext;
            var q = from e in context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified)
                group e by ObjectContext.GetObjectType(e.Entity.GetType())
                into g
                let first = g.First()
                select new
                {
                    Type = g.Key, first.EntityKey,
                    Items = g.AsEnumerable()
                };
            int result = 0;
            var connectionClosed = connection.State != ConnectionState.Open;
            if (connectionClosed)
                connection.Open();

            foreach (var type in q)
            {
                var t = type.Items.First().GetType();
                var p = t.GetProperty("ModifiedProperties", BindingFlags.Instance | BindingFlags.NonPublic);
                BitArray changed = null;
                foreach (var item in type.Items)
                {
                    var c = (BitArray) p.GetValue(item);
                    if (changed == null)
                        changed = (BitArray) c.Clone();
                    else
                    {
                        changed.And(c);
                    }
                }

                var keyName = type.EntityKey.EntityKeyValues.Single().Key;
                var tableMapping = mapping.TypeMappings.Single(a => a.EntityType == type.Type).TableMappings
                    .Single();
                var tableName = $"{tableMapping.SchemaName}.{tableMapping.TableName}";

                var names = new List<string>();
                for (var i = 0; i < changed.Count; i++)
                {
                    if (changed[i])
                        names.Add(tableMapping.PropertyMappingsList[i].ColumnName);
                }

                var random = Guid.NewGuid().ToString().Replace("-", "_");
                var tempTableName = $"#BatchSaveChanges{random}";

                var cmd = (SqlCommand) connection.CreateCommand();
                var dt = new DataTable();
                dt.Columns.Add(keyName, tableMapping.PropertyMappings[keyName].PropertyType);
                foreach (var name in names)
                    dt.Columns.Add(name, tableMapping.PropertyMappings[name].PropertyType);
                var sb = new StringBuilder();
                sb.Append(
                    $"CREATE TABLE {tempTableName} ({keyName} {MapType(tableMapping.PropertyMappings[keyName].PropertyType)}");
                foreach (var name in names)
                {
                    sb.Append($", {name} {MapType(tableMapping.PropertyMappings[name].PropertyType)}");
                }

                sb.AppendLine($");");
                cmd.CommandText = sb.ToString();
                cmd.ExecuteNonQuery();

                cmd = (SqlCommand) connection.CreateCommand();
                sb.Clear();
                sb.Append($"MERGE {tableName} AS target USING (SELECT {keyName}");
                foreach (var name in names)
                {
                    sb.Append($", {name}");
                }

                sb.Append($" FROM {tempTableName}) AS source ({keyName}");
                foreach (var name in names)
                {
                    sb.Append($", {name}");
                }

                sb.Append($") ON (target.{keyName}=source.{keyName}) WHEN MATCHED THEN UPDATE SET ");
                foreach (var name in names)
                {
                    sb.Append($"{name}=source.{name}");
                }

                sb.AppendLine(";");
                foreach (var entry in type.Items)
                {
                    var row = dt.NewRow();
                    row[keyName] = entry.OriginalValues[keyName];
                    foreach (var name in names)
                    {
                        row[name] = entry.CurrentValues[name];
                    }

                    dt.Rows.Add(row);
                }

                var copy = new SqlBulkCopy((SqlConnection)connection);
                copy.DestinationTableName = $"{tempTableName}";
                copy.WriteToServer(dt);
                copy.Close();

                cmd.CommandText = sb.ToString();
                /*var param = cmd.Parameters.Add("@table", SqlDbType.Structured);
                param.Value = dt;
                param.TypeName = $"{tableMapping.SchemaName}.BatchSaveChanges{random}";*/
                result += cmd.ExecuteNonQuery();
            }

            if (connectionClosed)
                connection.Close();

            return result;
        }

        private static string MapType(Type type)
        {
            if (type == typeof(string))
            {
                return "nvarchar(max)";
            }
            if (type == typeof(byte) || type == typeof(byte?))
            {
                return "tinyint";
            }
            if (type == typeof(short) || type == typeof(short?))
            {
                return "smallint";
            }
            if (type == typeof(int) || type == typeof(int?))
            {
                return "int";
            }
            if (type == typeof(long) || type == typeof(long?))
            {
                return "bigint";
            }
            if (type == typeof(decimal) || type == typeof(decimal?))
            {
                return "decimal(38,16)";
            }
            if (type == typeof(DateTime) || type == typeof(DateTime?))
            {
                return "datetime2";
            }
            if (type == typeof(float) || type == typeof(float?))
            {
                return "real";
            }
            if (type == typeof(double) || type == typeof(double?))
            {
                return "float";
            }

            throw new ArgumentOutOfRangeException("type");
        }
    }

    public class EfMapping
    {
        /// <summary>
        /// Mapping information for each entity type in the model
        /// </summary>
        public List<TypeMapping> TypeMappings { get; set; }

        /// <summary>
        /// Initializes an instance of the EfMapping class
        /// </summary>
        /// <param name="db">The context to get the mapping from</param>
        public EfMapping(DbContext db)
        {
            this.TypeMappings = new List<TypeMapping>();

            var metadata = ((IObjectContextAdapter)db).ObjectContext.MetadataWorkspace;

            // Conceptual part of the model has info about the shape of our entity classes
            var conceptualContainer = metadata.GetItems<EntityContainer>(DataSpace.CSpace).Single();

            // Storage part of the model has info about the shape of our tables
            var storeContainer = metadata.GetItems<EntityContainer>(DataSpace.SSpace).Single();

            // Object part of the model that contains info about the actual CLR types
            var objectItemCollection = ((ObjectItemCollection)metadata.GetItemCollection(DataSpace.OSpace));

            // Mapping part of model is not public, so we need to write to xml and use 'LINQ to XML'
            var edmx = GetEdmx(db);

            // Loop thru each entity type in the model
            foreach (var set in conceptualContainer.BaseEntitySets.OfType<EntitySet>())
            {
                var typeMapping = new TypeMapping
                {
                    TableMappings = new List<TableMapping>()
                };
                this.TypeMappings.Add(typeMapping);

                // Get the CLR type of the entity
                typeMapping.EntityType = metadata
                    .GetItems<EntityType>(DataSpace.OSpace)
                    .Select(e => objectItemCollection.GetClrType(e))
                    .Single(e => e.FullName == set.ElementType.FullName);

                // Get the mapping fragments for this type
                // (types may have mutliple fragments if 'Entity Splitting' is used)
                var mappingFragments = edmx
                    .Descendants()
                    .Single(e =>
                        e.Name.LocalName == "EntityTypeMapping"
                        && e.Attribute("TypeName").Value == set.ElementType.FullName)
                    .Descendants()
                    .Where(e => e.Name.LocalName == "MappingFragment");

                foreach (var mapping in mappingFragments)
                {
                    var tableMapping = new TableMapping
                    {
                        PropertyMappings = new Dictionary<string, PropertyInfo>(),
                        PropertyMappingsList = new List<PropertyMapping>()
                    };
                    typeMapping.TableMappings.Add(tableMapping);

                    // Find the table that this fragment maps to
                    var storeset = mapping.Attribute("StoreEntitySet").Value;
                    tableMapping.TableName = (string)storeContainer
                        .BaseEntitySets.OfType<EntitySet>()
                        .Single(s => s.Name == storeset)
                        .MetadataProperties["Table"].Value;

                    tableMapping.SchemaName = (string)storeContainer
                        .BaseEntitySets.OfType<EntitySet>()
                        .Single(s => s.Name == storeset)
                        .MetadataProperties["Schema"].Value;

                    // Find the property-to-column mappings
                    var propertyMappings = mapping
                        .Descendants()
                        .Where(e => e.Name.LocalName == "ScalarProperty");

                    foreach (var propertyMapping in propertyMappings)
                    {
                        // Find the property and column being mapped
                        var propertyName = propertyMapping.Attribute("Name").Value;
                        var columnName = propertyMapping.Attribute("ColumnName").Value;

                        var propertyInfo = typeMapping.EntityType.GetProperty(propertyName);
                        tableMapping.PropertyMappings.Add(columnName, propertyInfo);
                        tableMapping.PropertyMappingsList.Add(new PropertyMapping{ColumnName = columnName, Property  = propertyInfo});
                    }
                }
            }
        }

        private static XDocument GetEdmx(DbContext db)
        {
            XDocument doc;
            using (var memoryStream = new MemoryStream())
            {
                using (var xmlWriter = XmlWriter.Create(
                    memoryStream, new XmlWriterSettings
                    {
                        Indent = true
                    }))
                {
                    EdmxWriter.WriteEdmx(db, xmlWriter);
                }

                memoryStream.Position = 0;

                doc = XDocument.Load(memoryStream);
            }
            return doc;
        }
    }
    public class TypeMapping
    {
        /// <summary>
        /// The type of the entity from the model
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// The table(s) that the entity is mapped to
        /// </summary>
        public List<TableMapping> TableMappings { get; set; }
    }

    /// <summary>
    /// Represents the mapping of an entity to a table in the database
    /// </summary>
    public class TableMapping
    {
        /// <summary>
        /// The name of the table the entity is mapped to
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Details of the property-to-column mapping
        /// </summary>
        public Dictionary<string, PropertyInfo> PropertyMappings { get; set; }

        public List<PropertyMapping> PropertyMappingsList { get; set; }

        public string SchemaName { get; set; }
    }

    /// <summary>
    /// Represents the mapping of a property to a column in the database
    /// </summary>
    public class PropertyMapping
    {
        /// <summary>
        /// The property from the entity type
        /// </summary>
        public PropertyInfo Property { get; set; }

        /// <summary>
        /// The column that property is mapped to
        /// </summary>
        public string ColumnName { get; set; }
    }
}
