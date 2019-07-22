using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            this.WorkOrders = new List<WorkOrder>();
        }

        public virtual short ScrapReasonID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
