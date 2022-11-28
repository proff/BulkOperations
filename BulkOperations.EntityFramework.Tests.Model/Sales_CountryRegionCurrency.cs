using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CountryRegionCurrency
    {
        
        
        
        public string CountryRegionCode { get; set; } 

        
        
        
        public string CurrencyCode { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } 

        
        
        
        public virtual Sales_Currency Sales_Currency { get; set; } 

        public Sales_CountryRegionCurrency()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}