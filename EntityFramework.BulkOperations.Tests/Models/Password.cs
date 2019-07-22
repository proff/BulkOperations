namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Password
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string PasswordSalt { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
    }
}
