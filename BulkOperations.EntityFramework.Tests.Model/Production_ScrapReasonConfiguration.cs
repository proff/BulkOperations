using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ScrapReasonConfiguration : EntityTypeConfiguration<Production_ScrapReason>
    {
        public Production_ScrapReasonConfiguration()
            : this("Production")
        {
        }

        public Production_ScrapReasonConfiguration(string schema)
        {
            ToTable("ScrapReason", schema);
            HasKey(x => x.ScrapReasonId);

            Property(x => x.ScrapReasonId).HasColumnName(@"ScrapReasonID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}