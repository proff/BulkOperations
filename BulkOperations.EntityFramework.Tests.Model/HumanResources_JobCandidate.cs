using System;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_JobCandidate
    {
        
        
        
        public int JobCandidateId { get; set; } 

        
        
        
        public int? BusinessEntityId { get; set; } 

        
        
        
        public string Resume { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } 

        public HumanResources_JobCandidate()
        {
            ModifiedDate = DateTime.Now;
        }
    }
}