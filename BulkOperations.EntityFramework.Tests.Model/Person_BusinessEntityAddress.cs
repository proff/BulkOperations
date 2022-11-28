using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_BusinessEntityAddress
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int AddressId { get; set; } 

        
        
        
        public int AddressTypeId { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_Address Person_Address { get; set; } 

        
        
        
        public virtual Person_AddressType Person_AddressType { get; set; } 

        
        
        
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } 

        public Person_BusinessEntityAddress()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}