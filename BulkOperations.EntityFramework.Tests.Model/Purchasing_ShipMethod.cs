using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_ShipMethod
    {
        
        
        
        public int ShipMethodId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public decimal ShipBase { get; set; } 

        
        
        
        public decimal ShipRate { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } 

        
        
        
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } 

        public Purchasing_ShipMethod()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Purchasing_PurchaseOrderHeaders = new List<Purchasing_PurchaseOrderHeader>();
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
        }
    }
}