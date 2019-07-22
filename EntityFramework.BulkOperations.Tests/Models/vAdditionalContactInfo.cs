namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vAdditionalContactInfo
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string TelephoneNumber { get; set; }
        public virtual string TelephoneSpecialInstructions { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string StateProvince { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string CountryRegion { get; set; }
        public virtual string HomeAddressSpecialInstructions { get; set; }
        public virtual string EMailAddress { get; set; }
        public virtual string EMailSpecialInstructions { get; set; }
        public virtual string EMailTelephoneNumber { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
    }
}
