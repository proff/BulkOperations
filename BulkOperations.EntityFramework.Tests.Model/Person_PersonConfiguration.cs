using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PersonConfiguration : EntityTypeConfiguration<Person_Person>
    {
        public Person_PersonConfiguration()
            : this("Person")
        {
        }

        public Person_PersonConfiguration(string schema)
        {
            ToTable("Person", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.PersonType).HasColumnName(@"PersonType").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.NameStyle).HasColumnName(@"NameStyle").HasColumnType("bit").IsRequired();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName(@"Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.EmailPromotion).HasColumnName(@"EmailPromotion").HasColumnType("int").IsRequired();
            Property(x => x.AdditionalContactInfo).HasColumnName(@"AdditionalContactInfo").HasColumnType("xml").IsOptional();
            Property(x => x.Demographics).HasColumnName(@"Demographics").HasColumnType("xml").IsOptional();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_BusinessEntity).WithOptional(b => b.Person_Person).WillCascadeOnDelete(false); 
        }
    }
}