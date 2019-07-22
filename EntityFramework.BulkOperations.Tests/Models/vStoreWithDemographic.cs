using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vStoreWithDemographic
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string Name { get; set; }
        public virtual Nullable<decimal> AnnualSales { get; set; }
        public virtual Nullable<decimal> AnnualRevenue { get; set; }
        public virtual string BankName { get; set; }
        public virtual string BusinessType { get; set; }
        public virtual Nullable<int> YearOpened { get; set; }
        public virtual string Specialty { get; set; }
        public virtual Nullable<int> SquareFeet { get; set; }
        public virtual string Brands { get; set; }
        public virtual string Internet { get; set; }
        public virtual Nullable<int> NumberEmployees { get; set; }
    }
}
