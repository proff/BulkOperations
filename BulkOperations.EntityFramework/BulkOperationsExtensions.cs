using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BulkOperations.EntityFramework
{
    /// <summary>
    /// Extension methods for <see cref="DbContext"/> to perform bulk operations.
    /// </summary>
    public static class BulkOperationsExtensions
    {
        private static ConcurrentDictionary<Type, EfMapping> _mappingCache = new ConcurrentDictionary<Type, EfMapping>();

        /// <summary>
        /// Saves all changes made in this context to the underlying database using high-performance bulk update.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <returns>The number of state entries written to the underlying database.</returns>
        public static int BulkSaveChanges(this DbContext dbContext)
        {
            return AsyncHelpers.RunSync(() => BulkSaveChangesAsync(dbContext));
        }

        /// <summary>
        /// Asynchronously saves all changes made in this context to the underlying database using high-performance bulk update.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        /// <returns>A task that represents the asynchronous save operation. The task result contains the number of state entries written to the underlying database.</returns>
        public static async Task<int> BulkSaveChangesAsync(this DbContext dbContext)
        {
            var connection = dbContext.Database.Connection;
            if (!(connection.CreateCommand() is SqlCommand))
                return await dbContext.SaveChangesAsync().ConfigureAwait(false);

            SqlTransaction tran = (SqlTransaction)dbContext.Database.CurrentTransaction?.UnderlyingTransaction;

            /*if (Transaction.Current == null)
            {
                throw new InvalidOperationException("TransactionScope required");
            }*/

            var mapping = _mappingCache.GetOrAdd(dbContext.GetType(), key => new EfMapping(dbContext));

            var context = ((IObjectContextAdapter)dbContext).ObjectContext;
            context.DetectChanges();
            var q = from e in context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified)
                    group e by ObjectContext.GetObjectType(e.Entity.GetType())
                into g
                    let first = g.First()
                    select new
                    {
                        Type = g.Key,
                        first.EntityKey,
                        Items = g.AsEnumerable()
                    };
            int result = 0;
            var connectionClosed = connection.State != ConnectionState.Open;
            if (connectionClosed)
                await connection.OpenAsync().ConfigureAwait(false);

            foreach (var type in q)
            {
                var t = type.Items.First().GetType();
                var p = t.GetProperty("ModifiedProperties", BindingFlags.Instance | BindingFlags.NonPublic);
                BitArray changed = null;
                foreach (var item in type.Items)
                {
                    var c = (BitArray)p.GetValue(item);
                    if (changed == null)
                        changed = (BitArray)c.Clone();
                    else
                    {
                        changed = changed.Or(c);
                    }
                }

                var tableMapping = mapping.TypeMappings.Single(a => a.EntityType.FullName == type.Type.FullName).TableMappings
                    .Single();
                var keyNames = type.EntityKey.EntityKeyValues
                    .Select(a => tableMapping.PropertyMappingsList.Single(b => b.Property.Name == a.Key).ColumnName).ToList();
                var tableName = $"{tableMapping.SchemaName}.{tableMapping.TableName}";

                var names = new List<string>();
                for (var i = 0; i < changed.Count; i++)
                {
                    if (changed[i])
                        names.Add(tableMapping.PropertyMappingsList[i].ColumnName);
                }

                var dt = new DataTable();
                foreach (var name in keyNames.Union(names))
                {
                    var t1 = tableMapping.PropertyMappings[name].PropertyType;
                    var t2 = Nullable.GetUnderlyingType(t1);
                    dt.Columns.Add(name, t2 ?? t1);
                }

                foreach (var entry in type.Items)
                {
                    var row = dt.NewRow();
                    //todo: key value change
                    foreach (var name in keyNames.Union(names))
                    {
                        row[name] = entry.CurrentValues[tableMapping.PropertyMappingsList.Where(a=>a.ColumnName==name).Single().Property.Name] ?? DBNull.Value;
                    }

                    dt.Rows.Add(row);
                }

                result += await MergeAsync(keyNames, tableMapping, names, tran, connection, tableName, dt, true).ConfigureAwait(false);
            }

            if (connectionClosed)
                connection.Close();
            //context.AcceptAllChanges();
            foreach (var entry in dbContext.ChangeTracker.Entries().Where(a => a.State == EntityState.Modified))
            {
                entry.State = EntityState.Unchanged;
            }

            return result;
        }

        /// <summary>
        /// Performs a bulk insert or update operation on the specified collection of entities.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <param name="dbContext">The database context.</param>
        /// <param name="entities">The collection of entities to upsert.</param>
        /// <returns>The number of state entries affected in the underlying database.</returns>
        public static int BulkUpsert<T>(this DbContext dbContext, ICollection<T> entities) where T : class
        {
            return AsyncHelpers.RunSync(() => BulkUpsertAsync(dbContext, entities));
        }

        /// <summary>
        /// Asynchronously performs a bulk insert or update operation on the specified collection of entities.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <param name="dbContext">The database context.</param>
        /// <param name="entities">The collection of entities to upsert.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the number of state entries affected in the underlying database.</returns>
        public static Task<int> BulkUpsertAsync<T>(this DbContext dbContext, ICollection<T> entities) where T : class
        {
            return BulkUpsertAsync<T, T>(dbContext, entities, null);
        }

        /// <summary>
        /// Performs a bulk insert or update operation on the specified collection of entities, using the specified fields for matching and updating.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <typeparam name="T1">The type of the fields expression result.</typeparam>
        /// <param name="dbContext">The database context.</param>
        /// <param name="entities">The collection of entities to upsert.</param>
        /// <param name="fields">An expression specifying the fields to use for matching and updating.</param>
        /// <returns>The number of state entries affected in the underlying database.</returns>
        public static int BulkUpsert<T, T1>(this DbContext dbContext, ICollection<T> entities,
            Expression<Func<T, T1>> fields) where T : class
        {
            return AsyncHelpers.RunSync(() => BulkUpsertAsync(dbContext, entities, fields));
        }

        /// <summary>
        /// Asynchronously performs a bulk insert or update operation on the specified collection of entities, using the specified fields for matching and updating.
        /// </summary>
        /// <typeparam name="T">The type of the entities.</typeparam>
        /// <typeparam name="T1">The type of the fields expression result.</typeparam>
        /// <param name="dbContext">The database context.</param>
        /// <param name="entities">The collection of entities to upsert.</param>
        /// <param name="fields">An expression specifying the fields to use for matching and updating.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the number of state entries affected in the underlying database.</returns>
        public static async Task<int> BulkUpsertAsync<T, T1>(this DbContext dbContext, ICollection<T> entities,
            Expression<Func<T, T1>> fields) where T : class
        {
            if (entities.Count == 0) return 0;

            var mapping = _mappingCache.GetOrAdd(dbContext.GetType(), key => new EfMapping(dbContext));
            var tableMapping = mapping.TypeMappings.Single(a => a.EntityType.FullName == typeof(T).FullName).TableMappings
                .Single();
            var context = ((IObjectContextAdapter)dbContext).ObjectContext;
            var set = context.CreateObjectSet<T>();
            var keyNames = set.EntitySet.ElementType.KeyMembers.Select(a =>
                tableMapping.PropertyMappingsList.Single(b => b.Property.Name == a.Name).ColumnName).ToList();
            var names = tableMapping.PropertyMappingsList.Where(a => a.Property.GetSetMethod()?.IsPrivate==false).Select(a => a.ColumnName)
                .ToList();
            if (fields != null)
                names = ((NewExpression) fields.Body).Members.Select(a => a.Name)
                    .ToList();
            SqlTransaction tran = (SqlTransaction)dbContext.Database.CurrentTransaction?.UnderlyingTransaction;
            var connection = dbContext.Database.Connection;
            var connectionClosed = connection.State != ConnectionState.Open;
            var tableName = $"{tableMapping.SchemaName}.{tableMapping.TableName}";

            var dt = new DataTable();
            foreach (var name in keyNames.Union(names))
            {
                var t1 = tableMapping.PropertyMappings[name].PropertyType;
                var t2 = Nullable.GetUnderlyingType(t1);
                dt.Columns.Add(name, t2 ?? t1);
            }

            foreach (var entry in entities)
            {
                var row = dt.NewRow();
                foreach (var name in keyNames.Union(names))
                {
                    
                    var value = tableMapping.PropertyMappingsList.Single(a => a.ColumnName==name).Property.GetValue(entry) ?? DBNull.Value;
                    row[name] = value;
                }

                dt.Rows.Add(row);
            }

            if (connectionClosed)
                await connection.OpenAsync();
            var result = await MergeAsync(keyNames, tableMapping, names, tran, connection, tableName, dt, true).ConfigureAwait(false);
            if (connectionClosed)
                connection.Close();
            return result;
        }

        private static async Task<int> MergeAsync(IEnumerable<string> keyNames, TableMapping tableMapping, List<string> names,
            SqlTransaction tran, DbConnection connection, string tableName, DataTable dt, bool withInsert = false)
        {
            var random = Guid.NewGuid().ToString().Replace("-", "_");
            var tempTableName = $"#BatchOperation{random}";
            var cmd = (SqlCommand)connection.CreateCommand();

            var sb = new StringBuilder();
            sb.Append(
                $"CREATE TABLE {tempTableName} (");
            foreach (var name in keyNames.Union(names))
            {
                sb.Append($"{name} {MapType(tableMapping.PropertyMappings[name].PropertyType)}, ");
            }

            sb.Length -= 2;
            sb.AppendLine($");");
            cmd.CommandText = sb.ToString();
            cmd.Transaction = tran;
            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);

            cmd = (SqlCommand) connection.CreateCommand();
            sb.Clear();
            sb.AppendLine($"IF (OBJECTPROPERTY(OBJECT_ID('{tableName}'), 'TableHasIdentity')=1) SET IDENTITY_INSERT {tableName} ON");
            sb.Append($"MERGE {tableName} AS target USING (SELECT ");
            foreach (var name in keyNames.Union(names))
            {
                sb.Append($"{name}, ");
            }

            sb.Length -= 2;
            sb.Append($" FROM {tempTableName}) AS source (");
            foreach (var name in keyNames.Union(names))
            {
                sb.Append($"{name}, ");
            }

            sb.Length -= 2;
            sb.Append($") ON (");
            foreach (var keyName in keyNames)
            {
                sb.Append($"target.{keyName}=source.{keyName} AND ");
            }

            sb.Length -= 5;
            sb.Append(") WHEN MATCHED THEN UPDATE SET ");
            foreach (var name in names)
            {
                sb.Append($"{name}=source.{name}, ");
            }

            sb.Length -= 2;
            if (withInsert)
            {
                sb.Append($" WHEN NOT MATCHED THEN INSERT (");
                foreach (var name in keyNames.Union(names)) sb.Append($"{name}, ");

                sb.Length -= 2;
                sb.Append(") VALUES (");
                foreach (var name in keyNames.Union(names))
                    sb.Append($"source.{name}, ");

                sb.Length -= 2;
                sb.Append(")");
            }

            sb.AppendLine(";");
            sb.AppendLine($"IF (OBJECTPROPERTY(OBJECT_ID('{tableName}'), 'TableHasIdentity')=1) SET IDENTITY_INSERT {tableName} OFF");

            var copy = new SqlBulkCopy((SqlConnection) connection, SqlBulkCopyOptions.Default, tran)
            {
                DestinationTableName = $"{tempTableName}"
            };
            await copy.WriteToServerAsync(dt).ConfigureAwait(false);
            copy.Close();

            cmd.CommandText = sb.ToString();
            cmd.CommandTimeout = 0;
            /*var param = cmd.Parameters.Add("@table", SqlDbType.Structured);
                param.Value = dt;
                param.TypeName = $"{tableMapping.SchemaName}.BatchSaveChanges{random}";*/
            cmd.Transaction = tran;
            return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
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
            if (type == typeof(bool) || type == typeof(bool?))
            {
                return "bit";
            }
            if (type == typeof(Guid) || type == typeof(Guid?))
            {
                return "uniqueidentifier";
            }

            throw new ArgumentOutOfRangeException("type");
        }
    }

    /// <summary>
    /// Represents the mapping between Entity Framework types and database tables.
    /// </summary>
    public class EfMapping
    {
        /// <summary>
        /// Mapping information for each entity type in the model.
        /// </summary>
        public List<TypeMapping> TypeMappings { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EfMapping"/> class.
        /// </summary>
        /// <param name="db">The context to get the mapping from.</param>
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
                // Get the CLR type of the entity
                var type = metadata
                    .GetItems<EntityType>(DataSpace.OSpace)
                    .Select(e => objectItemCollection.GetClrType(e))
                    .SingleOrDefault(e => e.Name == set.ElementType.Name);

                var arr = metadata
                    .GetItems<EntityType>(DataSpace.OSpace)
                    .Select(e => objectItemCollection.GetClrType(e)).ToArray();

                if (type == null)
                    continue;

                var typeMapping = new TypeMapping
                {
                    TableMappings = new List<TableMapping>(),
                    EntityType = type
                };
                this.TypeMappings.Add(typeMapping);

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
                        tableMapping.PropertyMappingsList.Add(new PropertyMapping { ColumnName = columnName, Property = propertyInfo });
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
    /// <summary>
    /// Represents the mapping of an entity type to one or more tables.
    /// </summary>
    public class TypeMapping
    {
        /// <summary>
        /// The type of the entity from the model.
        /// </summary>
        public Type EntityType { get; set; }

        /// <summary>
        /// The table(s) that the entity is mapped to.
        /// </summary>
        public List<TableMapping> TableMappings { get; set; }
    }

    /// <summary>
    /// Represents the mapping of an entity to a table in the database.
    /// </summary>
    public class TableMapping
    {
        /// <summary>
        /// The name of the table the entity is mapped to.
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Details of the property-to-column mapping as a dictionary.
        /// </summary>
        public Dictionary<string, PropertyInfo> PropertyMappings { get; set; }

        /// <summary>
        /// Details of the property-to-column mapping as a list.
        /// </summary>
        public List<PropertyMapping> PropertyMappingsList { get; set; }

        /// <summary>
        /// The database schema name.
        /// </summary>
        public string SchemaName { get; set; }
    }

    /// <summary>
    /// Represents the mapping of a property to a column in the database.
    /// </summary>
    public class PropertyMapping
    {
        /// <summary>
        /// The property from the entity type.
        /// </summary>
        public PropertyInfo Property { get; set; }

        /// <summary>
        /// The column that property is mapped to.
        /// </summary>
        public string ColumnName { get; set; }
    }
}
