using System;
using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            this.SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            this.Stores = new List<Store>();
        }

        public virtual int BusinessEntityID { get; set; }
        public virtual Nullable<int> TerritoryID { get; set; }
        public virtual Nullable<decimal> SalesQuota { get; set; }
        public virtual decimal Bonus { get; set; }
        public virtual decimal CommissionPct { get; set; }
        public virtual decimal SalesYTD { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}
