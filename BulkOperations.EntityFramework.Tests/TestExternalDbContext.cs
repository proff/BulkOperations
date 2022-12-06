using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using BulkOperations.EntityFramework.Tests.Model;

namespace BulkOperations.EntityFramework.Tests
{
    public partial class TestExternalDbContext : DbContext
    {
        static TestExternalDbContext()
        {
            Database.SetInitializer<TestExternalDbContext>(null);
        }

        public TestExternalDbContext()
            : base("Data Source=localhost,15826;Initial Catalog=test;User Id=sa;Password=Yf7(nk,&vT`|Zkiw")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TestEntityIdentityIntConfiguration());
        }
        
        public DbSet<TestEntityIdentityInt> TestEntityIdentityInts { get; set; }

    }
}
