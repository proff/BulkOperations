using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductDescriptionConfiguration : EntityTypeConfiguration<Production_ProductDescription>
    {
        public Production_ProductDescriptionConfiguration()
            : this("Production")
        {
        }

        public Production_ProductDescriptionConfiguration(string schema)
        {
            ToTable("ProductDescription", schema);
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName(@"ProductDescriptionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}