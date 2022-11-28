using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration()
            : this("Production")
        {
        }

        public Production_ProductPhotoConfiguration(string schema)
        {
            ToTable("ProductPhoto", schema);
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName(@"ProductPhotoID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName(@"ThumbNailPhoto").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.ThumbnailPhotoFileName).HasColumnName(@"ThumbnailPhotoFileName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName(@"LargePhoto").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.LargePhotoFileName).HasColumnName(@"LargePhotoFileName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}