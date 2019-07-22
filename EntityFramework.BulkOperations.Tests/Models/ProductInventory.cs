namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductInventory
    {
        public virtual int ProductID { get; set; }
        public virtual short LocationID { get; set; }
        public virtual string Shelf { get; set; }
        public virtual byte Bin { get; set; }
        public virtual short Quantity { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
