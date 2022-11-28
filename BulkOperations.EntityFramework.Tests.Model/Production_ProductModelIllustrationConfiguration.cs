using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductModelIllustrationConfiguration : EntityTypeConfiguration<Production_ProductModelIllustration>
    {
        public Production_ProductModelIllustrationConfiguration()
            : this("Production")
        {
        }

        public Production_ProductModelIllustrationConfiguration(string schema)
        {
            ToTable("ProductModelIllustration", schema);
            HasKey(x => new { x.ProductModelId, x.IllustrationId });

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IllustrationId).HasColumnName(@"IllustrationID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Illustration).WithMany(b => b.Production_ProductModelIllustrations).HasForeignKey(c => c.IllustrationId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelIllustrations).HasForeignKey(c => c.ProductModelId).WillCascadeOnDelete(false); 
        }
    }
}