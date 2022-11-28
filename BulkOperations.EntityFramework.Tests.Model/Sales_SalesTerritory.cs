using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTerritory
    {
        
        
        
        public int TerritoryId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public string CountryRegionCode { get; set; } 

        
        
        
        public string Group { get; set; } 

        
        
        
        public decimal SalesYtd { get; set; } 

        
        
        
        public decimal SalesLastYear { get; set; } 

        
        
        
        public decimal CostYtd { get; set; } 

        
        
        
        public decimal CostLastYear { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_StateProvince> Person_StateProvinces { get; set; } 

        
        
        
        public virtual ICollection<Sales_Customer> Sales_Customers { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesPerson> Sales_SalesPersons { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } 

        

        
        
        
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } 

        public Sales_SalesTerritory()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_Customers = new List<Sales_Customer>();
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
            Sales_SalesPersons = new List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistories = new List<Sales_SalesTerritoryHistory>();
            Person_StateProvinces = new List<Person_StateProvince>();
        }
    }
}