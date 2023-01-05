using Ecomm.Server.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Icao;

namespace Ecomm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryController;

        public CategoryController(ICategoryService categoryController)
        {
            _categoryController = categoryController;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryController.GetCategories();
            return Ok(result);
        }
    }
}
