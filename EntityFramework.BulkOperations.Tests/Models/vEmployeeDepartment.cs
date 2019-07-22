namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class vEmployeeDepartment
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string Department { get; set; }
        public virtual string GroupName { get; set; }
        public virtual System.DateTime StartDate { get; set; }
    }
}
