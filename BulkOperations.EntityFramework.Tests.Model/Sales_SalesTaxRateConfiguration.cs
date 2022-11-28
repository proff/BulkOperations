using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTaxRateConfiguration : EntityTypeConfiguration<Sales_SalesTaxRate>
    {
        public Sales_SalesTaxRateConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesTaxRateConfiguration(string schema)
        {
            ToTable("SalesTaxRate", schema);
            HasKey(x => x.SalesTaxRateId);

            Property(x => x.SalesTaxRateId).HasColumnName(@"SalesTaxRateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired();
            Property(x => x.TaxType).HasColumnName(@"TaxType").HasColumnType("tinyint").IsRequired();
            Property(x => x.TaxRate).HasColumnName(@"TaxRate").HasColumnType("smallmoney").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_StateProvince).WithMany(b => b.Sales_SalesTaxRates).HasForeignKey(c => c.StateProvinceId).WillCascadeOnDelete(false); 
        }
    }
}