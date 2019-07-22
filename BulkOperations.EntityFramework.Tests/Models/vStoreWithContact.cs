namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class vStoreWithContact
    {
        public virtual int BusinessEntityID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ContactType { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string PhoneNumberType { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int EmailPromotion { get; set; }
    }
}
