using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class EmployeeDepartmentHistory
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual short DepartmentID { get; set; }
        public virtual byte ShiftID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual Nullable<System.DateTime> EndDate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
