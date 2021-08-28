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
#line 1 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.PlatformService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.VariantService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Z-Shop\Z-Shop23\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Cart.razor"
       
    List<CartItem> cartItems = new List<CartItem>();
    bool orderPlaced = false;

    protected override async Task OnInitializedAsync()
    {
        cartItems = await CartService.GetCartItems();
    }

    private async Task DeleteItem(CartItem item)
    {
        await CartService.DeleteItem(item);
        cartItems = await CartService.GetCartItems();
    }

    private async Task PlaceOrder() //async because we want to empty the cart which means call the cartService
    {
        orderPlaced = true;
        await CartService.EmptyCart();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
    }
}
#pragma warning restore 1591
