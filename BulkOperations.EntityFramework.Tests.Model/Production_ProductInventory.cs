using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Production_ProductInventory
    {
        
        
        
        public int ProductId { get; set; } 

        
        
        
        public short LocationId { get; set; } 

        
        
        
        public string Shelf { get; set; } 

        
        
        
        public byte Bin { get; set; } 

        
        
        
        public short Quantity { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Production_Location Production_Location { get; set; } 

        
        
        
        public virtual Production_Product Production_Product { get; set; } 

        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}