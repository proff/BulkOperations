using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class WorkOrderRouting
    {
        public virtual int WorkOrderID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual short OperationSequence { get; set; }
        public virtual short LocationID { get; set; }
        public virtual System.DateTime ScheduledStartDate { get; set; }
        public virtual System.DateTime ScheduledEndDate { get; set; }
        public virtual Nullable<System.DateTime> ActualStartDate { get; set; }
        public virtual Nullable<System.DateTime> ActualEndDate { get; set; }
        public virtual Nullable<decimal> ActualResourceHrs { get; set; }
        public virtual decimal PlannedCost { get; set; }
        public virtual Nullable<decimal> ActualCost { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Location Location { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
