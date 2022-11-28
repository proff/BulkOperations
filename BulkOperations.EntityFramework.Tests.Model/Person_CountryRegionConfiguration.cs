using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_CountryRegionConfiguration : EntityTypeConfiguration<Person_CountryRegion>
    {
        public Person_CountryRegionConfiguration()
            : this("Person")
        {
        }

        public Person_CountryRegionConfiguration(string schema)
        {
            ToTable("CountryRegion", schema);
            HasKey(x => x.CountryRegionCode);

            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}