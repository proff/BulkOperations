using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_AddressTypeConfiguration : EntityTypeConfiguration<Person_AddressType>
    {
        public Person_AddressTypeConfiguration()
            : this("Person")
        {
        }

        public Person_AddressTypeConfiguration(string schema)
        {
            ToTable("AddressType", schema);
            HasKey(x => x.AddressTypeId);

            Property(x => x.AddressTypeId).HasColumnName(@"AddressTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}