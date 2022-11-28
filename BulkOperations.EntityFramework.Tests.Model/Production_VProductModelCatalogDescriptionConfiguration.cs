using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_VProductModelCatalogDescriptionConfiguration : EntityTypeConfiguration<Production_VProductModelCatalogDescription>
    {
        public Production_VProductModelCatalogDescriptionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductModelCatalogDescriptionConfiguration(string schema)
        {
            ToTable("vProductModelCatalogDescription", schema);
            HasKey(x => new { x.ProductModelId, x.Name, x.Rowguid, x.ModifiedDate });

            Property(x => x.ProductModelId).HasColumnName(@"ProductModelID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Summary).HasColumnName(@"Summary").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Manufacturer).HasColumnName(@"Manufacturer").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Copyright).HasColumnName(@"Copyright").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.ProductUrl).HasColumnName(@"ProductURL").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.WarrantyPeriod).HasColumnName(@"WarrantyPeriod").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.WarrantyDescription).HasColumnName(@"WarrantyDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.NoOfYears).HasColumnName(@"NoOfYears").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.MaintenanceDescription).HasColumnName(@"MaintenanceDescription").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Wheel).HasColumnName(@"Wheel").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Saddle).HasColumnName(@"Saddle").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Pedal).HasColumnName(@"Pedal").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.BikeFrame).HasColumnName(@"BikeFrame").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Crankset).HasColumnName(@"Crankset").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.PictureAngle).HasColumnName(@"PictureAngle").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.PictureSize).HasColumnName(@"PictureSize").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.ProductPhotoId).HasColumnName(@"ProductPhotoID").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Material).HasColumnName(@"Material").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Color).HasColumnName(@"Color").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.ProductLine).HasColumnName(@"ProductLine").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.Style).HasColumnName(@"Style").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.RiderExperience).HasColumnName(@"RiderExperience").HasColumnType("nvarchar").IsOptional().HasMaxLength(1024);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}