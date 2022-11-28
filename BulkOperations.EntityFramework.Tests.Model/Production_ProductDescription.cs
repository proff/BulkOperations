using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductDescription
    {
        
        
        
        public int ProductDescriptionId { get; set; } 

        
        
        
        public string Description { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } 

        public Production_ProductDescription()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_ProductModelProductDescriptionCultures = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}