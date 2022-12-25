using Ecomm.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Products>>> GetProduct()
        {
            var product = await _context.ProductsC.ToListAsync();
            return Ok(product);
        }
    }
}
