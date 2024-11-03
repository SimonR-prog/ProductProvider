using Buisness.Models;

namespace Buisness.Interface;

public interface IProductValidator
{
    ProductValidatorResult Validate(ProductRequest request);
}
