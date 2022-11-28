using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_ContactTypeConfiguration : EntityTypeConfiguration<Person_ContactType>
    {
        public Person_ContactTypeConfiguration()
            : this("Person")
        {
        }

        public Person_ContactTypeConfiguration(string schema)
        {
            ToTable("ContactType", schema);
            HasKey(x => x.ContactTypeId);

            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}