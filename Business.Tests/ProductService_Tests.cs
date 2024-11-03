using Buisness.Interface;
using Buisness.Models;
using Buisness.Services;
using Moq;

namespace Business.Tests;

public class ProductService_Tests
{
    private readonly IProductValidator _productValidator;
    private readonly IProductService _productService;
    private readonly Mock<IProductRepository> _mockProductRepository;

    public ProductService_Tests()
    {
        _productValidator = new ProductValidator();
        _mockProductRepository = new Mock<IProductRepository>();
        _productService = new ProductService(_productValidator,_mockProductRepository.Object);
    }

    [Fact]
    public void CreateProduct_ShouldCreateProduct_ReturnSuccess()
    {
        //ARRANGE
        var productRequest = new ProductRequest { Name = "asdad", Price = 100, Category = "C1" };
        var repositoryResult = new ProductRepositoryResult { Success = true };
        _mockProductRepository.Setup(x => x.Save(It.IsAny<ProductEntity>())).Returns(repositoryResult);

        //ACT
        var result = _productService.CreateProduct(productRequest);

        //ASSERT
        Assert.True(result.Success);
    }
}
