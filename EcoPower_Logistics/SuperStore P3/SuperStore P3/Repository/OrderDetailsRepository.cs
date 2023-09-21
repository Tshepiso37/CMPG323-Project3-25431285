using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentOrderDetails()
        {
            return _context.OrderDetails.OrderByDescending(orderDetail => orderDetail.OrderDetailsId).FirstOrDefault();
        }
    }

}
