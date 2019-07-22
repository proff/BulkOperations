using System.Collections.Generic;

namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public virtual int CurrencyRateID { get; set; }
        public virtual System.DateTime CurrencyRateDate { get; set; }
        public virtual string FromCurrencyCode { get; set; }
        public virtual string ToCurrencyCode { get; set; }
        public virtual decimal AverageRate { get; set; }
        public virtual decimal EndOfDayRate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
