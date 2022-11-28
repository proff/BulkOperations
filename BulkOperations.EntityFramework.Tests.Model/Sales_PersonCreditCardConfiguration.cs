using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_PersonCreditCardConfiguration : EntityTypeConfiguration<Sales_PersonCreditCard>
    {
        public Sales_PersonCreditCardConfiguration()
            : this("Sales")
        {
        }

        public Sales_PersonCreditCardConfiguration(string schema)
        {
            ToTable("PersonCreditCard", schema);
            HasKey(x => new { x.BusinessEntityId, x.CreditCardId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreditCardId).HasColumnName(@"CreditCardID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Person).WithMany(b => b.Sales_PersonCreditCards).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_CreditCard).WithMany(b => b.Sales_PersonCreditCards).HasForeignKey(c => c.CreditCardId).WillCascadeOnDelete(false); 
        }
    }
}