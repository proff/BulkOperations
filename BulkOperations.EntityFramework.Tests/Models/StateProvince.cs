using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class StateProvince
    {
        public StateProvince()
        {
            this.Addresses = new List<Address>();
            this.SalesTaxRates = new List<SalesTaxRate>();
        }

        public virtual int StateProvinceID { get; set; }
        public virtual string StateProvinceCode { get; set; }
        public virtual string CountryRegionCode { get; set; }
        public virtual bool IsOnlyStateProvinceFlag { get; set; }
        public virtual string Name { get; set; }
        public virtual int TerritoryID { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}
