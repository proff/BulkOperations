using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            this.BusinessEntityAddresses = new List<BusinessEntityAddress>();
        }

        public virtual int AddressTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
    }
}
