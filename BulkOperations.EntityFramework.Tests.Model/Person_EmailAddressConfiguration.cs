using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_EmailAddressConfiguration : EntityTypeConfiguration<Person_EmailAddress>
    {
        public Person_EmailAddressConfiguration()
            : this("Person")
        {
        }

        public Person_EmailAddressConfiguration(string schema)
        {
            ToTable("EmailAddress", schema);
            HasKey(x => new { x.BusinessEntityId, x.EmailAddressId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EmailAddressId).HasColumnName(@"EmailAddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Person).WithMany(b => b.Person_EmailAddresses).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}