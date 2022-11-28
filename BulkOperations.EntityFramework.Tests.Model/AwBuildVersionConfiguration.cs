using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class AwBuildVersionConfiguration : EntityTypeConfiguration<AwBuildVersion>
    {
        public AwBuildVersionConfiguration()
            : this("dbo")
        {
        }

        public AwBuildVersionConfiguration(string schema)
        {
            ToTable("AWBuildVersion", schema);
            HasKey(x => x.SystemInformationId);

            Property(x => x.SystemInformationId).HasColumnName(@"SystemInformationID").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DatabaseVersion).HasColumnName(@"Database Version").HasColumnType("nvarchar").IsRequired().HasMaxLength(25);
            Property(x => x.VersionDate).HasColumnName(@"VersionDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}