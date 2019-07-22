namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vStateProvinceCountryRegion
    {
        public virtual int StateProvinceID { get; set; }
        public virtual string StateProvinceCode { get; set; }
        public virtual bool IsOnlyStateProvinceFlag { get; set; }
        public virtual string StateProvinceName { get; set; }
        public virtual int TerritoryID { get; set; }
        public virtual string CountryRegionCode { get; set; }
        public virtual string CountryRegionName { get; set; }
    }
}
