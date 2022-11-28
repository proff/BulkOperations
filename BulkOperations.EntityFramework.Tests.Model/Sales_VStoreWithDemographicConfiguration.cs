using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_VStoreWithDemographicConfiguration : EntityTypeConfiguration<Sales_VStoreWithDemographic>
    {
        public Sales_VStoreWithDemographicConfiguration()
            : this("Sales")
        {
        }

        public Sales_VStoreWithDemographicConfiguration(string schema)
        {
            ToTable("vStoreWithDemographics", schema);
            HasKey(x => new { x.BusinessEntityId, x.Name });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AnnualSales).HasColumnName(@"AnnualSales").HasColumnType("money").IsOptional();
            Property(x => x.AnnualRevenue).HasColumnName(@"AnnualRevenue").HasColumnType("money").IsOptional();
            Property(x => x.BankName).HasColumnName(@"BankName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.BusinessType).HasColumnName(@"BusinessType").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.YearOpened).HasColumnName(@"YearOpened").HasColumnType("int").IsOptional();
            Property(x => x.Specialty).HasColumnName(@"Specialty").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.SquareFeet).HasColumnName(@"SquareFeet").HasColumnType("int").IsOptional();
            Property(x => x.Brands).HasColumnName(@"Brands").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Internet).HasColumnName(@"Internet").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.NumberEmployees).HasColumnName(@"NumberEmployees").HasColumnType("int").IsOptional();
        }
    }
}