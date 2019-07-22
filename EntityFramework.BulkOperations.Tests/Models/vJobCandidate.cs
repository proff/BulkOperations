using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vJobCandidate
    {
        public virtual int JobCandidateID { get; set; }
        public virtual Nullable<int> BusinessEntityID { get; set; }
        public virtual string Name_Prefix { get; set; }
        public virtual string Name_First { get; set; }
        public virtual string Name_Middle { get; set; }
        public virtual string Name_Last { get; set; }
        public virtual string Name_Suffix { get; set; }
        public virtual string Skills { get; set; }
        public virtual string Addr_Type { get; set; }
        public virtual string Addr_Loc_CountryRegion { get; set; }
        public virtual string Addr_Loc_State { get; set; }
        public virtual string Addr_Loc_City { get; set; }
        public virtual string Addr_PostalCode { get; set; }
        public virtual string EMail { get; set; }
        public virtual string WebSite { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
    }
}
