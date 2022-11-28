using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class ErrorLogConfiguration : EntityTypeConfiguration<ErrorLog>
    {
        public ErrorLogConfiguration()
            : this("dbo")
        {
        }

        public ErrorLogConfiguration(string schema)
        {
            ToTable("ErrorLog", schema);
            HasKey(x => x.ErrorLogId);

            Property(x => x.ErrorLogId).HasColumnName(@"ErrorLogID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ErrorTime).HasColumnName(@"ErrorTime").HasColumnType("datetime").IsRequired();
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.ErrorNumber).HasColumnName(@"ErrorNumber").HasColumnType("int").IsRequired();
            Property(x => x.ErrorSeverity).HasColumnName(@"ErrorSeverity").HasColumnType("int").IsOptional();
            Property(x => x.ErrorState).HasColumnName(@"ErrorState").HasColumnType("int").IsOptional();
            Property(x => x.ErrorProcedure).HasColumnName(@"ErrorProcedure").HasColumnType("nvarchar").IsOptional().HasMaxLength(126);
            Property(x => x.ErrorLine).HasColumnName(@"ErrorLine").HasColumnType("int").IsOptional();
            Property(x => x.ErrorMessage).HasColumnName(@"ErrorMessage").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
        }
    }
}