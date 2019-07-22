using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductListPriceHistory
    {
        public virtual int ProductID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual Nullable<System.DateTime> EndDate { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
