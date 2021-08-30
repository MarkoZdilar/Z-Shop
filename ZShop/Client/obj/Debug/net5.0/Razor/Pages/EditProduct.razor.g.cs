#pragma checksum "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccfdf65779ede28cf715ec55e6c97c3adcf03a10"
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
#line 6 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
using ZShop.Shared.ProductModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit/{id:int}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
 if (productEditModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p b-17arwery9m><em b-17arwery9m>Loading...</em></p>");
#nullable restore
#line 14 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "b-17arwery9m");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddAttribute(6, "b-17arwery9m");
            __builder.OpenElement(7, "h5");
            __builder.AddAttribute(8, "class", "card-title");
            __builder.AddAttribute(9, "b-17arwery9m");
            __builder.AddContent(10, "Editing - ");
            __builder.AddContent(11, 
#nullable restore
#line 19 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                              productEditModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddAttribute(21, "b-17arwery9m");
                __builder2.AddMarkupContent(22, "<label for=\"title\" b-17arwery9m>Title</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "style", "width: 100%;");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                                 productEditModel.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productEditModel.Title = __value, productEditModel.Title))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productEditModel.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __Blazor.ZShop.Client.Pages.EditProduct.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 26 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                              () => productEditModel.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddAttribute(34, "b-17arwery9m");
                __builder2.AddMarkupContent(35, "<label for=\"Description\" b-17arwery9m>Description</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(36);
                __builder2.AddAttribute(37, "Class", "form-control");
                __builder2.AddAttribute(38, "rows", "7");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                                     productEditModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productEditModel.Description = __value, productEditModel.Description))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productEditModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __Blazor.ZShop.Client.Pages.EditProduct.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 31 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                              () => productEditModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddAttribute(48, "b-17arwery9m");
                __builder2.AddMarkupContent(49, "<label for=\"Image\" b-17arwery9m>Image</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "Class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                                 productEditModel.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productEditModel.Image = __value, productEditModel.Image))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productEditModel.Image));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddAttribute(58, "b-17arwery9m");
                __builder2.AddMarkupContent(59, "<label for=\"Category\" b-17arwery9m>Category</label>\r\n                    ");
                __builder2.OpenElement(60, "select");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                    productEditModel.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productEditModel.CategoryId = __value, productEditModel.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(64, "b-17arwery9m");
#nullable restore
#line 40 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                         foreach (var category in CategoryService.Categories)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", 
#nullable restore
#line 42 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                            category.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(67, "b-17arwery9m");
                __builder2.AddContent(68, 
#nullable restore
#line 42 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                          category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 43 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                <hr b-17arwery9m>\r\n                ");
                __builder2.OpenComponent<ZShop.Client.Pages.VariantOptions>(70);
                __builder2.AddAttribute(71, "ProductVariants", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<ZShop.Shared.ProductVariant>>(
#nullable restore
#line 47 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
                                                  productEditModel.Variants

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n\r\n\r\n                ");
                __builder2.AddMarkupContent(73, "<button type=\"submit\" class=\"btn btn-success\" b-17arwery9m>Save</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\Z-Shop\Z-Shop23\ZShop\Client\Pages\EditProduct.razor"
       
    [Parameter]
    public int Id { get; set; }
    private Product product = new Product();
    private ProductEditModel productEditModel;

    protected override async Task OnParametersSetAsync()
    {
        product = await ProductService.GetProduct(Id);

        productEditModel = new ProductEditModel
        {
            Title = product.Title,
            Description = product.Description,
            Category = product.Category,
            CategoryId = product.CategoryId,
            Id = product.Id,
            Variants = product.Variants,
            Image = product.Image
        };
    }

    private async Task HandleValidSubmit()
    {
        productEditModel.Variants = VariantService.GetSelectedVariants();
        var response = await ProductService.EditProduct(productEditModel);
        if (response.Success)
        {
            NavigationManager.NavigateTo($"/product/{Id}");
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
namespace __Blazor.ZShop.Client.Pages.EditProduct
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
