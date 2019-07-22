using System.Collections.Generic;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            this.PersonPhones = new List<PersonPhone>();
        }

        public virtual int PhoneNumberTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
