using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PhoneNumberTypeConfiguration : EntityTypeConfiguration<Person_PhoneNumberType>
    {
        public Person_PhoneNumberTypeConfiguration()
            : this("Person")
        {
        }

        public Person_PhoneNumberTypeConfiguration(string schema)
        {
            ToTable("PhoneNumberType", schema);
            HasKey(x => x.PhoneNumberTypeId);

            Property(x => x.PhoneNumberTypeId).HasColumnName(@"PhoneNumberTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}