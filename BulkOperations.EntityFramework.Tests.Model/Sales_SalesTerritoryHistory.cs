using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTerritoryHistory
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int TerritoryId { get; set; } 

        
        
        
        public DateTime StartDate { get; set; } 

        
        
        
        public DateTime? EndDate { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } 

        
        
        
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } 

        public Sales_SalesTerritoryHistory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}