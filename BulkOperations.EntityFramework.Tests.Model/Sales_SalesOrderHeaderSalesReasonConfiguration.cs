using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderHeaderSalesReasonConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeaderSalesReason>
    {
        public Sales_SalesOrderHeaderSalesReasonConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesOrderHeaderSalesReasonConfiguration(string schema)
        {
            ToTable("SalesOrderHeaderSalesReason", schema);
            HasKey(x => new { x.SalesOrderId, x.SalesReasonId });

            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesReasonId).HasColumnName(@"SalesReasonID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesOrderId); 
            HasRequired(a => a.Sales_SalesReason).WithMany(b => b.Sales_SalesOrderHeaderSalesReasons).HasForeignKey(c => c.SalesReasonId).WillCascadeOnDelete(false); 
        }
    }
}