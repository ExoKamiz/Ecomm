namespace Ecomm.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Products> Products { get; set; }
        Task GetProducts(string? categotyUrl = null);
        Task<ServiceResponse<Products>> GetProduct(int productId);
    }
}
