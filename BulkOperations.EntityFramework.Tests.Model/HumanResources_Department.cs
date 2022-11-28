using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_Department
    {
        
        
        
        public short DepartmentId { get; set; } 

        
        
        
        public string Name { get; set; } 

        
        
        
        public string GroupName { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } 

        public HumanResources_Department()
        {
            ModifiedDate = DateTime.Now;
            HumanResources_EmployeeDepartmentHistories = new List<HumanResources_EmployeeDepartmentHistory>();
        }
    }
}