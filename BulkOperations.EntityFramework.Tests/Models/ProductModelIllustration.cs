namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ProductModelIllustration
    {
        public virtual int ProductModelID { get; set; }
        public virtual int IllustrationID { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Illustration Illustration { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
