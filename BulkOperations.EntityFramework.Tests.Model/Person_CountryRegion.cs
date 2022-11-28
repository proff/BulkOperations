using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_CountryRegion
    {
        
        
        
        public string CountryRegionCode { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_StateProvince> Person_StateProvinces { get; set; } 

        
        
        
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } 

        public Person_CountryRegion()
        {
            ModifiedDate = DateTime.Now;
            Sales_CountryRegionCurrencies = new List<Sales_CountryRegionCurrency>();
            Sales_SalesTerritories = new List<Sales_SalesTerritory>();
            Person_StateProvinces = new List<Person_StateProvince>();
        }
    }
}