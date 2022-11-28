using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Purchasing_Vendor
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public string AccountNumber { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public byte CreditRating { get; set; } 

        
        
        
        public bool PreferredVendorStatus { get; set; } 

        
        
        
        public bool ActiveFlag { get; set; } 

        
        
        
        public string PurchasingWebServiceUrl { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } 

        
        
        
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } 

        

        
        
        
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } 

        public Purchasing_Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = DateTime.Now;
            Purchasing_ProductVendors = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderHeaders = new List<Purchasing_PurchaseOrderHeader>();
        }
    }
}