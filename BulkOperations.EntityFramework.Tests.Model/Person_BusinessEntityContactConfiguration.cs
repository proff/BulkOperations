using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_BusinessEntityContactConfiguration : EntityTypeConfiguration<Person_BusinessEntityContact>
    {
        public Person_BusinessEntityContactConfiguration()
            : this("Person")
        {
        }

        public Person_BusinessEntityContactConfiguration(string schema)
        {
            ToTable("BusinessEntityContact", schema);
            HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName(@"PersonID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_BusinessEntity).WithMany(b => b.Person_BusinessEntityContacts).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_ContactType).WithMany(b => b.Person_BusinessEntityContacts).HasForeignKey(c => c.ContactTypeId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_BusinessEntityContacts).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); 
        }
    }
}