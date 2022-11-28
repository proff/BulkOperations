using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Sales_Store
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public int? SalesPersonId { get; set; } 

        
        
        
        public string Demographics { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Sales_Customer> Sales_Customers { get; set; } 

        

        
        
        
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } 

        
        
        
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } 

        public Sales_Store()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Sales_Customers = new List<Sales_Customer>();
        }
    }
}