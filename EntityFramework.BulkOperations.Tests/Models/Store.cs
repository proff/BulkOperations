using System;
using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Store
    {
        public Store()
        {
            this.Customers = new List<Customer>();
        }

        public virtual int BusinessEntityID { get; set; }
        public virtual string Name { get; set; }
        public virtual Nullable<int> SalesPersonID { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
