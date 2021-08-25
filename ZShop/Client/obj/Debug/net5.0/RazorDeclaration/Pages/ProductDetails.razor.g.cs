// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.PlatformService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\ProductDetails.razor"
using ZShop.Shared.ProductModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\ProductDetails.razor"
       
    private Product product = new Product();
    private int currentPlatformId = 1;

    private CartItem cartItem = new CartItem { Quantity = 1 };

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        product = await ProductService.GetProduct(Id);
        if (product.Variants.Count > 0)
        {
            currentPlatformId = product.Variants[0].PlatformId; //If there is any platform for selected product, take first as current
        }
    }

    private ProductVariant GetSelectedVariant()
    {
        var variant = product.Variants.FirstOrDefault(v => v.PlatformId == currentPlatformId);
        return variant;
    }

    private async Task AddToCart()
    {
        var productVariant = GetSelectedVariant();

        cartItem.PlatformId = productVariant.PlatformId;
        cartItem.PlatformName = productVariant.Platform.Name;
        cartItem.Image = product.Image;
        cartItem.Price = productVariant.Price;
        cartItem.ProductId = productVariant.ProductId;
        cartItem.ProductTitle = product.Title;

        await CartService.AddToCart(cartItem);
    }

    private async Task DeleteProduct()
    {
        var result = await ProductService.DeleteProduct(new DeleteProductRequest { Id = Id });
        if (result.Success)
        {
            NavigationManager.NavigateTo("/");
        }
        else
        {
            Console.WriteLine("Error deleting");
        }
    }

    private void EditProduct()
    {
        NavigationManager.NavigateTo($"/Edit/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
