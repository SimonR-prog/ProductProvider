using Buisness.Models;

namespace Buisness.Factories;

public static class ProductFactory
{
    public static ProductEntity Create(ProductRequest request)
    {
        return new ProductEntity
        {
            Id = Guid.NewGuid().ToString(),
            Name = request.Name,
            Price = request.Price,
            Category = new CategoryEntity
            {
                CategoryName = request.Category!
            }
        };
    }
    public static Product Create(ProductEntity entity)
    {
        return new Product
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            CategoryName = entity.Category.CategoryName

        };
    }
}
