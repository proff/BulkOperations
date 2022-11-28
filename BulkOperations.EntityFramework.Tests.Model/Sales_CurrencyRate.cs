using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_CurrencyRate
    {
        
        
        
        public int CurrencyRateId { get; set; } 

        
        
        
        public DateTime CurrencyRateDate { get; set; } 

        
        
        
        public string FromCurrencyCode { get; set; } 

        
        
        
        public string ToCurrencyCode { get; set; } 

        
        
        
        public decimal AverageRate { get; set; } 

        
        
        
        public decimal EndOfDayRate { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        

        
        
        
        public virtual Sales_Currency Sales_Currency_FromCurrencyCode { get; set; } 

        
        
        
        public virtual Sales_Currency Sales_Currency_ToCurrencyCode { get; set; } 

        public Sales_CurrencyRate()
        {
            ModifiedDate = DateTime.Now;
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
        }
    }
}