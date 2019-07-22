using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vSalesPerson
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string PhoneNumberType { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int EmailPromotion { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvinceName { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string CountryRegionName { get; set; }
        public virtual string TerritoryName { get; set; }
        public virtual string TerritoryGroup { get; set; }
        public virtual Nullable<decimal> SalesQuota { get; set; }
        public virtual decimal SalesYTD { get; set; }
        public virtual decimal SalesLastYear { get; set; }
    }
}
