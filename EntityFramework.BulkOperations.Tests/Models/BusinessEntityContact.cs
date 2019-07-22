namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class BusinessEntityContact
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual int PersonID { get; set; }
        public virtual int ContactTypeID { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Person Person { get; set; }
    }
}
