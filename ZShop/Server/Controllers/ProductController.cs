using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Server.Attributes;
using ZShop.Server.Services.ProductService;
using ZShop.Shared;
using ZShop.Shared.ProductModels;

namespace ZShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService; //Dep injection, we register this in Startup.cs

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }

        [HttpGet("Search/{searchText}")] //Full route will be api/[controller]/Search/{searchText}
        public async Task<ActionResult<List<Product>>> SearchProducts(string searchText)
        {
            return Ok(await _productService.SearchProducts(searchText));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            return Ok(await _productService.CreateProduct(product));
        }

        [HttpPost("Delete")]
        [TypeFilter(typeof(TokenAuthorize))]
        public async Task<IActionResult> DeleteProduct([FromBody]DeleteProductRequest request)
        {
            var deletionResult = await _productService.DeleteProduct(request.Id);

            return Ok(new DeleteProductResponse { Success = deletionResult });
        }

        [HttpPost("Edit")]
        [TypeFilter(typeof(TokenAuthorize))]
        public async Task<IActionResult> EditProduct([FromBody] ProductEditModel request)
        {
            var editResult = await _productService.UpdateProduct(request); 

            return Ok(new EditProductResponse { Success = editResult });
        }

        [HttpPost("Add")]
        [TypeFilter(typeof(TokenAuthorize))]
        public async Task<IActionResult> AddProduct([FromBody] ProductEditModel request)
        {
            var addResult = await _productService.AddProduct(request);

            return Ok(new AddProductResponse { Success = addResult.Success, Id = addResult.Id });
        }
    }
}
