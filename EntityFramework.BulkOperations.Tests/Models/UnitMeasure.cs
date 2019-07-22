using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            this.BillOfMaterials = new List<BillOfMaterial>();
            this.Products = new List<Product>();
            this.Products1 = new List<Product>();
            this.ProductVendors = new List<ProductVendor>();
        }

        public virtual string UnitMeasureCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Product> Products1 { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
    }
}
