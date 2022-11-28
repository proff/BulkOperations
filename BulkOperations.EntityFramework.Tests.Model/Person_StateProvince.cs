using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_StateProvince
    {
        
        
        
        public int StateProvinceId { get; set; } 

        
        
        
        public string StateProvinceCode { get; set; } 

        
        
        
        public string CountryRegionCode { get; set; } 

        
        
        
        public bool IsOnlyStateProvinceFlag { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public int TerritoryId { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_Address> Person_Addresses { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } 

        

        
        
        
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } 

        
        
        
        public virtual Sales_SalesTerritory Sales_SalesTerritory { get; set; } 

        public Person_StateProvince()
        {
            IsOnlyStateProvinceFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_Addresses = new List<Person_Address>();
            Sales_SalesTaxRates = new List<Sales_SalesTaxRate>();
        }
    }
}