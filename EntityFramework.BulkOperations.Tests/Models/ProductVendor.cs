using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductVendor
    {
        public virtual int ProductID { get; set; }
        public virtual int BusinessEntityID { get; set; }
        public virtual int AverageLeadTime { get; set; }
        public virtual decimal StandardPrice { get; set; }
        public virtual Nullable<decimal> LastReceiptCost { get; set; }
        public virtual Nullable<System.DateTime> LastReceiptDate { get; set; }
        public virtual int MinOrderQty { get; set; }
        public virtual int MaxOrderQty { get; set; }
        public virtual Nullable<int> OnOrderQty { get; set; }
        public virtual string UnitMeasureCode { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
