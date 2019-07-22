namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ShoppingCartItem
    {
        public virtual int ShoppingCartItemID { get; set; }
        public virtual string ShoppingCartID { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int ProductID { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
