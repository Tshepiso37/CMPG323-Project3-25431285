using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iOrderDetailsRepository : iGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentOrderDetails();
    }
}
