using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductReviewConfiguration : EntityTypeConfiguration<Production_ProductReview>
    {
        public Production_ProductReviewConfiguration()
            : this("Production")
        {
        }

        public Production_ProductReviewConfiguration(string schema)
        {
            ToTable("ProductReview", schema);
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName(@"ProductReviewID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.ReviewerName).HasColumnName(@"ReviewerName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName(@"ReviewDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName(@"Rating").HasColumnType("int").IsRequired();
            Property(x => x.Comments).HasColumnName(@"Comments").HasColumnType("nvarchar").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductReviews).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}