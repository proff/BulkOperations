using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ScrapReason
    {
        
        
        
        public short ScrapReasonId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_WorkOrder> Production_WorkOrders { get; set; } 

        public Production_ScrapReason()
        {
            ModifiedDate = DateTime.Now;
            Production_WorkOrders = new List<Production_WorkOrder>();
        }
    }
}