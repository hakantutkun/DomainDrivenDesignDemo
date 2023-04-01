using Order.Application.Repository;

namespace Order.Infrastructure.Repository
{
    internal class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }
}
