using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ZShop.Client.Helper;
using ZShop.Client.Services;
using ZShop.Client.Services.CartService;
using ZShop.Client.Services.CategoryService;
using ZShop.Client.Services.PlatformService;
using ZShop.Client.Services.ProductService;
using ZShop.Client.Services.StatsService;

namespace ZShop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IStatsService, StatsService>();
            builder.Services.AddScoped<IPlatformService, PlatformService>();
            builder.Services.AddScoped<EditProductState>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthService>();

            await builder.Build()
                .RunAsync();
        }
    }
}
