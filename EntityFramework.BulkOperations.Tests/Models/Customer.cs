using System;
using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int CustomerID { get; set; }
        public virtual Nullable<int> PersonID { get; set; }
        public virtual Nullable<int> StoreID { get; set; }
        public virtual Nullable<int> TerritoryID { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
