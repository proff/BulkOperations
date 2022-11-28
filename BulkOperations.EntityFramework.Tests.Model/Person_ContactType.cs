using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_ContactType
    {
        
        
        
        public int ContactTypeId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } 

        public Person_ContactType()
        {
            ModifiedDate = DateTime.Now;
            Person_BusinessEntityContacts = new List<Person_BusinessEntityContact>();
        }
    }
}