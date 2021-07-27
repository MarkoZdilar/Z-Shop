using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        public List<Category> Categories { get; set; } = new List<Category> 
        {
            new Category { Id = 1, Name = "Action", Url = "action" },
            new Category { Id = 2, Name = "Adventure", Url = "adventure" },
            new Category { Id = 3, Name = "RPG", Url = "rpg" },
            new Category { Id = 4, Name = "Simulation", Url = "simulation" },
            new Category { Id = 5, Name = "Strategy", Url = "strategy" },
            new Category { Id = 6, Name = "Sports", Url = "sports" },
            new Category { Id = 7, Name = "Platform", Url = "platform" }
        };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
