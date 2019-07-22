namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class SalesOrderHeaderSalesReason
    {
        public virtual int SalesOrderID { get; set; }
        public virtual int SalesReasonID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}
