using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_EmployeeConfiguration : EntityTypeConfiguration<HumanResources_Employee>
    {
        public HumanResources_EmployeeConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_EmployeeConfiguration(string schema)
        {
            ToTable("Employee", schema);
            HasKey(x => x.BusinessEntityId);

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NationalIdNumber).HasColumnName(@"NationalIDNumber").HasColumnType("nvarchar").IsRequired().HasMaxLength(15);
            Property(x => x.LoginId).HasColumnName(@"LoginID").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            Property(x => x.OrganizationNode).HasColumnName(@"OrganizationNode").HasColumnType("hierarchyid").IsOptional();
            Property(x => x.OrganizationLevel).HasColumnName(@"OrganizationLevel").HasColumnType("smallint").IsOptional().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.JobTitle).HasColumnName(@"JobTitle").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.BirthDate).HasColumnName(@"BirthDate").HasColumnType("date").IsRequired();
            Property(x => x.MaritalStatus).HasColumnName(@"MaritalStatus").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Gender).HasColumnName(@"Gender").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.HireDate).HasColumnName(@"HireDate").HasColumnType("date").IsRequired();
            Property(x => x.SalariedFlag).HasColumnName(@"SalariedFlag").HasColumnType("bit").IsRequired();
            Property(x => x.VacationHours).HasColumnName(@"VacationHours").HasColumnType("smallint").IsRequired();
            Property(x => x.SickLeaveHours).HasColumnName(@"SickLeaveHours").HasColumnType("smallint").IsRequired();
            Property(x => x.CurrentFlag).HasColumnName(@"CurrentFlag").HasColumnType("bit").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Person_Person).WithOptional(b => b.HumanResources_Employee).WillCascadeOnDelete(false); 
        }
    }
}