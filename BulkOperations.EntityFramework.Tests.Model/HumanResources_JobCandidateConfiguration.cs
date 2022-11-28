using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_JobCandidateConfiguration : EntityTypeConfiguration<HumanResources_JobCandidate>
    {
        public HumanResources_JobCandidateConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_JobCandidateConfiguration(string schema)
        {
            ToTable("JobCandidate", schema);
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName(@"JobCandidateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsOptional();
            Property(x => x.Resume).HasColumnName(@"Resume").HasColumnType("xml").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_JobCandidates).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}