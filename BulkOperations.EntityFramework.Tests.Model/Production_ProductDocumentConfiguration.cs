using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductDocumentConfiguration : EntityTypeConfiguration<Production_ProductDocument>
    {
        public Production_ProductDocumentConfiguration()
            : this("Production")
        {
        }

        public Production_ProductDocumentConfiguration(string schema)
        {
            ToTable("ProductDocument", schema);
            HasKey(x => new { x.ProductId, x.DocumentNode });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentNode).HasColumnName(@"DocumentNode").HasColumnType("hierarchyid").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Document).WithMany(b => b.Production_ProductDocuments).HasForeignKey(c => c.DocumentNode).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductDocuments).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}