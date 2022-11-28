using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_VSalesPersonConfiguration : EntityTypeConfiguration<Sales_VSalesPerson>
    {
        public Sales_VSalesPersonConfiguration()
            : this("Sales")
        {
        }

        public Sales_VSalesPersonConfiguration(string schema)
        {
            ToTable("vSalesPerson", schema);
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.JobTitle, x.EmailPromotion, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName, x.SalesYtd, x.SalesLastYear });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suffix).HasColumnName(@"Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.JobTitle).HasColumnName(@"JobTitle").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName(@"PhoneNumberType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName(@"EmailPromotion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressLine1).HasColumnName(@"AddressLine1").HasColumnType("nvarchar").IsRequired().HasMaxLength(60).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressLine2).HasColumnName(@"AddressLine2").HasColumnType("nvarchar").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StateProvinceName).HasColumnName(@"StateProvinceName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(15).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CountryRegionName).HasColumnName(@"CountryRegionName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TerritoryName).HasColumnName(@"TerritoryName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TerritoryGroup).HasColumnName(@"TerritoryGroup").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SalesQuota).HasColumnName(@"SalesQuota").HasColumnType("money").IsOptional();
            Property(x => x.SalesYtd).HasColumnName(@"SalesYTD").HasColumnType("money").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesLastYear).HasColumnName(@"SalesLastYear").HasColumnType("money").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}