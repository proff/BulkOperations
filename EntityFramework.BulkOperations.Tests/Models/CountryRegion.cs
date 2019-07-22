using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
            this.SalesTerritories = new List<SalesTerritory>();
            this.StateProvinces = new List<StateProvince>();
        }

        public virtual string CountryRegionCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
    }
}
