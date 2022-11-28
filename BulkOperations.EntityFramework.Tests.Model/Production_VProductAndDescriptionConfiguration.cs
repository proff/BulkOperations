using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_VProductAndDescriptionConfiguration : EntityTypeConfiguration<Production_VProductAndDescription>
    {
        public Production_VProductAndDescriptionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductAndDescriptionConfiguration(string schema)
        {
            ToTable("vProductAndDescription", schema);
            HasKey(x => new { x.ProductId, x.Name, x.ProductModel, x.CultureId, x.Description });

            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductModel).HasColumnName(@"ProductModel").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName(@"CultureID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsRequired().HasMaxLength(400).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}