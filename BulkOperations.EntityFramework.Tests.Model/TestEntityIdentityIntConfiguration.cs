using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BulkOperations.EntityFramework.Tests.Model;

public class TestEntityIdentityIntConfiguration : EntityTypeConfiguration<TestEntityIdentityInt>
{
    public TestEntityIdentityIntConfiguration()
    {
        ToTable("TestEntityIdentityInt");
        HasKey(x => x.Id);

        Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired()
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    }
}