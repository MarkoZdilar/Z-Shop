#pragma checksum "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55bb75f24be3c53a0fe275829129de9303e42eee"
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
#nullable restore
#line 2 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
using ZShop.Shared.ProductModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\" b-c9uo29yhxd>Add new product</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                  newProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddAttribute(9, "b-c9uo29yhxd");
                __builder2.AddMarkupContent(10, "<label for=\"title\" b-c9uo29yhxd>Title</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Class", "form-control");
                __builder2.AddAttribute(13, "style", "width: 100%;");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                                                          newProduct.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.Title = __value, newProduct.Title))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newProduct.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __Blazor.ZShop.Client.Pages.Create.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 17 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                  () => newProduct.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddAttribute(23, "b-c9uo29yhxd");
                __builder2.AddMarkupContent(24, "<label for=\"Description\" b-c9uo29yhxd>Description</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(25);
                __builder2.AddAttribute(26, "Class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                                         newProduct.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.Description = __value, newProduct.Description))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newProduct.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __Blazor.ZShop.Client.Pages.Create.TypeInference.CreateValidationMessage_1(__builder2, 31, 32, 
#nullable restore
#line 22 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                  () => newProduct.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddAttribute(36, "b-c9uo29yhxd");
                __builder2.AddMarkupContent(37, "<label for=\"Image\" b-c9uo29yhxd>Image</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "Class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                                     newProduct.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.Image = __value, newProduct.Image))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newProduct.Image));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddAttribute(46, "b-c9uo29yhxd");
                __builder2.AddMarkupContent(47, "<label for=\"Category\" b-c9uo29yhxd>Category</label>\r\n        ");
                __builder2.OpenElement(48, "select");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                        newProduct.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newProduct.CategoryId = __value, newProduct.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(52, "b-c9uo29yhxd");
#nullable restore
#line 31 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
             foreach (var category in CategoryService.Categories)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "option");
                __builder2.AddAttribute(54, "value", 
#nullable restore
#line 33 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                category.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(55, "b-c9uo29yhxd");
                __builder2.AddContent(56, 
#nullable restore
#line 33 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                              category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 34 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n    ");
                __builder2.OpenComponent<ZShop.Client.Pages.VariantOptions>(58);
                __builder2.AddAttribute(59, "ProductVariants", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ZShop.Shared.ProductVariant>>(
#nullable restore
#line 38 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
                                      newProduct.Variants

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.AddMarkupContent(61, "<button type=\"submit\" class=\"btn btn-success\" b-c9uo29yhxd>Create</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\Create.razor"
       
    private ProductAddModel newProduct = new ProductAddModel();

    private async Task HandleValidSubmit()
    {
        newProduct.Variants = VariantService.GetSelectedVariants();
        var response = await ProductService.AddProduct(newProduct);
        if (response.Success)
        {
            NavigationManager.NavigateTo($"/product/{response.Id}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVariantService VariantService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
namespace __Blazor.ZShop.Client.Pages.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
