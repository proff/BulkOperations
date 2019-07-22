using System;

namespace BulkOperations.EntityFramework.Tests.Models
{
    public partial class ErrorLog
    {
        public virtual int ErrorLogID { get; set; }
        public virtual System.DateTime ErrorTime { get; set; }
        public virtual string UserName { get; set; }
        public virtual int ErrorNumber { get; set; }
        public virtual Nullable<int> ErrorSeverity { get; set; }
        public virtual Nullable<int> ErrorState { get; set; }
        public virtual string ErrorProcedure { get; set; }
        public virtual Nullable<int> ErrorLine { get; set; }
        public virtual string ErrorMessage { get; set; }
    }
}
