using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vProductModelInstruction
    {
        public virtual int ProductModelID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Instructions { get; set; }
        public virtual Nullable<int> LocationID { get; set; }
        public virtual Nullable<decimal> SetupHours { get; set; }
        public virtual Nullable<decimal> MachineHours { get; set; }
        public virtual Nullable<decimal> LaborHours { get; set; }
        public virtual Nullable<int> LotSize { get; set; }
        public virtual string Step { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
    }
}
