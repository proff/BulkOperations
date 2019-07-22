namespace EntityFramework.BulkOperations.Tests.Models
{
    public partial class AWBuildVersion
    {
        public virtual byte SystemInformationID { get; set; }
        public virtual string Database_Version { get; set; }
        public virtual System.DateTime VersionDate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }
    }
}
