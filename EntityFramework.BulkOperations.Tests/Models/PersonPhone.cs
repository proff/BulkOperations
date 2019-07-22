namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class PersonPhone
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual int PhoneNumberTypeID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
