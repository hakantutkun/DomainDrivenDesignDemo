using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.BuyerModels
{
    public class Buyer : BaseEntity
    {
        public string UserName { get; private set; }

        public Buyer(string userName)
        {
            UserName = userName;
        }

    }
}
