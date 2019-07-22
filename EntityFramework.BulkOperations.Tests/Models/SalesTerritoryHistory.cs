using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class SalesTerritoryHistory
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual int TerritoryID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual Nullable<System.DateTime> EndDate { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
