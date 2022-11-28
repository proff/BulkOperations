using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CurrencyConfiguration : EntityTypeConfiguration<Sales_Currency>
    {
        public Sales_CurrencyConfiguration()
            : this("Sales")
        {
        }

        public Sales_CurrencyConfiguration(string schema)
        {
            ToTable("Currency", schema);
            HasKey(x => x.CurrencyCode);

            Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}