using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
        }

        public virtual int ContactTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
