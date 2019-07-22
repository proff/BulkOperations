namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vVendorWithAddress
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string Name { get; set; }
        public virtual string AddressType { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvinceName { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string CountryRegionName { get; set; }
    }
}
