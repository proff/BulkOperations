using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_Customer
    {
        
        
        
        public int CustomerId { get; set; } 

        
        
        
        public int? PersonId { get; set; } 

        
        
        
        public int? StoreId { get; set; } 

        
        
        
        public int? TerritoryId { get; set; } 

        
        
        
        public string AccountNumber { get; private set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        
        
        
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } 

        
        
        
        public virtual Sales_Store Sales_Store { get; set; } 

        public Sales_Customer()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
        }
    }
}