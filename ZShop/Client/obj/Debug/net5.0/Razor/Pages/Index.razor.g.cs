#pragma checksum "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1747d9dd5149eae1e48ba57f4a86e86b9d630293"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
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
#line 13 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
                                                                         category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " Games");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenComponent<ZShop.Client.Shared.ProductList>(6);
            __builder.CloseComponent();
#nullable restore
#line 15 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(7);
            __builder.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "<br>\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(10, "<h2 style=\"text-align: center; color: #28A745; font-weight: bold; \">Welcome to Z-Shop!</h2>");
            }
            ));
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "<br>\r\n            <br>\r\n            ");
                __builder2.OpenElement(13, "h2");
                __builder2.AddAttribute(14, "style", "text-align: center; color: #28A745; font-weight: bold; ");
                __builder2.AddContent(15, "Welcome back, ");
                __builder2.AddContent(16, 
#nullable restore
#line 27 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
                                                                                               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(17, "!");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenComponent<ZShop.Client.Shared.ProductList>(19);
            __builder.CloseComponent();
#nullable restore
#line 31 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\ProgramiranjeUCSharpu\Seminar_25_08\CSharpSeminar\ZShop\Client\Pages\Index.razor"
 
    [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override async Task OnParametersSetAsync()
    {
        await ProductService.LoadProducts(CategoryUrl);

        if (CategoryUrl != null)
        {
            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }
        else
        {
            category = null;
        }

        await StatsService.IncrementVisits();
        await StatsService.GetVisits();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatsService StatsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
