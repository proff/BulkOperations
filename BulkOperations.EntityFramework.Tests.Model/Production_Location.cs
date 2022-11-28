using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_Location
    {
        
        
        
        public short LocationId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public decimal CostRate { get; set; } 

        
        
        
        public decimal Availability { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_ProductInventory> Production_ProductInventories { get; set; } 

        
        
        
        public virtual ICollection<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } 

        public Production_Location()
        {
            ModifiedDate = DateTime.Now;
            Production_ProductInventories = new List<Production_ProductInventory>();
            Production_WorkOrderRoutings = new List<Production_WorkOrderRouting>();
        }
    }
}