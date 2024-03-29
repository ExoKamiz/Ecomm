﻿using Ecomm.Shared;

namespace Ecomm.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Products>>> GetProductsAsync();
        Task<ServiceResponse<Products>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Products>>> GetProductsByCategory(string categoryUrl);
    }
}
