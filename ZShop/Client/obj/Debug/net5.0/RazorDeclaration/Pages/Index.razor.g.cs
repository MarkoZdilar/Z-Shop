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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
