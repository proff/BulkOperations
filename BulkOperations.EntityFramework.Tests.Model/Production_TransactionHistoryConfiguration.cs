using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_TransactionHistoryConfiguration : EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration()
            : this("Production")
        {
        }

        public Production_TransactionHistoryConfiguration(string schema)
        {
            ToTable("TransactionHistory", schema);
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName(@"TransactionID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.ReferenceOrderId).HasColumnName(@"ReferenceOrderID").HasColumnType("int").IsRequired();
            Property(x => x.ReferenceOrderLineId).HasColumnName(@"ReferenceOrderLineID").HasColumnType("int").IsRequired();
            Property(x => x.TransactionDate).HasColumnName(@"TransactionDate").HasColumnType("datetime").IsRequired();
            Property(x => x.TransactionType).HasColumnName(@"TransactionType").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsRequired();
            Property(x => x.ActualCost).HasColumnName(@"ActualCost").HasColumnType("money").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_TransactionHistories).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}