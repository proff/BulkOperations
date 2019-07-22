using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Department
    {
        public Department()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

        public virtual short DepartmentID { get; set; }
        public virtual string Name { get; set; }
        public virtual string GroupName { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
