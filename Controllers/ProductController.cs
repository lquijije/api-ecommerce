using Microsoft.AspNetCore.Mvc;
namespace api_ecommerce.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{
    IProductService customerService;

    public ProductController(IProductService customersv) {
        customerService = customersv;
    }

    [HttpGet]
    public IActionResult Get() {
        return Ok(customerService.Get());
    }
}