using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_WorkOrderConfiguration : EntityTypeConfiguration<Production_WorkOrder>
    {
        public Production_WorkOrderConfiguration()
            : this("Production")
        {
        }

        public Production_WorkOrderConfiguration(string schema)
        {
            ToTable("WorkOrder", schema);
            HasKey(x => x.WorkOrderId);

            Property(x => x.WorkOrderId).HasColumnName(@"WorkOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("int").IsRequired();
            Property(x => x.StockedQty).HasColumnName(@"StockedQty").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ScrappedQty).HasColumnName(@"ScrappedQty").HasColumnType("smallint").IsRequired();
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ScrapReasonId).HasColumnName(@"ScrapReasonID").HasColumnType("smallint").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasOptional(a => a.Production_ScrapReason).WithMany(b => b.Production_WorkOrders).HasForeignKey(c => c.ScrapReasonId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_WorkOrders).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false); 
        }
    }
}