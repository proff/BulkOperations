using System;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class BillOfMaterial
    {
        public virtual int BillOfMaterialsID { get; set; }
        public virtual Nullable<int> ProductAssemblyID { get; set; }
        public virtual int ComponentID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual Nullable<System.DateTime> EndDate { get; set; }
        public virtual string UnitMeasureCode { get; set; }
        public virtual short BOMLevel { get; set; }
        public virtual decimal PerAssemblyQty { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
    }
}
