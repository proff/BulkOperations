using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            this.ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public virtual int ProductDescriptionID { get; set; }
        public virtual string Description { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}
