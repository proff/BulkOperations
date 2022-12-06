using System.Data.Entity;

namespace BulkOperations.EntityFramework.Tests.Model;

public class TestDbContext : DbContext
{
    public TestDbContext() : base(
        "Data Source=localhost,15826;Initial Catalog=test;User Id=sa;Password=Yf7(nk,&vT`|Zkiw")
    {
    }

    public DbSet<TestEntityIdentityInt> TestEntityIdentityInts { get; set; }
}