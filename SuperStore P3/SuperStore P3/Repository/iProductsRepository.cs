using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iProductsRepository : iGenericRepository<Product>
    {
        Product GetMostRecentProduct();
    }
}
