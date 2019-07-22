using System;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vPersonDemographic
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual Nullable<decimal> TotalPurchaseYTD { get; set; }
        public virtual Nullable<System.DateTime> DateFirstPurchase { get; set; }
        public virtual Nullable<System.DateTime> BirthDate { get; set; }
        public virtual string MaritalStatus { get; set; }
        public virtual string YearlyIncome { get; set; }
        public virtual string Gender { get; set; }
        public virtual Nullable<int> TotalChildren { get; set; }
        public virtual Nullable<int> NumberChildrenAtHome { get; set; }
        public virtual string Education { get; set; }
        public virtual string Occupation { get; set; }
        public virtual Nullable<bool> HomeOwnerFlag { get; set; }
        public virtual Nullable<int> NumberCarsOwned { get; set; }
    }
}
