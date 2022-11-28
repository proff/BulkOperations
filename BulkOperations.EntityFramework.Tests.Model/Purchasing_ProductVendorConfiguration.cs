using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_ProductVendorConfiguration : EntityTypeConfiguration<Purchasing_ProductVendor>
    {
        public Purchasing_ProductVendorConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_ProductVendorConfiguration(string schema)
        {
            ToTable("ProductVendor", schema);
            HasKey(x => new { x.ProductId, x.BusinessEntityId });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AverageLeadTime).HasColumnName(@"AverageLeadTime").HasColumnType("int").IsRequired();
            Property(x => x.StandardPrice).HasColumnName(@"StandardPrice").HasColumnType("money").IsRequired();
            Property(x => x.LastReceiptCost).HasColumnName(@"LastReceiptCost").HasColumnType("money").IsOptional();
            Property(x => x.LastReceiptDate).HasColumnName(@"LastReceiptDate").HasColumnType("datetime").IsOptional();
            Property(x => x.MinOrderQty).HasColumnName(@"MinOrderQty").HasColumnType("int").IsRequired();
            Property(x => x.MaxOrderQty).HasColumnName(@"MaxOrderQty").HasColumnType("int").IsRequired();
            Property(x => x.OnOrderQty).HasColumnName(@"OnOrderQty").HasColumnType("int").IsOptional();
            Property(x => x.UnitMeasureCode).HasColumnName(@"UnitMeasureCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Purchasing_ProductVendors).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_UnitMeasure).WithMany(b => b.Purchasing_ProductVendors).HasForeignKey(c => c.UnitMeasureCode).WillCascadeOnDelete(false); 
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_ProductVendors).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}