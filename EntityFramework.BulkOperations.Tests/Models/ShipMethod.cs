using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int ShipMethodID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal ShipBase { get; set; }
        public virtual decimal ShipRate { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
