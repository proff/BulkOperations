using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_EmployeeDepartmentHistoryConfiguration : EntityTypeConfiguration<HumanResources_EmployeeDepartmentHistory>
    {
        public HumanResources_EmployeeDepartmentHistoryConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_EmployeeDepartmentHistoryConfiguration(string schema)
        {
            ToTable("EmployeeDepartmentHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.StartDate, x.DepartmentId, x.ShiftId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName(@"DepartmentID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName(@"ShiftID").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("date").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("date").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.HumanResources_Department).WithMany(b => b.HumanResources_EmployeeDepartmentHistories).HasForeignKey(c => c.DepartmentId).WillCascadeOnDelete(false); 
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_EmployeeDepartmentHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
            HasRequired(a => a.HumanResources_Shift).WithMany(b => b.HumanResources_EmployeeDepartmentHistories).HasForeignKey(c => c.ShiftId).WillCascadeOnDelete(false); 
        }
    }
}