namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class EmployeePayHistory
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual System.DateTime RateChangeDate { get; set; }
        public virtual decimal Rate { get; set; }
        public virtual byte PayFrequency { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
