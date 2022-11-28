using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductInventoryConfiguration : EntityTypeConfiguration<Production_ProductInventory>
    {
        public Production_ProductInventoryConfiguration()
            : this("Production")
        {
        }

        public Production_ProductInventoryConfiguration(string schema)
        {
            ToTable("ProductInventory", schema);
            HasKey(x => new { x.ProductId, x.LocationId });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName(@"LocationID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Shelf).HasColumnName(@"Shelf").HasColumnType("nvarchar").IsRequired().HasMaxLength(10);
            Property(x => x.Bin).HasColumnName(@"Bin").HasColumnType("tinyint").IsRequired();
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("smallint").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_ProductInventories).HasForeignKey(c => c.LocationId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductInventories).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}