using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Currency
    {
        public Currency()
        {
            this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
            this.CurrencyRates = new List<CurrencyRate>();
            this.CurrencyRates1 = new List<CurrencyRate>();
        }

        public virtual string CurrencyCode { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }
    }
}
