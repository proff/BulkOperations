using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CountryRegionCurrencyConfiguration : EntityTypeConfiguration<Sales_CountryRegionCurrency>
    {
        public Sales_CountryRegionCurrencyConfiguration()
            : this("Sales")
        {
        }

        public Sales_CountryRegionCurrencyConfiguration(string schema)
        {
            ToTable("CountryRegionCurrency", schema);
            HasKey(x => new { x.CountryRegionCode, x.CurrencyCode });

            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Sales_CountryRegionCurrencies).HasForeignKey(c => c.CountryRegionCode).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_Currency).WithMany(b => b.Sales_CountryRegionCurrencies).HasForeignKey(c => c.CurrencyCode).WillCascadeOnDelete(false); 
        }
    }
}