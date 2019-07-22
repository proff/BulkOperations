using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            this.Products = new List<Product>();
        }

        public virtual int ProductSubcategoryID { get; set; }
        public virtual int ProductCategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
