using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductModelConfiguration : EntityTypeConfiguration<Production_ProductModel>
    {
        public Production_ProductModelConfiguration()
            : this("Production")
        {
        }

        public Production_ProductModelConfiguration(string schema)
        {
            ToTable("ProductModel", schema);
            HasKey(x => x.ProductModelId);

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CatalogDescription).HasColumnName(@"CatalogDescription").HasColumnType("xml").IsOptional();
            Property(x => x.Instructions).HasColumnName(@"Instructions").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}