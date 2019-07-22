namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class PersonCreditCard
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual int CreditCardID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
