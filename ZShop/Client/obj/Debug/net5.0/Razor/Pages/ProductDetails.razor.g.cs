#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f08de431c80f43a8884249fa018201dd8611fba3"
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
#line 7 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", 
#nullable restore
#line 7 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
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
            __builder.AddContent(15, 
#nullable restore
#line 10 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "p");
            __builder.AddContent(18, 
#nullable restore
#line 11 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
         if (product.Platforms != null && product.Platforms.Count > 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddAttribute(21, "style", "width: 20%; padding-bottom: 2.5%;");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
#nullable restore
#line 16 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                     foreach (var platform in product.Platforms)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "option");
            __builder.AddContent(25, 
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                 platform.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
         if (product.OriginalPrice > product.Price)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "h6");
            __builder.AddAttribute(27, "class", "text-muted original-price");
            __builder.AddContent(28, 
#nullable restore
#line 25 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
                                                   product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, " €");
            __builder.CloseElement();
#nullable restore
#line 26 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "h4");
            __builder.AddAttribute(31, "class", "price");
            __builder.AddContent(32, 
#nullable restore
#line 28 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
             product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, " €\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<button class=\"btn btn-primary\"><i class=\"oi oi-cart\">&nbsp;&nbsp;&nbsp;Add to cart</i></button>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
       
    private Product product = new Product();

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\ProductDetails.razor"
           

         product = await ProductService.GetProduct(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
