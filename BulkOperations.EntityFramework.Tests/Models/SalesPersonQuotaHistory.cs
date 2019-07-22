namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class SalesPersonQuotaHistory
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual System.DateTime QuotaDate { get; set; }
        public virtual decimal SalesQuota { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
