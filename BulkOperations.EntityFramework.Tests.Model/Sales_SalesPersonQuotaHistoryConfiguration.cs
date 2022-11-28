using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesPersonQuotaHistoryConfiguration : EntityTypeConfiguration<Sales_SalesPersonQuotaHistory>
    {
        public Sales_SalesPersonQuotaHistoryConfiguration()
            : this("Sales")
        {
        }

        public Sales_SalesPersonQuotaHistoryConfiguration(string schema)
        {
            ToTable("SalesPersonQuotaHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.QuotaDate });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.QuotaDate).HasColumnName(@"QuotaDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.SalesQuota).HasColumnName(@"SalesQuota").HasColumnType("money").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Sales_SalesPerson).WithMany(b => b.Sales_SalesPersonQuotaHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false); 
        }
    }
}