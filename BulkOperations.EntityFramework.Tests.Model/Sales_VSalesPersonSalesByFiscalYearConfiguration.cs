using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_VSalesPersonSalesByFiscalYearConfiguration : EntityTypeConfiguration<Sales_VSalesPersonSalesByFiscalYear>
    {
        public Sales_VSalesPersonSalesByFiscalYearConfiguration()
            : this("Sales")
        {
        }

        public Sales_VSalesPersonSalesByFiscalYearConfiguration(string schema)
        {
            ToTable("vSalesPersonSalesByFiscalYears", schema);
            HasKey(x => new { x.JobTitle, x.SalesTerritory });

            Property(x => x.SalesPersonId).HasColumnName(@"SalesPersonID").HasColumnType("int").IsOptional();
            Property(x => x.FullName).HasColumnName(@"FullName").HasColumnType("nvarchar").IsOptional().HasMaxLength(152);
            Property(x => x.JobTitle).HasColumnName(@"JobTitle").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesTerritory).HasColumnName(@"SalesTerritory").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.C2002).HasColumnName(@"2002").HasColumnType("money").IsOptional();
            Property(x => x.C2003).HasColumnName(@"2003").HasColumnType("money").IsOptional();
            Property(x => x.C2004).HasColumnName(@"2004").HasColumnType("money").IsOptional();
        }
    }
}