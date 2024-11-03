using Buisness.Models;

namespace Buisness.Interface;

public interface IProductRepository
{
    public ProductRepositoryResult Save(ProductEntity entity);
}
