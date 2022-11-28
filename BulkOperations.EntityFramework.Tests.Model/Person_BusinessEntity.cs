using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_BusinessEntity
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } 

        
        
        
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } 

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        
        
        
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } 

        
        
        
        public virtual Sales_Store Sales_Store { get; set; } 

        public Person_BusinessEntity()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_BusinessEntityAddresses = new List<Person_BusinessEntityAddress>();
            Person_BusinessEntityContacts = new List<Person_BusinessEntityContact>();
        }
    }
}