namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ProductProductPhoto
    {
        public virtual int ProductID { get; set; }
        public virtual int ProductPhotoID { get; set; }
        public virtual bool Primary { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductPhoto ProductPhoto { get; set; }
    }
}
