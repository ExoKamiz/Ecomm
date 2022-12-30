using Ecomm.Server.Data;
using Ecomm.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public async Task<ActionResult<ServiceResponse<List<Products>>>> GetProduct()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
    }
}
