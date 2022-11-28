using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PersonPhone
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public string PhoneNumber { get; set; } 

        
        
        
        public int PhoneNumberTypeId { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        
        
        
        public virtual Person_PhoneNumberType Person_PhoneNumberType { get; set; } 

        public Person_PersonPhone()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}