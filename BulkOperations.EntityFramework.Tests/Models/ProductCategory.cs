using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.ProductSubcategories = new List<ProductSubcategory>();
        }

        public virtual int ProductCategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductSubcategory> ProductSubcategories { get; set; }
    }
}
