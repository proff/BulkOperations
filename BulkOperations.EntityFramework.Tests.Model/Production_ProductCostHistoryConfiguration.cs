using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductCostHistoryConfiguration : EntityTypeConfiguration<Production_ProductCostHistory>
    {
        public Production_ProductCostHistoryConfiguration()
            : this("Production")
        {
        }

        public Production_ProductCostHistoryConfiguration(string schema)
        {
            ToTable("ProductCostHistory", schema);
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.StandardCost).HasColumnName(@"StandardCost").HasColumnType("money").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductCostHistories).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}