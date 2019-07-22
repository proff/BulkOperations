namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vProductAndDescription
    {
        public virtual int ProductID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProductModel { get; set; }
        public virtual string CultureID { get; set; }
        public virtual string Description { get; set; }
    }
}
