using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            this.PersonCreditCards = new List<PersonCreditCard>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int CreditCardID { get; set; }
        public virtual string CardType { get; set; }
        public virtual string CardNumber { get; set; }
        public virtual byte ExpMonth { get; set; }
        public virtual short ExpYear { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
