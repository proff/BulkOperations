using System;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ProductCostHistory
    {
        public virtual int ProductID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual Nullable<System.DateTime> EndDate { get; set; }
        public virtual decimal StandardCost { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
