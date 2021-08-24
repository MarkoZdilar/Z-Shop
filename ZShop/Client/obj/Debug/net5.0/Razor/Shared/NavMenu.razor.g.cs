#pragma checksum "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b036f7551f6da5739905ee1f7fb72c0058de6206"
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
#nullable restore
#line 14 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CSharpSeminarski\ZShop\ZShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar fixed-top navbar-expand-lg navbar-dark bg-dark");
            __builder.AddAttribute(2, "b-n4yjmrl9mx");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-n4yjmrl9mx");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href=\"#\" b-n4yjmrl9mx><h2 b-n4yjmrl9mx>Z-Shop</h2></a>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "collapse navbar-collapse");
            __builder.AddAttribute(9, "id", "navbarNavAltMarkup");
            __builder.AddAttribute(10, "b-n4yjmrl9mx");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "navbar-nav");
            __builder.AddAttribute(13, "b-n4yjmrl9mx");
            __builder.AddMarkupContent(14, "<a class=\"nav-link\" id=\"navigation-link\" aria-current=\"page\" href b-n4yjmrl9mx>Home</a>");
#nullable restore
#line 16 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                 foreach (var category in CategoryService.Categories)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "nav-link navigation");
            __builder.AddAttribute(17, "id", "navigation-link");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                                                               category.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "b-n4yjmrl9mx");
            __builder.AddContent(20, 
#nullable restore
#line 18 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                                                                              category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "style", "width: 10%; background-color: white;");
            __builder.AddAttribute(24, "b-n4yjmrl9mx");
            __builder.OpenComponent<Blazored.Typeahead.BlazoredTypeahead<Product, Product>>(25);
            __builder.AddAttribute(26, "SearchMethod", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Product>>>(
#nullable restore
#line 23 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                              SearchProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Product>(
#nullable restore
#line 26 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                      selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Product>(this, 
#nullable restore
#line 27 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                             HandleSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Product>>>(
#nullable restore
#line 28 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                                  () => selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "placeholder", "Search..");
            __builder.AddAttribute(31, "SelectedTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Product>)((context) => (__builder2) => {
                __builder2.AddContent(32, 
#nullable restore
#line 31 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                     context.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(33, "ResultTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Product>)((context) => (__builder2) => {
                __builder2.AddContent(34, 
#nullable restore
#line 34 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                     context.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(35, "NotFoundTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.String>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                    Soryy, there weren\'t any products found.\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "cart-button");
            __builder.AddAttribute(40, "style", "padding-left: 2%; ");
            __builder.AddAttribute(41, "b-n4yjmrl9mx");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", "cart");
            __builder.AddAttribute(44, "class", "btn btn-light");
            __builder.AddAttribute(45, "b-n4yjmrl9mx");
            __builder.AddMarkupContent(46, "<i class=\"oi oi-cart\" b-n4yjmrl9mx></i>\r\n                Cart\r\n                ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "badge badge-pill badge-success");
            __builder.AddAttribute(49, "b-n4yjmrl9mx");
            __builder.AddContent(50, 
#nullable restore
#line 45 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                                              GetProductCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(52);
            __builder.AddAttribute(53, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link");
                __builder2.AddAttribute(56, "href", "login");
                __builder2.AddAttribute(57, "id", "login-link");
                __builder2.AddAttribute(58, "style", "color: #28A745;");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-n4yjmrl9mx></span>Login\r\n                ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(61, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(62);
                __builder2.AddAttribute(63, "class", "nav-link");
                __builder2.AddAttribute(64, "href", "create");
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "<span class=\" oi oi-plus\" aria-hidden=\"true\" b-n4yjmrl9mx></span>Create\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "class", "nav-link");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
                                              Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "style", "cursor: pointer");
                __builder2.AddAttribute(72, "b-n4yjmrl9mx");
                __builder2.AddMarkupContent(73, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-n4yjmrl9mx></span>Logout\r\n                ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\CSharpSeminarski\ZShop\ZShop\Client\Shared\NavMenu.razor"
             
    private Product selectedProduct;
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged; //StateHasChanged will be called when OnChange event is invoked(raised)
    }

    public void Dispose()//we need to implement this function because we implement IDisposable interface 
    {
        CartService.OnChange -= StateHasChanged;
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        await CategoryService.LoadCategories();
    }

    private int GetProductCount()
    {
        var cart = LocalStorage.GetItem<List<ProductVariant>>("cart");
        return cart != null ? cart.Count : 0;
    }

    private void Logout()
    {
        LocalStorage.RemoveItem("username");
        AuthStateProvider.GetAuthenticationStateAsync(); //Just to refresh and get current auth state.
    }

    private void HandleSearch(Product product)
    {
        if (product == null) return;
        selectedProduct = product;
        NavigationManager.NavigateTo($"product/{selectedProduct.Id}");
    }

    private async Task<IEnumerable<Product>> SearchProduct(string searchText)
    {
        var response = await ProductService.SearchProducts(searchText);
        return response;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
