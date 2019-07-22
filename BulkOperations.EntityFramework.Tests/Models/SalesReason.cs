using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SalesReason
    {
        public SalesReason()
        {
            this.SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }

        public virtual int SalesReasonID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ReasonType { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
    }
}
