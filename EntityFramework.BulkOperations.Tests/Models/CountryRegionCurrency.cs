namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class CountryRegionCurrency
    {
        public virtual string CountryRegionCode { get; set; }
        public virtual string CurrencyCode { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
