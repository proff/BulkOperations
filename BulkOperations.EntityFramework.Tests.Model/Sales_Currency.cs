using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_Currency
    {
        
        
        
        public string CurrencyCode { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } 

        
        
        
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRates_FromCurrencyCode { get; set; } 

        
        
        
        public virtual ICollection<Sales_CurrencyRate> Sales_CurrencyRates_ToCurrencyCode { get; set; } 

        public Sales_Currency()
        {
            ModifiedDate = DateTime.Now;
            Sales_CountryRegionCurrencies = new List<Sales_CountryRegionCurrency>();
            Sales_CurrencyRates_FromCurrencyCode = new List<Sales_CurrencyRate>();
            Sales_CurrencyRates_ToCurrencyCode = new List<Sales_CurrencyRate>();
        }
    }
}