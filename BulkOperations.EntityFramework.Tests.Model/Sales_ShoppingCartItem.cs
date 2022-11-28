using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_ShoppingCartItem
    {
        
        
        
        public int ShoppingCartItemId { get; set; } 

        
        
        
        public string ShoppingCartId { get; set; } 

        
        
        
        public int Quantity { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public DateTime DateCreated { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        public Sales_ShoppingCartItem()
        {
            Quantity = 1;
            DateCreated = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}