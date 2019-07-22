using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
            this.EmployeePayHistories = new List<EmployeePayHistory>();
            this.JobCandidates = new List<JobCandidate>();
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
        }

        public virtual int BusinessEntityID { get; set; }
        public virtual string NationalIDNumber { get; set; }
        public virtual string LoginID { get; set; }
        public virtual Nullable<short> OrganizationLevel { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual System.DateTime BirthDate { get; set; }
        public virtual string MaritalStatus { get; set; }
        public virtual string Gender { get; set; }
        public virtual System.DateTime HireDate { get; set; }
        public virtual bool SalariedFlag { get; set; }
        public virtual short VacationHours { get; set; }
        public virtual short SickLeaveHours { get; set; }
        public virtual bool CurrentFlag { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
