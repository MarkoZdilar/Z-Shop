using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Server.Data;
using ZShop.Server.Services.CategoryService;
using ZShop.Shared;
using ZShop.Shared.ProductModels;

namespace ZShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _context
                .Products
                .FindAsync(id);

            if (product == null)
                return false;

            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p => p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Platform)
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                .Where(p => p.Title.Contains(searchText))
                .ToListAsync();
        }

        public async Task<EditProductResponse> UpdateProduct(ProductEditModel productEditModel)
        {
            var product = await _context
                .Products
                .Include(o => o.Variants)
                .FirstOrDefaultAsync(p => p.Id == productEditModel.Id);

            if (product == null)
                return new EditProductResponse { Success = false };

            product.Title = productEditModel.Title;
            product.CategoryId = productEditModel.CategoryId;
            product.Description = productEditModel.Description;
            product.Image = productEditModel.Image;
            product.DateUpdated = DateTime.Now;

            product.Variants.Clear();
            product.Variants.AddRange(productEditModel.Variants);


            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return new EditProductResponse { Success = false };
            }
            return new EditProductResponse { Success = true };
        }

        public async Task<AddProductResponse> AddProduct(ProductAddModel productEditModel)
        {
            var product = new Product
            {
                CategoryId = productEditModel.CategoryId,
                Title = productEditModel.Title,
                DateCreated = DateTime.Now,
                Image = productEditModel.Image,
                Description = productEditModel.Description,
                Variants = productEditModel.Variants
            };

            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return new AddProductResponse { Success = false };
            }
            return new AddProductResponse { Id = product.Id, Success = true }; //Id tek imamo nakon spremanja u bazu
        }
    }
}
