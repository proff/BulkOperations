namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class DatabaseLog
    {
        public virtual int DatabaseLogID { get; set; }
        public virtual System.DateTime PostTime { get; set; }
        public virtual string DatabaseUser { get; set; }
        public virtual string Event { get; set; }
        public virtual string Schema { get; set; }
        public virtual string Object { get; set; }
        public virtual string TSQL { get; set; }
        public virtual string XmlEvent { get; set; }
    }
}
