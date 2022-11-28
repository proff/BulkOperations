using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_StoreConfiguration : EntityTypeConfiguration<Sales_Store>
    {
        public Sales_StoreConfiguration()
            : this("Sales")
        {
        }

        public Sales_StoreConfiguration(string schema)
        {
            ToTable("Store", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.SalesPersonId).HasColumnName(@"SalesPersonID").HasColumnType("int").IsOptional();
            Property(x => x.Demographics).HasColumnName(@"Demographics").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Sales_SalesPerson).WithMany(b => b.Sales_Stores).HasForeignKey(c => c.SalesPersonId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Sales_Store).WillCascadeOnDelete(false); 
        }
    }
}