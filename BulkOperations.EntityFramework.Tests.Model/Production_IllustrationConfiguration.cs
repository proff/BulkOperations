using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_IllustrationConfiguration : EntityTypeConfiguration<Production_Illustration>
    {
        public Production_IllustrationConfiguration()
            : this("Production")
        {
        }

        public Production_IllustrationConfiguration(string schema)
        {
            ToTable("Illustration", schema);
            HasKey(x => x.IllustrationId);

            Property(x => x.IllustrationId).HasColumnName(@"IllustrationID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Diagram).HasColumnName(@"Diagram").HasColumnType("xml").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}