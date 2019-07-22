using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class Illustration
    {
        public Illustration()
        {
            this.ProductModelIllustrations = new List<ProductModelIllustration>();
        }

        public virtual int IllustrationID { get; set; }
        public virtual string Diagram { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}
