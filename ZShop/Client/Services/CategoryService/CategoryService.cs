﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category> {
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
            };
        }
    }
}
