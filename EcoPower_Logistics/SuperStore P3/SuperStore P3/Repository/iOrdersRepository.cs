using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iOrderRepository : iGenericRepository<Order>
    {
        Order GetMostRecentOrderDetail();
    }
}
