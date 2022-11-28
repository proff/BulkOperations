using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CreditCardConfiguration : EntityTypeConfiguration<Sales_CreditCard>
    {
        public Sales_CreditCardConfiguration()
            : this("Sales")
        {
        }

        public Sales_CreditCardConfiguration(string schema)
        {
            ToTable("CreditCard", schema);
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName(@"CreditCardID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName(@"CardType").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName(@"CardNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName(@"ExpMonth").HasColumnType("tinyint").IsRequired();
            Property(x => x.ExpYear).HasColumnName(@"ExpYear").HasColumnType("smallint").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}