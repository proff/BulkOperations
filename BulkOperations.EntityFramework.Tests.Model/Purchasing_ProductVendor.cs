using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_ProductVendor
    {
        
        
        
        public int ProductId { get; set; } 

        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int AverageLeadTime { get; set; } 

        
        
        
        public decimal StandardPrice { get; set; } 

        
        
        
        public decimal? LastReceiptCost { get; set; } 

        
        
        
        public DateTime? LastReceiptDate { get; set; } 

        
        
        
        public int MinOrderQty { get; set; } 

        
        
        
        public int MaxOrderQty { get; set; } 

        
        
        
        public int? OnOrderQty { get; set; } 

        
        
        
        public string UnitMeasureCode { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        
        
        
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } 

        
        
        
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } 

        public Purchasing_ProductVendor()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}