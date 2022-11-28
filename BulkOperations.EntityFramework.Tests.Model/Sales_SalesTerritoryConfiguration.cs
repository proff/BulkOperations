using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTerritoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritory>
    {
        public Sales_SalesTerritoryConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesTerritoryConfiguration(string schema)
        {
            ToTable("SalesTerritory", schema);
            HasKey(x => x.TerritoryId);

            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3);
            Property(x => x.Group).HasColumnName(@"Group").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.SalesYtd).HasColumnName(@"SalesYTD").HasColumnType("money").IsRequired();
            Property(x => x.SalesLastYear).HasColumnName(@"SalesLastYear").HasColumnType("money").IsRequired();
            Property(x => x.CostYtd).HasColumnName(@"CostYTD").HasColumnType("money").IsRequired();
            Property(x => x.CostLastYear).HasColumnName(@"CostLastYear").HasColumnType("money").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Sales_SalesTerritories).HasForeignKey(c => c.CountryRegionCode).WillCascadeOnDelete(false); 
        }
    }
}