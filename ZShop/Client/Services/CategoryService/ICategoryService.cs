using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZShop.Shared;

namespace ZShop.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
