using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductModelIllustration
    {
        
        
        
        public int ProductModelId { get; set; } 

        
        
        
        public int IllustrationId { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Illustration Production_Illustration { get; set; } 

        
        
        
        public virtual Production_ProductModel Production_ProductModel { get; set; } 

        public Production_ProductModelIllustration()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}