#pragma checksum "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ec3e090c28dbe8a98dcaacf94de55d80457d52"
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
#line 1 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.PlatformService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using ZShop.Client.Services.VariantService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Projects\Z-Shop\ZShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"Register-title\" b-80p76civdn>Register</h1>");
#nullable restore
#line 7 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
 if (ShowErrors)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
            __builder.AddAttribute(3, "role", "alert");
            __builder.AddAttribute(4, "b-80p76civdn");
#nullable restore
#line 10 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
         foreach (var error in Errors)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "b-80p76civdn");
            __builder.AddContent(7, 
#nullable restore
#line 12 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddAttribute(10, "b-80p76civdn");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddAttribute(13, "b-80p76civdn");
            __builder.AddMarkupContent(14, "<h5 class=\"card-title\" b-80p76civdn>Please enter your details</h5>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                         RegisterModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                                       HandleRegistration

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddAttribute(25, "b-80p76civdn");
                __builder2.AddMarkupContent(26, "<label for=\"email\" b-80p76civdn>Email address</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "Id", "email");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                                                        RegisterModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.Email = __value, RegisterModel.Email))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __Blazor.ZShop.Client.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 34, 35, 
#nullable restore
#line 27 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                          () => RegisterModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddAttribute(39, "b-80p76civdn");
                __builder2.AddMarkupContent(40, "<label for=\"password\" b-80p76civdn>Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "Id", "password");
                __builder2.AddAttribute(43, "type", "password");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                                                                           RegisterModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.Password = __value, RegisterModel.Password))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                ");
                __Blazor.ZShop.Client.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 49, 50, 
#nullable restore
#line 32 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                          () => RegisterModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddAttribute(54, "b-80p76civdn");
                __builder2.AddMarkupContent(55, "<label for=\"password\" b-80p76civdn>Confirm Password</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "Id", "password");
                __builder2.AddAttribute(58, "type", "password");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                                                                           RegisterModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RegisterModel.ConfirmPassword = __value, RegisterModel.ConfirmPassword))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => RegisterModel.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __Blazor.ZShop.Client.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 64, 65, 
#nullable restore
#line 37 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
                                          () => RegisterModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.AddMarkupContent(67, "<button type=\"submit\" class=\"btn btn-success\" b-80p76civdn>Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\Z-Shop\ZShop\Client\Pages\Register.razor"
       

    private RegisterModel RegisterModel = new RegisterModel();
    private bool ShowErrors;
    private IEnumerable<string> Errors;

    private async Task HandleRegistration()
    {
        ShowErrors = false;

        var result = await AuthService.Register(RegisterModel);

        if (result.Successful)
        {
            await AuthService.Login(new LoginModel { Email = RegisterModel.Email, Password = RegisterModel.Password });
            NavigationManager.NavigateTo("/", true);
        }
        else
        {
            Errors = result.Errors;
            ShowErrors = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.AuthService AuthService { get; set; }
    }
}
namespace __Blazor.ZShop.Client.Pages.Register
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
