using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PasswordConfiguration : EntityTypeConfiguration<Person_Password>
    {
        public Person_PasswordConfiguration()
            : this("Person")
        {
        }

        public Person_PasswordConfiguration(string schema)
        {
            ToTable("Password", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PasswordHash).HasColumnName(@"PasswordHash").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(128);
            Property(x => x.PasswordSalt).HasColumnName(@"PasswordSalt").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Person).WithOptional(b => b.Person_Password).WillCascadeOnDelete(false); 
        }
    }
}