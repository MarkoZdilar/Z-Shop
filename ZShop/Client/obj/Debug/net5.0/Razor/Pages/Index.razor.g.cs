#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd6c6cf13b442c424c212c96bfa6cd31ed3f2aca"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<br>\r\n    <br>\r\n    ");
            __builder.OpenElement(1, "h2");
            __builder.AddAttribute(2, "style", "text-align: center; color: #28A745; font-weight: bold; ");
            __builder.AddContent(3, 
#nullable restore
#line 10 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
                                                                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " Games");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<ZShop.Client.Shared.ProductList>(6);
            __builder.AddAttribute(7, "CategoryId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 11 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
                              category.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(9, "<h2 style=\"text-align: center; color: #28A745; font-weight: bold; \">Welcome to Z-Shop!</h2>\r\n    ");
            __builder.OpenComponent<ZShop.Client.Shared.ProductList>(10);
            __builder.CloseComponent();
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\CSharpSeminarski\ZShop\ZShop\Client\Pages\Index.razor"
 
    [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override void OnParametersSet()
    {
        if (CategoryUrl != null)
        {
            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }
        else
        {
            category = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
