using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_LocationConfiguration : EntityTypeConfiguration<Production_Location>
    {
        public Production_LocationConfiguration()
            : this("Production")
        {
        }

        public Production_LocationConfiguration(string schema)
        {
            ToTable("Location", schema);
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName(@"LocationID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName(@"CostRate").HasColumnType("smallmoney").IsRequired();
            Property(x => x.Availability).HasColumnName(@"Availability").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}