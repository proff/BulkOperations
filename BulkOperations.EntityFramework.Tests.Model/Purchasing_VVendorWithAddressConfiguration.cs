using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_VVendorWithAddressConfiguration : EntityTypeConfiguration<Purchasing_VVendorWithAddress>
    {
        public Purchasing_VVendorWithAddressConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_VVendorWithAddressConfiguration(string schema)
        {
            ToTable("vVendorWithAddresses", schema);
            HasKey(x => new { x.BusinessEntityId, x.Name, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressType).HasColumnName(@"AddressType").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressLine1).HasColumnName(@"AddressLine1").HasColumnType("nvarchar").IsRequired().HasMaxLength(60).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressLine2).HasColumnName(@"AddressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceName).HasColumnName(@"StateProvinceName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionName).HasColumnName(@"CountryRegionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}