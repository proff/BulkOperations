using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_EmailAddress
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int EmailAddressId { get; set; } 

        
        
        
        public string EmailAddress { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        public Person_EmailAddress()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}