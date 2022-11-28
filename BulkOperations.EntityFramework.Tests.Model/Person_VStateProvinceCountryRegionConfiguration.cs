using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_VStateProvinceCountryRegionConfiguration : EntityTypeConfiguration<Person_VStateProvinceCountryRegion>
    {
        public Person_VStateProvinceCountryRegionConfiguration()
            : this("Person")
        {
        }

        public Person_VStateProvinceCountryRegionConfiguration(string schema)
        {
            ToTable("vStateProvinceCountryRegion", schema);
            HasKey(x => new { x.StateProvinceId, x.StateProvinceCode, x.IsOnlyStateProvinceFlag, x.StateProvinceName, x.TerritoryId, x.CountryRegionCode, x.CountryRegionName });

            Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceCode).HasColumnName(@"StateProvinceCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName(@"IsOnlyStateProvinceFlag").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceName).HasColumnName(@"StateProvinceName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionName).HasColumnName(@"CountryRegionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}