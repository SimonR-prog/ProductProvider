using Buisness.Models;

namespace Buisness.Interface;

public interface IProductService
{
    ProductServiceResult CreateProduct(ProductRequest request);
}
