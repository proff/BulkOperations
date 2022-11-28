using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class HumanResources_Employee
    {
        
        
        
        public int BusinessEntityId { get; set; } 

        
        
        
        public string NationalIdNumber { get; set; } 

        
        
        
        public string LoginId { get; set; } 

        
        
        
        public System.Data.Entity.Hierarchy.HierarchyId OrganizationNode { get; set; } 

        
        
        
        public short? OrganizationLevel { get; private set; } 

        
        
        
        public string JobTitle { get; set; } 

        
        
        
        public DateTime BirthDate { get; set; } 

        
        
        
        public string MaritalStatus { get; set; } 

        
        
        
        public string Gender { get; set; } 

        
        
        
        public DateTime HireDate { get; set; } 

        
        
        
        public bool SalariedFlag { get; set; } 

        
        
        
        public short VacationHours { get; set; } 

        
        
        
        public short SickLeaveHours { get; set; } 

        
        
        
        public bool CurrentFlag { get; set; } 

        
        
        
        public Guid Rowguid { get; set; } 

        
        
        
        public DateTime ModifiedDate { get; set; } 

        

        
        
        
        public virtual ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } 

        
        
        
        public virtual ICollection<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } 

        
        
        
        public virtual ICollection<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } 

        
        
        
        public virtual ICollection<Production_Document> Production_Documents { get; set; } 

        
        
        
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } 

        
        
        
        public virtual Sales_SalesPerson Sales_SalesPerson { get; set; } 

        

        
        
        
        public virtual Person_Person Person_Person { get; set; } 

        public HumanResources_Employee()
        {
            SalariedFlag = true;
            VacationHours = 0;
            SickLeaveHours = 0;
            CurrentFlag = true;
            Rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
            Production_Documents = new List<Production_Document>();
            HumanResources_EmployeeDepartmentHistories = new List<HumanResources_EmployeeDepartmentHistory>();
            HumanResources_EmployeePayHistories = new List<HumanResources_EmployeePayHistory>();
            HumanResources_JobCandidates = new List<HumanResources_JobCandidate>();
            Purchasing_PurchaseOrderHeaders = new List<Purchasing_PurchaseOrderHeader>();
        }
    }
}