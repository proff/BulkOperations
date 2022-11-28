using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<Production_ProductModelProductDescriptionCulture>
    {
        public Production_ProductModelProductDescriptionCultureConfiguration()
            : this("Production")
        {
        }

        public Production_ProductModelProductDescriptionCultureConfiguration(string schema)
        {
            ToTable("ProductModelProductDescriptionCulture", schema);
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName(@"ProductDescriptionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName(@"CultureID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Culture).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.CultureId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_ProductDescription).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductDescriptionId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductModelId).WillCascadeOnDelete(false); 
        }
    }
}