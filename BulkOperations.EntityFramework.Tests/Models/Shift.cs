using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class Shift
    {
        public Shift()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

        public virtual byte ShiftID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.TimeSpan StartTime { get; set; }
        public virtual System.TimeSpan EndTime { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}
