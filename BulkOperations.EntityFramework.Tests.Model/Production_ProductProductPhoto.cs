using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductProductPhoto
    {
        
        
        
        public int ProductId { get; set; } 

        
        
        
        public int ProductPhotoId { get; set; } 

        
        
        
        public bool Primary { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        
        
        
        public virtual Production_ProductPhoto Production_ProductPhoto { get; set; } 

        public Production_ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = DateTime.Now;
        }
    }
}