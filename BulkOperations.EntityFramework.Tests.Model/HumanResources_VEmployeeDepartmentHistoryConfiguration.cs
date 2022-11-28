using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_VEmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<HumanResources_VEmployeeDepartmentHistory>
    {
        public HumanResources_VEmployeeDepartmentHistoryConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_VEmployeeDepartmentHistoryConfiguration(string schema)
        {
            ToTable("vEmployeeDepartmentHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.Shift, x.Department, x.GroupName, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.MiddleName).HasColumnName(@"MiddleName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suffix).HasColumnName(@"Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(10);
            Property(x => x.Shift).HasColumnName(@"Shift").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Department).HasColumnName(@"Department").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.GroupName).HasColumnName(@"GroupName").HasColumnType("nvarchar").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("date").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("date").IsOptional();
        }
    }
}