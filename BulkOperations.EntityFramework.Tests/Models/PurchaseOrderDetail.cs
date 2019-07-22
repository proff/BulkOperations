namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class PurchaseOrderDetail
    {
        public virtual int PurchaseOrderID { get; set; }
        public virtual int PurchaseOrderDetailID { get; set; }
        public virtual System.DateTime DueDate { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual int ProductID { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal LineTotal { get; set; }
        public virtual decimal ReceivedQty { get; set; }
        public virtual decimal RejectedQty { get; set; }
        public virtual decimal StockedQty { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
