using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductCategory
    {
        
        
        
        public int ProductCategoryId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductSubcategory> Production_ProductSubcategories { get; set; } 

        public Production_ProductCategory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_ProductSubcategories = new List<Production_ProductSubcategory>();
        }
    }
}