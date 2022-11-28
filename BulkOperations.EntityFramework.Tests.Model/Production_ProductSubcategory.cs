using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductSubcategory
    {
        
        
        
        public int ProductSubcategoryId { get; set; } 

        
        
        
        public int ProductCategoryId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_Product> Production_Products { get; set; } 

        

        
        
        
        public virtual Production_ProductCategory Production_ProductCategory { get; set; } 

        public Production_ProductSubcategory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_Products = new List<Production_Product>();
        }
    }
}