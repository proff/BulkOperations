using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class DatabaseLogConfiguration : EntityTypeConfiguration<DatabaseLog>
    {
        public DatabaseLogConfiguration()
            : this("dbo")
        {
        }

        public DatabaseLogConfiguration(string schema)
        {
            ToTable("DatabaseLog", schema);
            HasKey(x => x.DatabaseLogId);

            Property(x => x.DatabaseLogId).HasColumnName(@"DatabaseLogID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PostTime).HasColumnName(@"PostTime").HasColumnType("datetime").IsRequired();
            Property(x => x.DatabaseUser).HasColumnName(@"DatabaseUser").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Event).HasColumnName(@"Event").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.Schema).HasColumnName(@"Schema").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Object).HasColumnName(@"Object").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Tsql).HasColumnName(@"TSQL").HasColumnType("nvarchar(max)").IsRequired();
            Property(x => x.XmlEvent).HasColumnName(@"XmlEvent").HasColumnType("xml").IsRequired();
        }
    }
}