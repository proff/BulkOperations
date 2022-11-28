using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_VStoreWithContactConfiguration : EntityTypeConfiguration<Sales_VStoreWithContact>
    {
        public Sales_VStoreWithContactConfiguration()
            : this("Sales")
        {
        }

        public Sales_VStoreWithContactConfiguration(string schema)
        {
            ToTable("vStoreWithContacts", schema);
            HasKey(x => new { x.BusinessEntityId, x.Name, x.ContactType, x.FirstName, x.LastName, x.EmailPromotion });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ContactType).HasColumnName(@"ContactType").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suffix).HasColumnName(@"Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(25);
            Property(x => x.PhoneNumberType).HasColumnName(@"PhoneNumberType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.EmailPromotion).HasColumnName(@"EmailPromotion").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}