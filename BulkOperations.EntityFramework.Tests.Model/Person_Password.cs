using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class Person_Password
    {
        public int BusinessEntityId { get; set; } 

        
        
        
        public string PasswordHash { get; set; } 

        
        
        
        public string PasswordSalt { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        public Person_Password()
        {
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }
    }
}