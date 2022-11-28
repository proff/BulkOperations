using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderDetail
    {
        
        
        
        public int SalesOrderId { get; set; } 

        
        
        
        public int SalesOrderDetailId { get; set; } 

        
        
        
        public string CarrierTrackingNumber { get; set; } 

        
        
        
        public short OrderQty { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public int SpecialOfferId { get; set; } 

        
        
        
        public decimal UnitPrice { get; set; } 

        
        
        
        public decimal UnitPriceDiscount { get; set; } 

        
        
        
        public decimal LineTotal { get; private set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } 

        
        
        
        public virtual Sales_SpecialOfferProduct Sales_SpecialOfferProduct { get; set; } 

        public Sales_SalesOrderDetail()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}