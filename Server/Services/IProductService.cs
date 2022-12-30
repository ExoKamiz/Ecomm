using Ecomm.Shared;

namespace Ecomm.Server.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Products>>> GetProductsAsync();

    }
}
