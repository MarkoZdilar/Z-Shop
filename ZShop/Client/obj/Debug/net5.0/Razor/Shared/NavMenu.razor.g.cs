#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab09de153c924a7c829eeb5172382840ceb9c424"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-lg navbar-dark bg-dark\" style=\"background-color: black;\" b-n4yjmrl9mx><div class=\"container-fluid\" b-n4yjmrl9mx><a class=\"navbar-brand\" href=\"#\" b-n4yjmrl9mx><h3 b-n4yjmrl9mx>Z-Shop</h3></a>\r\n        <div class=\"collapse navbar-collapse\" id=\"navbarNavAltMarkup\" b-n4yjmrl9mx><div class=\"navbar-nav\" b-n4yjmrl9mx><a class=\"nav-link active\" aria-current=\"page\" href b-n4yjmrl9mx>Home</a>\r\n                <a class=\"nav-link\" href=\"counter\" b-n4yjmrl9mx>Counter</a>\r\n                <a class=\"nav-link\" href=\"fetchdata\" b-n4yjmrl9mx>Fetch Data</a>\r\n                <a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDarkDropdownMenuLink\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\" b-n4yjmrl9mx>\r\n                    Dropdown\r\n                </a>\r\n                <ul class=\"dropdown-menu dropdown-menu-dark\" aria-labelledby=\"navbarDarkDropdownMenuLink\" b-n4yjmrl9mx><li b-n4yjmrl9mx><a class=\"dropdown-item\" href=\"#\" b-n4yjmrl9mx>Action</a></li>\r\n                    <li b-n4yjmrl9mx><a class=\"dropdown-item\" href=\"#\" b-n4yjmrl9mx>Another action</a></li>\r\n                    <li b-n4yjmrl9mx><a class=\"dropdown-item\" href=\"#\" b-n4yjmrl9mx>Something else here</a></li></ul>\r\n                <a class=\"nav-link disabled\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\" b-n4yjmrl9mx>Disabled</a></div></div>\r\n        \r\n\r\n        <form class=\"d-flex\" b-n4yjmrl9mx><input class=\"form-control me-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\" b-n4yjmrl9mx>\r\n            <button class=\"btn btn-outline-success\" type=\"submit\" b-n4yjmrl9mx>Search</button></form></div></nav>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
