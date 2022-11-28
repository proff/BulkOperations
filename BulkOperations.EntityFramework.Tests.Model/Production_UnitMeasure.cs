using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_UnitMeasure
    {
        
        
        
        public string UnitMeasureCode { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Production_BillOfMaterial> Production_BillOfMaterials { get; set; } 

        
        
        
        public virtual ICollection<Production_Product> Production_Products_SizeUnitMeasureCode { get; set; } 

        
        
        
        public virtual ICollection<Production_Product> Production_Products_WeightUnitMeasureCode { get; set; } 

        
        
        
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } 

        public Production_UnitMeasure()
        {
            ModifiedDate = DateTime.Now;
            Production_BillOfMaterials = new List<Production_BillOfMaterial>();
            Production_Products_SizeUnitMeasureCode = new List<Production_Product>();
            Production_Products_WeightUnitMeasureCode = new List<Production_Product>();
            Purchasing_ProductVendors = new List<Purchasing_ProductVendor>();
        }
    }
}