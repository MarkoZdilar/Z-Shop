using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ZShop.Shared;
using ZShop.Shared.ProductModels;

namespace ZShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
        }

        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request)
        {
            var deleteProductData = JsonSerializer.Serialize(request);
            var result = await _http.PostAsync("api/Product/Delete", new StringContent(deleteProductData, Encoding.UTF8, "application/json"));

            return JsonSerializer.Deserialize<DeleteProductResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<EditProductResponse> EditProduct(ProductEditModel request)
        {
            var editProductReqeust = JsonSerializer.Serialize(request);
            var result = await _http.PostAsync("api/Product/Edit", new StringContent(editProductReqeust, Encoding.UTF8, "application/json"));

            return JsonSerializer.Deserialize<EditProductResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<AddProductResponse> AddProduct(ProductEditModel request)
        {
            var editProductReqeust = JsonSerializer.Serialize(request);
            var result = await _http.PostAsync("api/Product/Add", new StringContent(editProductReqeust, Encoding.UTF8, "application/json"));

            return JsonSerializer.Deserialize<AddProductResponse>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
