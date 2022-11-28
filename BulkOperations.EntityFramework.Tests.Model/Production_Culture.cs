using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_Culture
    {
        
        
        
        public string CultureId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } 

        public Production_Culture()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductModelProductDescriptionCultures = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}