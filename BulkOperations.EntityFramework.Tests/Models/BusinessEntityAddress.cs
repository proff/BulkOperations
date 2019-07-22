namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class BusinessEntityAddress
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual int AddressID { get; set; }
        public virtual int AddressTypeID { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
