using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iOrdersRepository : iGenericRepository<Order>
    {
        Order GetMostRecentOrder();
    }
}
