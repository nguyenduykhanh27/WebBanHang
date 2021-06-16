using Ecommerce.Data.Entities;
using Ecommerce.Infrastructure.Interfaces;

namespace Ecommerce.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product,int>
    {
    }
}
