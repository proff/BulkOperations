using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CurrencyRateConfiguration : EntityTypeConfiguration<Sales_CurrencyRate>
    {
        public Sales_CurrencyRateConfiguration()
            : this("Sales")
        {
        }

        public Sales_CurrencyRateConfiguration(string schema)
        {
            ToTable("CurrencyRate", schema);
            HasKey(x => x.CurrencyRateId);

            Property(x => x.CurrencyRateId).HasColumnName(@"CurrencyRateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName(@"CurrencyRateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName(@"FromCurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName(@"ToCurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName(@"AverageRate").HasColumnType("money").IsRequired();
            Property(x => x.EndOfDayRate).HasColumnName(@"EndOfDayRate").HasColumnType("money").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Sales_Currency_FromCurrencyCode).WithMany(b => b.Sales_CurrencyRates_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_Currency_ToCurrencyCode).WithMany(b => b.Sales_CurrencyRates_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode).WillCascadeOnDelete(false); 
        }
    }
}