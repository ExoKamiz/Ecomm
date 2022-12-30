﻿using static System.Net.WebRequestMethods;

//принимает результат из Server с помощью HttpClient
namespace Ecomm.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Products> Products { get; set; } = new List<Products>();

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Products>>>("api/Product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}
