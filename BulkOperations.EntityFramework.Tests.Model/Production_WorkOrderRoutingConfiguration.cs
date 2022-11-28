using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_WorkOrderRoutingConfiguration : EntityTypeConfiguration<Production_WorkOrderRouting>
    {
        public Production_WorkOrderRoutingConfiguration()
            : this("Production")
        {
        }

        public Production_WorkOrderRoutingConfiguration(string schema)
        {
            ToTable("WorkOrderRouting", schema);
            HasKey(x => new { x.WorkOrderId, x.ProductId, x.OperationSequence });

            Property(x => x.WorkOrderId).HasColumnName(@"WorkOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.OperationSequence).HasColumnName(@"OperationSequence").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LocationId).HasColumnName(@"LocationID").HasColumnType("smallint").IsRequired();
            Property(x => x.ScheduledStartDate).HasColumnName(@"ScheduledStartDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ScheduledEndDate).HasColumnName(@"ScheduledEndDate").HasColumnType("datetime").IsRequired();
            Property(x => x.ActualStartDate).HasColumnName(@"ActualStartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualEndDate).HasColumnName(@"ActualEndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualResourceHrs).HasColumnName(@"ActualResourceHrs").HasColumnType("decimal").IsOptional().HasPrecision(9,4);
            Property(x => x.PlannedCost).HasColumnName(@"PlannedCost").HasColumnType("money").IsRequired();
            Property(x => x.ActualCost).HasColumnName(@"ActualCost").HasColumnType("money").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            
            HasRequired(a => a.Production_Location).WithMany(b => b.Production_WorkOrderRoutings).HasForeignKey(c => c.LocationId).WillCascadeOnDelete(false); 
            HasRequired(a => a.Production_WorkOrder).WithMany(b => b.Production_WorkOrderRoutings).HasForeignKey(c => c.WorkOrderId).WillCascadeOnDelete(false); 
        }
    }
}