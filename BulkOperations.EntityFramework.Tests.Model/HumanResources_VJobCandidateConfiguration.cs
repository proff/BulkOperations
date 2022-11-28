using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_VJobCandidateConfiguration : EntityTypeConfiguration<HumanResources_VJobCandidate>
    {
        public HumanResources_VJobCandidateConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_VJobCandidateConfiguration(string schema)
        {
            ToTable("vJobCandidate", schema);
            HasKey(x => new { x.JobCandidateId, x.ModifiedDate });

            Property(x => x.JobCandidateId).HasColumnName(@"JobCandidateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsOptional();
            Property(x => x.Name46Prefix).HasColumnName(@"Name.Prefix").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Name46First).HasColumnName(@"Name.First").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Middle).HasColumnName(@"Name.Middle").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Last).HasColumnName(@"Name.Last").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Name46Suffix).HasColumnName(@"Name.Suffix").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Skills).HasColumnName(@"Skills").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Addr46Type).HasColumnName(@"Addr.Type").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Addr46Loc46CountryRegion).HasColumnName(@"Addr.Loc.CountryRegion").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46Loc46State).HasColumnName(@"Addr.Loc.State").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46Loc46City).HasColumnName(@"Addr.Loc.City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Addr46PostalCode).HasColumnName(@"Addr.PostalCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(20);
            Property(x => x.EMail).HasColumnName(@"EMail").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.WebSite).HasColumnName(@"WebSite").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}