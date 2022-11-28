using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_PurchaseOrderHeaderConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderHeader>
    {
        public Purchasing_PurchaseOrderHeaderConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_PurchaseOrderHeaderConfiguration(string schema)
        {
            ToTable("PurchaseOrderHeader", schema);
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName(@"PurchaseOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName(@"RevisionNumber").HasColumnType("tinyint").IsRequired();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.EmployeeId).HasColumnName(@"EmployeeID").HasColumnType("int").IsRequired();
            Property(x => x.VendorId).HasColumnName(@"VendorID").HasColumnType("int").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName(@"ShipMethodID").HasColumnType("int").IsRequired();
            Property(x => x.OrderDate).HasColumnName(@"OrderDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ShipDate).HasColumnName(@"ShipDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SubTotal).HasColumnName(@"SubTotal").HasColumnType("money").IsRequired();
            Property(x => x.TaxAmt).HasColumnName(@"TaxAmt").HasColumnType("money").IsRequired();
            Property(x => x.Freight).HasColumnName(@"Freight").HasColumnType("money").IsRequired();
            Property(x => x.TotalDue).HasColumnName(@"TotalDue").HasColumnType("money").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.EmployeeId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.ShipMethodId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.VendorId).WillCascadeOnDelete(false); 
        }
    }
}