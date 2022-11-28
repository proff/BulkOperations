using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_VPersonDemographicConfiguration : EntityTypeConfiguration<Sales_VPersonDemographic>
    {
        public Sales_VPersonDemographicConfiguration()
            : this("Sales")
        {
        }

        public Sales_VPersonDemographicConfiguration(string schema)
        {
            ToTable("vPersonDemographics", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TotalPurchaseYtd).HasColumnName(@"TotalPurchaseYTD").HasColumnType("money").IsOptional();
            Property(x => x.DateFirstPurchase).HasColumnName(@"DateFirstPurchase").HasColumnType("datetime").IsOptional();
            Property(x => x.BirthDate).HasColumnName(@"BirthDate").HasColumnType("datetime").IsOptional();
            Property(x => x.MaritalStatus).HasColumnName(@"MaritalStatus").HasColumnType("nvarchar").IsOptional().HasMaxLength(1);
            Property(x => x.YearlyIncome).HasColumnName(@"YearlyIncome").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("nvarchar").IsOptional().HasMaxLength(1);
            Property(x => x.TotalChildren).HasColumnName(@"TotalChildren").HasColumnType("int").IsOptional();
            Property(x => x.NumberChildrenAtHome).HasColumnName(@"NumberChildrenAtHome").HasColumnType("int").IsOptional();
            Property(x => x.Education).HasColumnName(@"Education").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Occupation).HasColumnName(@"Occupation").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.HomeOwnerFlag).HasColumnName(@"HomeOwnerFlag").HasColumnType("bit").IsOptional();
            Property(x => x.NumberCarsOwned).HasColumnName(@"NumberCarsOwned").HasColumnType("int").IsOptional();
        }
    }
}