using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_Shift
    {
        
        
        
        public byte ShiftId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public TimeSpan StartTime { get; set; } 

        
        
        
        public TimeSpan EndTime { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } 

        public HumanResources_Shift()
        {
            ModifiedDate = DateTime.Now;
            HumanResources_EmployeeDepartmentHistories = new List<HumanResources_EmployeeDepartmentHistory>();
        }
    }
}