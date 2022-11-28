using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_WorkOrder
    {
        
        
        
        public int WorkOrderId { get; set; } 

        
        
        
        public int ProductId { get; set; } 

        
        
        
        public int OrderQty { get; set; } 

        
        
        
        public int StockedQty { get; private set; } 

        
        
        
        public short ScrappedQty { get; set; } 

        
        
        
        public DateTime StartDate { get; set; } 

        
        
        
        public DateTime? EndDate { get; set; } 

        
        
        
        public DateTime DueDate { get; set; } 

        
        
        
        public short? ScrapReasonId { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        
        
        
        public virtual Production_ScrapReason Production_ScrapReason { get; set; } 

        public Production_WorkOrder()
        {
            ModifiedDate = DateTime.Now;
            Production_WorkOrderRoutings = new List<Production_WorkOrderRouting>();
        }
    }
}