using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Location
    {
        public Location()
        {
            this.ProductInventories = new List<ProductInventory>();
            this.WorkOrderRoutings = new List<WorkOrderRouting>();
        }

        public virtual short LocationID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal CostRate { get; set; }
        public virtual decimal Availability { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
