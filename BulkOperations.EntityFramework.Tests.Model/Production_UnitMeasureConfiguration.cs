using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_UnitMeasureConfiguration : EntityTypeConfiguration<Production_UnitMeasure>
    {
        public Production_UnitMeasureConfiguration()
            : this("Production")
        {
        }

        public Production_UnitMeasureConfiguration(string schema)
        {
            ToTable("UnitMeasure", schema);
            HasKey(x => x.UnitMeasureCode);

            Property(x => x.UnitMeasureCode).HasColumnName(@"UnitMeasureCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}