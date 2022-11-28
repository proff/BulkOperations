using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_EmployeePayHistory
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public DateTime RateChangeDate { get; set; } 

        
        
        
        public decimal Rate { get; set; } 

        
        
        
        public byte PayFrequency { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        public HumanResources_EmployeePayHistory()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}