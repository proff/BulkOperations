using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderHeaderConfiguration : EntityTypeConfiguration<Sales_SalesOrderHeader>
    {
        public Sales_SalesOrderHeaderConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesOrderHeaderConfiguration(string schema)
        {
            ToTable("SalesOrderHeader", schema);
            HasKey(x => x.SalesOrderId);

            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName(@"RevisionNumber").HasColumnType("tinyint").IsRequired();
            Property(x => x.OrderDate).HasColumnName(@"OrderDate").HasColumnType("datetime").IsRequired();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ShipDate).HasColumnName(@"ShipDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.OnlineOrderFlag).HasColumnName(@"OnlineOrderFlag").HasColumnType("bit").IsRequired();
            Property(x => x.SalesOrderNumber).HasColumnName(@"SalesOrderNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.PurchaseOrderNumber).HasColumnName(@"PurchaseOrderNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.CustomerId).HasColumnName(@"CustomerID").HasColumnType("int").IsRequired();
            Property(x => x.SalesPersonId).HasColumnName(@"SalesPersonID").HasColumnType("int").IsOptional();
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsOptional();
            Property(x => x.BillToAddressId).HasColumnName(@"BillToAddressID").HasColumnType("int").IsRequired();
            Property(x => x.ShipToAddressId).HasColumnName(@"ShipToAddressID").HasColumnType("int").IsRequired();
            Property(x => x.ShipMethodId).HasColumnName(@"ShipMethodID").HasColumnType("int").IsRequired();
            Property(x => x.CreditCardId).HasColumnName(@"CreditCardID").HasColumnType("int").IsOptional();
            Property(x => x.CreditCardApprovalCode).HasColumnName(@"CreditCardApprovalCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.CurrencyRateId).HasColumnName(@"CurrencyRateID").HasColumnType("int").IsOptional();
            Property(x => x.SubTotal).HasColumnName(@"SubTotal").HasColumnType("money").IsRequired();
            Property(x => x.TaxAmt).HasColumnName(@"TaxAmt").HasColumnType("money").IsRequired();
            Property(x => x.Freight).HasColumnName(@"Freight").HasColumnType("money").IsRequired();
            Property(x => x.TotalDue).HasColumnName(@"TotalDue").HasColumnType("money").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Comment).HasColumnName(@"Comment").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Sales_CreditCard).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.CreditCardId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Sales_CurrencyRate).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.CurrencyRateId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.SalesPersonId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false); 
            HasRequired(a => a.BillToAddress).WithMany(b => b.Sales_SalesOrderHeaders_BillToAddressId).HasForeignKey(c => c.BillToAddressId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.ShipMethodId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_Customer).WithMany(b => b.Sales_SalesOrderHeaders).HasForeignKey(c => c.CustomerId).WillCascadeOnDelete(false); 
            HasRequired(a => a.ShipToAddress).WithMany(b => b.Sales_SalesOrderHeaders_ShipToAddressId).HasForeignKey(c => c.ShipToAddressId).WillCascadeOnDelete(false); 
        }
    }
}