using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
        }

        public virtual int SpecialOfferID { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal DiscountPct { get; set; }
        public virtual string Type { get; set; }
        public virtual string Category { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime EndDate { get; set; }
        public virtual int MinQty { get; set; }
        public virtual Nullable<int> MaxQty { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
    }
}
