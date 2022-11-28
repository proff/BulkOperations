using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesPerson
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int? TerritoryId { get; set; } 

        
        
        
        public decimal? SalesQuota { get; set; } 

        
        
        
        public decimal Bonus { get; set; } 

        
        
        
        public decimal CommissionPct { get; set; } 

        
        
        
        public decimal SalesYtd { get; set; } 

        
        
        
        public decimal SalesLastYear { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } 

        
        
        
        public virtual ICollection<Sales_Store> Sales_Stores { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        
        
        
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } 

        public Sales_SalesPerson()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
            Sales_SalesPersonQuotaHistories = new List<Sales_SalesPersonQuotaHistory>();
            Sales_SalesTerritoryHistories = new List<Sales_SalesTerritoryHistory>();
            Sales_Stores = new List<Sales_Store>();
        }
    }
}