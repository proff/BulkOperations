using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_ShiftConfiguration : EntityTypeConfiguration<HumanResources_Shift>
    {
        public HumanResources_ShiftConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_ShiftConfiguration(string schema)
        {
            ToTable("Shift", schema);
            HasKey(x => x.ShiftId);

            Property(x => x.ShiftId).HasColumnName(@"ShiftID").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.StartTime).HasColumnName(@"StartTime").HasColumnType("time").IsRequired();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("time").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}