using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_CultureConfiguration : EntityTypeConfiguration<Production_Culture>
    {
        public Production_CultureConfiguration()
            : this("Production")
        {
        }

        public Production_CultureConfiguration(string schema)
        {
            ToTable("Culture", schema);
            HasKey(x => x.CultureId);

            Property(x => x.CultureId).HasColumnName(@"CultureID").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}