using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PersonPhoneConfiguration : EntityTypeConfiguration<Person_PersonPhone>
    {
        public Person_PersonPhoneConfiguration()
            : this("Person")
        {
        }

        public Person_PersonPhoneConfiguration(string schema)
        {
            ToTable("PersonPhone", schema);
            HasKey(x => new { x.BusinessEntityId, x.PhoneNumber, x.PhoneNumberTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(25).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName(@"PhoneNumberTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_PersonPhones).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_PhoneNumberType).WithMany(b => b.Person_PersonPhones).HasForeignKey(c => c.PhoneNumberTypeId).WillCascadeOnDelete(false); 
        }
    }
}