using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            this.ProductVendors = new List<ProductVendor>();
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
        }

        public virtual int BusinessEntityID { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual byte CreditRating { get; set; }
        public virtual bool PreferredVendorStatus { get; set; }
        public virtual bool ActiveFlag { get; set; }
        public virtual string PurchasingWebServiceURL { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
    }
}
