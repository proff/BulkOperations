using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTerritoryHistoryConfiguration : EntityTypeConfiguration<Sales_SalesTerritoryHistory>
    {
        public Sales_SalesTerritoryHistoryConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesTerritoryHistoryConfiguration(string schema)
        {
            ToTable("SalesTerritoryHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.StartDate, x.TerritoryId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesTerritoryHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Sales_SalesTerritoryHistories).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false); 
        }
    }
}