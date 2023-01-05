namespace Ecomm.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Products>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Products>();
            var product = await _context.ProductsC.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Products>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Products>>
            {
                Data = await _context.ProductsC.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Products>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Products>>
            {
                Data = await _context.ProductsC
                   .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                   .ToListAsync()
            };

            return response;
        }
    }
}
