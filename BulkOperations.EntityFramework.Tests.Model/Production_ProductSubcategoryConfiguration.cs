using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductSubcategoryConfiguration : EntityTypeConfiguration<Production_ProductSubcategory>
    {
        public Production_ProductSubcategoryConfiguration()
            : this("Production")
        {
        }

        public Production_ProductSubcategoryConfiguration(string schema)
        {
            ToTable("ProductSubcategory", schema);
            HasKey(x => x.ProductSubcategoryId);

            Property(x => x.ProductSubcategoryId).HasColumnName(@"ProductSubcategoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductCategoryId).HasColumnName(@"ProductCategoryID").HasColumnType("int").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_ProductCategory).WithMany(b => b.Production_ProductSubcategories).HasForeignKey(c => c.ProductCategoryId).WillCascadeOnDelete(false); 
        }
    }
}