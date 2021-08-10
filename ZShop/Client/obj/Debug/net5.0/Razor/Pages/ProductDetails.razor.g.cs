#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c6af23f0512dc5915542938b4113d993066c4b"
// <auto-generated/>
#pragma warning disable 1591
namespace ZShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "media media-details");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "media-img-big-wrapper mr-2");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "class", "media-img-big");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 10 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", 
#nullable restore
#line 10 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "style", "max-height: 360px; min-height: 360px; max-width: 300px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "media-body");
            __builder.AddAttribute(12, "style", "padding-right:5%;");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "class", "mb-0");
            __builder.AddAttribute(15, "style", "text-align:center;");
            __builder.AddContent(16, 
#nullable restore
#line 13 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                     product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 14 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
         if (product.Variants != null && product.Variants.Count > 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddAttribute(22, "style", "width: 30%; padding-bottom: 2.5%;");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                    currentPlatformId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentPlatformId = __value, currentPlatformId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                     foreach (var variant in product.Variants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 21 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                        variant.PlatformId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, 
#nullable restore
#line 21 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                             variant.Platform.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant() != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
             if (GetSelectedVariant().OriginalPrice > GetSelectedVariant().Price)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "h6");
            __builder.AddAttribute(31, "class", "text-muted original-price");
            __builder.AddContent(32, 
#nullable restore
#line 30 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                       GetSelectedVariant().OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, " €");
            __builder.CloseElement();
#nullable restore
#line 31 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "h4");
            __builder.AddAttribute(35, "class", "price");
            __builder.AddContent(36, 
#nullable restore
#line 33 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                 GetSelectedVariant().Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, " €\r\n            ");
            __builder.CloseElement();
#nullable restore
#line 35 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                  AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "style", "width:40%; text-align:center;");
            __builder.AddMarkupContent(42, "<i class=\"oi oi-cart\">&nbsp;&nbsp;&nbsp;Add to cart</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
       
    private Product product = new Product();
    private int currentPlatformId = 1;

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProduct(Id);
        if(product.Variants.Count > 0)
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
        await CartService.AddToCart(GetSelectedVariant());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
