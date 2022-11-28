using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesPersonConfiguration : EntityTypeConfiguration<Sales_SalesPerson>
    {
        public Sales_SalesPersonConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesPersonConfiguration(string schema)
        {
            ToTable("SalesPerson", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsOptional();
            Property(x => x.SalesQuota).HasColumnName(@"SalesQuota").HasColumnType("money").IsOptional();
            Property(x => x.Bonus).HasColumnName(@"Bonus").HasColumnType("money").IsRequired();
            Property(x => x.CommissionPct).HasColumnName(@"CommissionPct").HasColumnType("smallmoney").IsRequired();
            Property(x => x.SalesYtd).HasColumnName(@"SalesYTD").HasColumnType("money").IsRequired();
            Property(x => x.SalesLastYear).HasColumnName(@"SalesLastYear").HasColumnType("money").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesPersons).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false); 
            HasRequired(a => a.HumanResources_Employee).WithOptional(b => b.Sales_SalesPerson).WillCascadeOnDelete(false); 
        }
    }
}