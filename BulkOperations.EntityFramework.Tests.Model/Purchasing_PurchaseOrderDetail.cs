using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_PurchaseOrderDetail
    {
        
        
        
        public int PurchaseOrderId { get; set; } 

        
        
        
        public int PurchaseOrderDetailId { get; set; } 

        
        
        
        public DateTime DueDate { get; set; } 

        
        
        
        public short OrderQty { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public decimal UnitPrice { get; set; } 

        
        
        
        public decimal LineTotal { get; private set; } 

        
        
        
        public decimal ReceivedQty { get; set; } 

        
        
        
        public decimal RejectedQty { get; set; } 

        
        
        
        public decimal StockedQty { get; private set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        
        
        
        public virtual Purchasing_PurchaseOrderHeader Purchasing_PurchaseOrderHeader { get; set; } 

        public Purchasing_PurchaseOrderDetail()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}