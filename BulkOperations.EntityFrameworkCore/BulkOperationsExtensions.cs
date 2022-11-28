using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BulkOperations.EntityFramework;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace BulkOperations.EntityFrameworkCore
{
    public static class BulkOperationsExtensions
    {
        public static int BulkSaveChanges(this DbContext dbContext)
        {
            return AsyncHelpers.RunSync(() => BulkSaveChangesAsync(dbContext));
        }

        public static bool IsRelational(DbContext dbContext)
        {
            return ((IDatabaseFacadeDependenciesAccessor)dbContext.Database)
                .Context.GetService<IDbContextOptions>().Extensions.OfType<RelationalOptionsExtension>().Any();
        }

        public static async Task<int> BulkSaveChangesAsync(this DbContext dbContext)
        {
            if (!IsRelational(dbContext))
            {
                return await dbContext.SaveChangesAsync();
            }

            var connection = dbContext.Database.GetDbConnection();
            if (!(connection.CreateCommand() is SqlCommand))
                return await dbContext.SaveChangesAsync();

            SqlTransaction tran = (SqlTransaction)((IInfrastructure<DbTransaction>) dbContext.Database.CurrentTransaction).Instance;

            /*if (Transaction.Current == null)
            {
                throw new InvalidOperationException("TransactionScope required");
            }*/

            dbContext.ChangeTracker.DetectChanges();
            var q = from e in dbContext.ChangeTracker.Entries().Where(a=>a.State==EntityState.Modified)
                    group e by Unproxy(e.Entity.GetType())
                into g
                    let first = g.First()
                    select new
                    {
                        Type = g.Key,
                        Key=dbContext.Model.FindEntityType(g.Key).FindPrimaryKey(),
                        Items = g.AsEnumerable()
                    };
            int result = 0;
            var connectionClosed = connection.State != ConnectionState.Open;
            if (connectionClosed)
                await connection.OpenAsync();

            foreach (var type in q)
            {
                var keyNames = type.Key.Properties.Select(a => a.Name).ToList();
                var tableMapping = dbContext.Model.FindEntityType(type.Type);
                var tableName =
                    $"{tableMapping.GetAnnotations().SingleOrDefault(a => a.Name == RelationalAnnotationNames.Schema)?.Value ?? "dbo"}.{tableMapping.GetAnnotations().Single(a => a.Name == RelationalAnnotationNames.TableName).Value}";

                var names = type.Items.SelectMany(a => a.Properties).Where(a => a.IsModified).Select(a => a.Metadata.Name).Distinct().ToList();

                var dt = new DataTable();
                foreach (var name in keyNames.Union(names))
                {
                    var t1 = tableMapping.FindProperty(name).ClrType;
                    var t2 = Nullable.GetUnderlyingType(t1);
                    dt.Columns.Add(name, t2 ?? t1);
                }

                foreach (var entry in type.Items)
                {
                    var row = dt.NewRow();
                    //todo: key value change
                    foreach (var name in keyNames.Union(names))
                    {
                        row[name] = entry.CurrentValues[name] ?? DBNull.Value;
                    }

                    dt.Rows.Add(row);
                }

                result += await MergeAsync(keyNames, tableMapping, names, tran, connection, tableName, dt, true);
            }

            if (connectionClosed)
#if NETSTANDARD2_0
                connection.Close();
#else
                await connection.CloseAsync();
#endif
            //context.AcceptAllChanges();
            foreach (var entry in dbContext.ChangeTracker.Entries().Where(a => a.State == EntityState.Modified))
            {
                entry.State = EntityState.Unchanged;
            }

            return result;
        }

        private static Type Unproxy(Type type)
        {
            if (type.Namespace == "Castle.Proxies")
            {
                return type.BaseType;
            }
            return type;
        }

        public static int BulkUpsert<T>(this DbContext dbContext, ICollection<T> entities) where T : class
        {
            return AsyncHelpers.RunSync(() => BulkUpsertAsync(dbContext, entities));
        }

        public static Task<int> BulkUpsertAsync<T>(this DbContext dbContext, ICollection<T> entities) where T : class
        {
            return BulkUpsertAsync<T, T>(dbContext, entities, null);
        }

        public static int BulkUpsert<T, T1>(this DbContext dbContext, ICollection<T> entities,
            Expression<Func<T, T1>> fields) where T : class
        {
            return AsyncHelpers.RunSync(() => BulkUpsertAsync(dbContext, entities, fields));
        }

        public static async Task<int> BulkUpsertAsync<T, T1>(this DbContext dbContext, ICollection<T> entities,
            Expression<Func<T, T1>> fields) where T : class
        {
            if (entities.Count == 0) return 0;

            var tableMapping = dbContext.Model.FindEntityType(typeof(T));
            var set = dbContext.Set<T>();
            var keyNames = dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties
                .Select(k => k.Name).ToList();
            var names = tableMapping.GetProperties().Select(a=>a.Name).ToList();
            if (fields != null)
                names = ((NewExpression) fields.Body).Members.Select(a => a.Name)
                    .ToList();
            SqlTransaction tran = (SqlTransaction)((IInfrastructure<DbTransaction>)dbContext.Database.CurrentTransaction).Instance;
            var connection = dbContext.Database.GetDbConnection();
            var connectionClosed = connection.State != ConnectionState.Open;
            var tableName = $"{tableMapping.GetAnnotations().SingleOrDefault(a => a.Name == RelationalAnnotationNames.Schema)?.Value ?? "dbo"}.{tableMapping.GetAnnotations().Single(a => a.Name == RelationalAnnotationNames.TableName).Value}";

            var dt = new DataTable();
            foreach (var name in keyNames.Union(names))
            {
                var t1 = tableMapping.FindProperty(name).ClrType;
                var t2 = Nullable.GetUnderlyingType(t1);
                dt.Columns.Add(name, t2 ?? t1);
            }

            foreach (var entry in entities)
            {
                var row = dt.NewRow();
                foreach (var name in keyNames.Union(names))
                {
                    var value = entry.GetType().GetProperty(name).GetValue(entry) ?? DBNull.Value;
                    row[name] = value;
                }

                dt.Rows.Add(row);
            }

            if (connectionClosed)
                await connection.OpenAsync();
            var result = await MergeAsync(keyNames, tableMapping, names, tran, connection, tableName, dt, true);
            if (connectionClosed)
#if NETSTANDARD2_0
                connection.Close();
#else
                await connection.CloseAsync();
#endif
            return result;
        }

        private static async Task<int> MergeAsync(IEnumerable<string> keyNames, IEntityType tableMapping, List<string> names,
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
                sb.Append($"{name} {MapType(tableMapping.FindProperty(name).ClrType)}, ");
            }

            sb.Length -= 2;
            sb.AppendLine($");");
            cmd.CommandText = sb.ToString();
            cmd.Transaction = tran;
            await cmd.ExecuteNonQueryAsync();

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
            await copy.WriteToServerAsync(dt);
            copy.Close();

            cmd.CommandText = sb.ToString();
            cmd.CommandTimeout = 0;
            /*var param = cmd.Parameters.Add("@table", SqlDbType.Structured);
                param.Value = dt;
                param.TypeName = $"{tableMapping.SchemaName}.BatchSaveChanges{random}";*/
            cmd.Transaction = tran;
            return await cmd.ExecuteNonQueryAsync();
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
}
