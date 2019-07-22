namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class EmailAddress
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual int EmailAddressID { get; set; }
        public virtual string EmailAddress1 { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
