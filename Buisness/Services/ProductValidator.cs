using Buisness.Interface;
using Buisness.Models;
namespace Buisness.Services;

public class ProductValidator : IProductValidator
{
    public ProductValidatorResult Validate(ProductRequest request)
    {
        return new ProductValidatorResult { Success = true };
    }
}
