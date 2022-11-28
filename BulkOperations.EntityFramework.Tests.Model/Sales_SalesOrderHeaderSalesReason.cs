using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesOrderHeaderSalesReason
    {
        
        
        
        public int SalesOrderId { get; set; } 

        
        
        
        public int SalesReasonId { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } 

        
        
        
        public virtual Sales_SalesReason Sales_SalesReason { get; set; } 

        public Sales_SalesOrderHeaderSalesReason()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}