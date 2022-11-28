using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductModel
    {
        
        
        
        public int ProductModelId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public string CatalogDescription { get; set; } 

        
        
        
        public string Instructions { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_Product> Production_Products { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } 

        
        
        
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } 

        public Production_ProductModel()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_Products = new List<Production_Product>();
            Production_ProductModelIllustrations = new List<Production_ProductModelIllustration>();
            Production_ProductModelProductDescriptionCultures = new List<Production_ProductModelProductDescriptionCulture>();
        }
    }
}