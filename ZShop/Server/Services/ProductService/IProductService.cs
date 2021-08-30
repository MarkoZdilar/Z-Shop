using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;
using ZShop.Shared.ProductModels;

namespace ZShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProducts(string searchText);
        Task<bool> DeleteProduct(int id);
        Task<EditProductResponse> UpdateProduct(ProductEditModel productEditModel);
        Task<AddProductResponse> AddProduct(ProductAddModel productEditModel);
    }
}
