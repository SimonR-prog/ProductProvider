using Buisness.Factories;
using Buisness.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller")]
[ApiController]

public class ProductController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(ProductRequest request)
    {
        if (!ModelState.IsValid) 
        {
            var productEntity = ProductFactory.Create(request);
            var product = ProductFactory.Create(productEntity);

            return Created("", product);
        }
        return BadRequest(request);
    }
}
