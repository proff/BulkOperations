using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_SalesTaxRate
    {
        
        
        
        public int SalesTaxRateId { get; set; } 

        
        
        
        public int StateProvinceId { get; set; } 

        
        
        
        public byte TaxType { get; set; } 

        
        
        
        public decimal TaxRate { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_StateProvince Person_StateProvince { get; set; } 

        public Sales_SalesTaxRate()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}