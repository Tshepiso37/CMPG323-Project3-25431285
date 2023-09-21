using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository : GenericRepository<Customer>
    {
        public CustomersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(customer => customer.CustomerId).FirstOrDefault();
        }
    }



}


