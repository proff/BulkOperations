using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_PurchaseOrderHeader
    {
        
        
        
        public int PurchaseOrderId { get; set; } 

        
        
        
        public byte RevisionNumber { get; set; } 

        
        
        
        public byte Status { get; set; } 

        
        
        
        public int EmployeeId { get; set; } 

        
        
        
        public int VendorId { get; set; } 

        
        
        
        public int ShipMethodId { get; set; } 

        
        
        
        public DateTime OrderDate { get; set; } 

        
        
        
        public DateTime? ShipDate { get; set; } 

        
        
        
        public decimal SubTotal { get; set; } 

        
        
        
        public decimal TaxAmt { get; set; } 

        
        
        
        public decimal Freight { get; set; } 

        
        
        
        public decimal TotalDue { get; private set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        
        
        
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } 

        
        
        
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } 

        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
            Purchasing_PurchaseOrderDetails = new List<Purchasing_PurchaseOrderDetail>();
        }
    }
}