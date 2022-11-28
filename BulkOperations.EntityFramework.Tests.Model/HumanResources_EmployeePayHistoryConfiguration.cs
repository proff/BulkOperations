using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_EmployeePayHistoryConfiguration : EntityTypeConfiguration<HumanResources_EmployeePayHistory>
    {
        public HumanResources_EmployeePayHistoryConfiguration()
            : this("HumanResources")
        {
        }

        public HumanResources_EmployeePayHistoryConfiguration(string schema)
        {
            ToTable("EmployeePayHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName(@"RateChangeDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rate).HasColumnName(@"Rate").HasColumnType("money").IsRequired();
            Property(x => x.PayFrequency).HasColumnName(@"PayFrequency").HasColumnType("tinyint").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_EmployeePayHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}