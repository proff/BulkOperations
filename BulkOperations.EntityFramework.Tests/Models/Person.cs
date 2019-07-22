using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class Person
    {
        public Person()
        {
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
            this.EmailAddresses = new List<EmailAddress>();
            this.Customers = new List<Customer>();
            this.PersonCreditCards = new List<PersonCreditCard>();
            this.PersonPhones = new List<PersonPhone>();
        }

        public virtual int BusinessEntityID { get; set; }
        public virtual string PersonType { get; set; }
        public virtual bool NameStyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual int EmailPromotion { get; set; }
        public virtual string AdditionalContactInfo { get; set; }
        public virtual string Demographics { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
