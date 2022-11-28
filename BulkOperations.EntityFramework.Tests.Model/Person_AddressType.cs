using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_AddressType
    {
        
        
        
        public int AddressTypeId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } 

        public Person_AddressType()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Person_BusinessEntityAddresses = new List<Person_BusinessEntityAddress>();
        }
    }
}