using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesReason
    {
        
        
        
        public int SalesReasonId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public string ReasonType { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } 

        public Sales_SalesReason()
        {
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeaderSalesReasons = new List<Sales_SalesOrderHeaderSalesReason>();
        }
    }
}