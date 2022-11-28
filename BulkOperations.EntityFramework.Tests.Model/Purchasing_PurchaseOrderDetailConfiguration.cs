using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_PurchaseOrderDetailConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderDetail>
    {
        public Purchasing_PurchaseOrderDetailConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_PurchaseOrderDetailConfiguration(string schema)
        {
            ToTable("PurchaseOrderDetail", schema);
            HasKey(x => new { x.PurchaseOrderId, x.PurchaseOrderDetailId });

            Property(x => x.PurchaseOrderId).HasColumnName(@"PurchaseOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PurchaseOrderDetailId).HasColumnName(@"PurchaseOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired();
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("money").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName(@"ReceivedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName(@"RejectedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName(@"StockedQty").HasColumnType("decimal").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_PurchaseOrderDetails).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Purchasing_PurchaseOrderHeader).WithMany(b => b.Purchasing_PurchaseOrderDetails).HasForeignKey(c => c.PurchaseOrderId).WillCascadeOnDelete(false); 
        }
    }
}