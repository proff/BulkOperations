using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            this.StateProvinces = new List<StateProvince>();
            this.Customers = new List<Customer>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.SalesPersons = new List<SalesPerson>();
            this.SalesTerritoryHistories = new List<SalesTerritoryHistory>();
        }

        public virtual int TerritoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual string CountryRegionCode { get; set; }
        public virtual string Group { get; set; }
        public virtual decimal SalesYTD { get; set; }
        public virtual decimal SalesLastYear { get; set; }
        public virtual decimal CostYTD { get; set; }
        public virtual decimal CostLastYear { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
    }
}
