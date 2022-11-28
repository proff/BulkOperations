using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderDetailConfiguration : EntityTypeConfiguration<Sales_SalesOrderDetail>
    {
        public Sales_SalesOrderDetailConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesOrderDetailConfiguration(string schema)
        {
            ToTable("SalesOrderDetail", schema);
            HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderDetailId).HasColumnName(@"SalesOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CarrierTrackingNumber).HasColumnName(@"CarrierTrackingNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.SpecialOfferId).HasColumnName(@"SpecialOfferID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired();
            Property(x => x.UnitPriceDiscount).HasColumnName(@"UnitPriceDiscount").HasColumnType("money").IsRequired();
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("numeric").IsRequired().HasPrecision(38,6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Sales_SalesOrderHeader).WithMany(b => b.Sales_SalesOrderDetails).HasForeignKey(c => c.SalesOrderId); 
            HasRequired(a => a.Sales_SpecialOfferProduct).WithMany(b => b.Sales_SalesOrderDetails).HasForeignKey(c => new { c.SpecialOfferId, c.ProductId }).WillCascadeOnDelete(false); 
        }
    }
}