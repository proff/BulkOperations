using System.Data.Entity.Infrastructure;

namespace BulkOperations.EntityFramework.Tests.Model
{
    public class AdventureWorksContextFactory : IDbContextFactory<AdventureWorksContext>
    {
        public AdventureWorksContext Create()
        {
            return new AdventureWorksContext();
        }
    }
}