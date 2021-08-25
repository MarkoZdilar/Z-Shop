using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;
using ZShop.Shared.ProductModels;

namespace ZShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);
        Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest requestModel);
        Task<EditProductResponse> EditProduct(ProductEditModel requestModel);
        Task<AddProductResponse> AddProduct(ProductEditModel requestModel);
    }
}
