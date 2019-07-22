using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public virtual int SpecialOfferID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
