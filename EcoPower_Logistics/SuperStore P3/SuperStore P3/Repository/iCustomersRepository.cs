using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iCustomersRepository : iGenericRepository<Customer>
    {
        Customer GetMostRecentCustomer();
    }
}
