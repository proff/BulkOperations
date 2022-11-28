using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesReasonConfiguration : EntityTypeConfiguration<Sales_SalesReason>
    {
        public Sales_SalesReasonConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesReasonConfiguration(string schema)
        {
            ToTable("SalesReason", schema);
            HasKey(x => x.SalesReasonId);

            Property(x => x.SalesReasonId).HasColumnName(@"SalesReasonID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ReasonType).HasColumnName(@"ReasonType").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}