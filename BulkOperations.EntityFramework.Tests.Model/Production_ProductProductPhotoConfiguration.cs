using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductProductPhoto>
    {
        public Production_ProductProductPhotoConfiguration()
            : this("Production")
        {
        }

        public Production_ProductProductPhotoConfiguration(string schema)
        {
            ToTable("ProductProductPhoto", schema);
            HasKey(x => new { x.ProductId, x.ProductPhotoId });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductPhotoId).HasColumnName(@"ProductPhotoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Primary).HasColumnName(@"Primary").HasColumnType("bit").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductProductPhotoes).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_ProductPhoto).WithMany(b => b.Production_ProductProductPhotoes).HasForeignKey(c => c.ProductPhotoId).WillCascadeOnDelete(false); 
        }
    }
}