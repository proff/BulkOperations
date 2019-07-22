using System;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vJobCandidateEmployment
    {
        public virtual int JobCandidateID { get; set; }
        public virtual Nullable<System.DateTime> Emp_StartDate { get; set; }
        public virtual Nullable<System.DateTime> Emp_EndDate { get; set; }
        public virtual string Emp_OrgName { get; set; }
        public virtual string Emp_JobTitle { get; set; }
        public virtual string Emp_Responsibility { get; set; }
        public virtual string Emp_FunctionCategory { get; set; }
        public virtual string Emp_IndustryCategory { get; set; }
        public virtual string Emp_Loc_CountryRegion { get; set; }
        public virtual string Emp_Loc_State { get; set; }
        public virtual string Emp_Loc_City { get; set; }
    }
}
