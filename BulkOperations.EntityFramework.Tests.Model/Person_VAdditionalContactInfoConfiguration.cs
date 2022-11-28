using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_VAdditionalContactInfoConfiguration : EntityTypeConfiguration<Person_VAdditionalContactInfo>
    {
        public Person_VAdditionalContactInfoConfiguration()
            : this("Person")
        {
        }

        public Person_VAdditionalContactInfoConfiguration(string schema)
        {
            ToTable("vAdditionalContactInfo", schema);
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.Rowguid, x.ModifiedDate });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TelephoneNumber).HasColumnName(@"TelephoneNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.TelephoneSpecialInstructions).HasColumnName(@"TelephoneSpecialInstructions").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Street).HasColumnName(@"Street").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.StateProvince).HasColumnName(@"StateProvince").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName(@"PostalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CountryRegion).HasColumnName(@"CountryRegion").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.HomeAddressSpecialInstructions).HasColumnName(@"HomeAddressSpecialInstructions").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.EMailAddress).HasColumnName(@"EMailAddress").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.EMailSpecialInstructions).HasColumnName(@"EMailSpecialInstructions").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.EMailTelephoneNumber).HasColumnName(@"EMailTelephoneNumber").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}