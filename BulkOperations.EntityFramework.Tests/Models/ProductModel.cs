using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            this.Products = new List<Product>();
            this.ProductModelIllustrations = new List<ProductModelIllustration>();
            this.ProductModelProductDescriptionCultures = new List<ProductModelProductDescriptionCulture>();
        }

        public virtual int ProductModelID { get; set; }
        public virtual string Name { get; set; }
        public virtual string CatalogDescription { get; set; }
        public virtual string Instructions { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
    }
}
