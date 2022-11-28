using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_BusinessEntityContact
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public int PersonId { get; set; } 

        
        
        
        public int ContactTypeId { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } 

        
        
        
        public virtual Person_ContactType Person_ContactType { get; set; } 

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        public Person_BusinessEntityContact()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}