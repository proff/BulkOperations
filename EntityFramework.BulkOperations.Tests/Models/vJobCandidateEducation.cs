using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vJobCandidateEducation
    {
        public virtual int JobCandidateID { get; set; }
        public virtual string Edu_Level { get; set; }
        public virtual Nullable<System.DateTime> Edu_StartDate { get; set; }
        public virtual Nullable<System.DateTime> Edu_EndDate { get; set; }
        public virtual string Edu_Degree { get; set; }
        public virtual string Edu_Major { get; set; }
        public virtual string Edu_Minor { get; set; }
        public virtual string Edu_GPA { get; set; }
        public virtual string Edu_GPAScale { get; set; }
        public virtual string Edu_School { get; set; }
        public virtual string Edu_Loc_CountryRegion { get; set; }
        public virtual string Edu_Loc_State { get; set; }
        public virtual string Edu_Loc_City { get; set; }
    }
}
