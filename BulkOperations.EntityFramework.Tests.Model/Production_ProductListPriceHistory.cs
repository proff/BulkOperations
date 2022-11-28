using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductListPriceHistory
    {
        
        
        
        public int ProductId { get; set; } 

        
        
        
        public DateTime StartDate { get; set; } 

        
        
        
        public DateTime? EndDate { get; set; } 

        
        
        
        public decimal ListPrice { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        public Production_ProductListPriceHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}