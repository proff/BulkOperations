using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_StateProvinceConfiguration : EntityTypeConfiguration<Person_StateProvince>
    {
        public Person_StateProvinceConfiguration()
            : this("Person")
        {
        }

        public Person_StateProvinceConfiguration(string schema)
        {
            ToTable("StateProvince", schema);
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName(@"StateProvinceCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName(@"IsOnlyStateProvinceFlag").HasColumnType("bit").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Person_StateProvinces).HasForeignKey(c => c.CountryRegionCode).WillCascadeOnDelete(false); 
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Person_StateProvinces).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false); 
        }
    }
}