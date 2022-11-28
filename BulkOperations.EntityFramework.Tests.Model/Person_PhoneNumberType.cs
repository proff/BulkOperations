using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_PhoneNumberType
    {
        
        
        
        public int PhoneNumberTypeId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_PersonPhone> Person_PersonPhones { get; set; } 

        public Person_PhoneNumberType()
        {
            ModifiedDate = DateTime.Now;
            Person_PersonPhones = new List<Person_PersonPhone>();
        }
    }
}