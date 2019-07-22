using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public virtual int PurchaseOrderID { get; set; }
        public virtual byte RevisionNumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual int EmployeeID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ShipMethodID { get; set; }
        public virtual System.DateTime OrderDate { get; set; }
        public virtual Nullable<System.DateTime> ShipDate { get; set; }
        public virtual decimal SubTotal { get; set; }
        public virtual decimal TaxAmt { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual decimal TotalDue { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
