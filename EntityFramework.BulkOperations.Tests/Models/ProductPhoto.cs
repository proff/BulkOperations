using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            this.ProductProductPhotoes = new List<ProductProductPhoto>();
        }

        public virtual int ProductPhotoID { get; set; }
        public virtual byte[] ThumbNailPhoto { get; set; }
        public virtual string ThumbnailPhotoFileName { get; set; }
        public virtual byte[] LargePhoto { get; set; }
        public virtual string LargePhotoFileName { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }
    }
}
