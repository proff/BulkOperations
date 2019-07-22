namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class SalesOrderDetail
    {
        public virtual int SalesOrderID { get; set; }
        public virtual int SalesOrderDetailID { get; set; }
        public virtual string CarrierTrackingNumber { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int SpecialOfferID { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal UnitPriceDiscount { get; set; }
        public virtual decimal LineTotal { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
