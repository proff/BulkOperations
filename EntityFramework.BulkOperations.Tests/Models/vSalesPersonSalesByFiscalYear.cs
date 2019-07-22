using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vSalesPersonSalesByFiscalYear
    {
        public virtual Nullable<int> SalesPersonID { get; set; }
        public virtual string FullName { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string SalesTerritory { get; set; }
        public virtual Nullable<decimal> C2002 { get; set; }
        public virtual Nullable<decimal> C2003 { get; set; }
        public virtual Nullable<decimal> C2004 { get; set; }
    }
}
