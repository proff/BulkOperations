using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_VJobCandidateEmploymentConfiguration : EntityTypeConfiguration<HumanResources_VJobCandidateEmployment>
    {
        public HumanResources_VJobCandidateEmploymentConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_VJobCandidateEmploymentConfiguration(string schema)
        {
            ToTable("vJobCandidateEmployment", schema);
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName(@"JobCandidateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Emp46StartDate).HasColumnName(@"Emp.StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Emp46EndDate).HasColumnName(@"Emp.EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Emp46OrgName).HasColumnName(@"Emp.OrgName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46JobTitle).HasColumnName(@"Emp.JobTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46Responsibility).HasColumnName(@"Emp.Responsibility").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46FunctionCategory).HasColumnName(@"Emp.FunctionCategory").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46IndustryCategory).HasColumnName(@"Emp.IndustryCategory").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46CountryRegion).HasColumnName(@"Emp.Loc.CountryRegion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46State).HasColumnName(@"Emp.Loc.State").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46City).HasColumnName(@"Emp.Loc.City").HasColumnType("nvarchar(max)").IsOptional();
        }
    }
}