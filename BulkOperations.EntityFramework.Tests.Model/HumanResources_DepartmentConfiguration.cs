using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_DepartmentConfiguration : EntityTypeConfiguration<HumanResources_Department>
    {
        public HumanResources_DepartmentConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_DepartmentConfiguration(string schema)
        {
            ToTable("Department", schema);
            HasKey(x => x.DepartmentId);

            Property(x => x.DepartmentId).HasColumnName(@"DepartmentID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();
        }
    }
}