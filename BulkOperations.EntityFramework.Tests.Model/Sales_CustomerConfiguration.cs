using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CustomerConfiguration : EntityTypeConfiguration<Sales_Customer>
    {
        public Sales_CustomerConfiguration()
            : this("Sales")
        {
        }

        public Sales_CustomerConfiguration(string schema)
        {
            ToTable("Customer", schema);
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName(@"CustomerID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName(@"PersonID").HasColumnType("int").IsOptional();
            Property(x => x.StoreId).HasColumnName(@"StoreID").HasColumnType("int").IsOptional();
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsOptional();
            Property(x => x.AccountNumber).HasColumnName(@"AccountNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Person_Person).WithMany(b => b.Sales_Customers).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_Customers).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false); 
            HasOptional(a => a.Sales_Store).WithMany(b => b.Sales_Customers).HasForeignKey(c => c.StoreId).WillCascadeOnDelete(false); 
        }
    }
}