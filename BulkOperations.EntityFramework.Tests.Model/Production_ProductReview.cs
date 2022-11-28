using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductReview
    {
        
        
        
        public int ProductReviewId { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public string ReviewerName { get; set; } 

        
        
        
        public DateTime ReviewDate { get; set; } 

        
        
        
        public string EmailAddress { get; set; } 

        
        
        
        public int Rating { get; set; } 

        
        
        
        public string Comments { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        public Production_ProductReview()
        {
            ReviewDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}