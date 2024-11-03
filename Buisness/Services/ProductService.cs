using Buisness.Factories;
using Buisness.Interface;
using Buisness.Models;

namespace Buisness.Services;

public class ProductService : IProductService
{
    private readonly IProductValidator _productValidator;
    private readonly IProductRepository _productRepository;

    public ProductService(IProductValidator productValidator, IProductRepository productRepository)
    {
        _productValidator = productValidator;
        _productRepository = productRepository;       
    }
    public ProductServiceResult CreateProduct(ProductRequest request)
    {
        var validatorResult = _productValidator.Validate(request);
        if (validatorResult.Success)
        {
            var productEntity = ProductFactory.Create(request);
            if (productEntity != null) 
            { 
                var repositoryResult = _productRepository.Save(productEntity);
                if (repositoryResult.Success)
                {
                    var product = ProductFactory.Create(productEntity);
                    var serviceResult = new ProductServiceResult { Success = true};
                    return serviceResult;

                }
            }
        }
        var serviceResultError = new ProductServiceResult { Success = false };
        return serviceResultError;
    }
}
