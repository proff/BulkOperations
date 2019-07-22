namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class SalesTaxRate
    {
        public virtual int SalesTaxRateID { get; set; }
        public virtual int StateProvinceID { get; set; }
        public virtual byte TaxType { get; set; }
        public virtual decimal TaxRate { get; set; }
        public virtual string Name { get; set; }
        public virtual System.Guid rowguid { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual StateProvince StateProvince { get; set; }
    }
}
