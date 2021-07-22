#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd4816172ac7d4249443e4ac981cf8e0e0baa69"
// <auto-generated/>
#pragma warning disable 1591
namespace ZShop.Client.Shared
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
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-unstyled");
#nullable restore
#line 4 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
     foreach(var product in ProductService.Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "media my-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media-img-wrapper mr-2");
            __builder.AddAttribute(6, "style", " margin-left: 2%;");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "href", "/product/" + (
#nullable restore
#line 8 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "media-img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 9 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                                 product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "alt", 
#nullable restore
#line 9 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "media-body");
            __builder.AddAttribute(16, "style", "padding-right:5%;");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/product/" + (
#nullable restore
#line 13 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "h4");
            __builder.AddAttribute(20, "class", "mb-0");
            __builder.AddContent(21, 
#nullable restore
#line 14 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                      product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, 
#nullable restore
#line 16 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                    product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                 if(product.OriginalPrice > product.Price)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "h6");
            __builder.AddAttribute(26, "class", "text-muted original-price");
            __builder.AddContent(27, 
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                                                           product.OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " €");
            __builder.CloseElement();
#nullable restore
#line 20 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "h5");
            __builder.AddAttribute(30, "class", "price");
            __builder.AddContent(31, 
#nullable restore
#line 22 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, " €\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        <hr>");
#nullable restore
#line 27 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\ProductList.razor"
        
    protected override void OnInitialized()
    {
        ProductService.LoadProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
