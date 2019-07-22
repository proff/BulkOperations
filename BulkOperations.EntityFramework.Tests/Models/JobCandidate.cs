using System;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class JobCandidate
    {
        public virtual int JobCandidateID { get; set; }
        public virtual Nullable<int> BusinessEntityID { get; set; }
        public virtual string Resume { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
