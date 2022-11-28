using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_TransactionHistory
    {
        
        
        
        public int TransactionId { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public int ReferenceOrderId { get; set; } 

        
        
        
        public int ReferenceOrderLineId { get; set; } 

        
        
        
        public DateTime TransactionDate { get; set; } 

        
        
        
        public string TransactionType { get; set; } 

        
        
        
        public int Quantity { get; set; } 

        
        
        
        public decimal ActualCost { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        public Production_TransactionHistory()
        {
            ReferenceOrderLineId = 0;
            TransactionDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}