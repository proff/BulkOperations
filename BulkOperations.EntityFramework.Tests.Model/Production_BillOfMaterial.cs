using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_BillOfMaterial
    {
        
        
        
        public int BillOfMaterialsId { get; set; } 

        
        
        
        public int? ProductAssemblyId { get; set; } 

        
        
        
        public int ComponentId { get; set; } 

        
        
        
        public DateTime StartDate { get; set; } 

        
        
        
        public DateTime? EndDate { get; set; } 

        
        
        
        public string UnitMeasureCode { get; set; } 

        
        
        
        public short BomLevel { get; set; } 

        
        
        
        public decimal PerAssemblyQty { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Product Component { get; set; } 

        
        
        
        public virtual Production_Product ProductAssembly { get; set; } 

        
        
        
        public virtual Production_UnitMeasure Production_UnitMeasure { get; set; } 

        public Production_BillOfMaterial()
        {
            StartDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}