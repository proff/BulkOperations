using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_BusinessEntityAddressConfiguration : EntityTypeConfiguration<Person_BusinessEntityAddress>
    {
        public Person_BusinessEntityAddressConfiguration()
            : this("Person")
        {
        }

        public Person_BusinessEntityAddressConfiguration(string schema)
        {
            ToTable("BusinessEntityAddress", schema);
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName(@"AddressTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Address).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.AddressId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_AddressType).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.AddressTypeId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Person_BusinessEntity).WithMany(b => b.Person_BusinessEntityAddresses).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}