#pragma checksum "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aaebe5ed1e80d356a529fd92b3453abdc3fc34c"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleInvoiceManagementSoftware.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\_Imports.razor"
using SimpleInvoiceManagementSoftware.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using SimpleInvoiceManagementSoftware.Models.SimpleInvoice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using SimpleInvoiceManagementSoftware.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : SimpleInvoiceManagementSoftware.Pages.ProfileComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Change Password");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(11);
                __builder2.AddAttribute(12, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 20 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                    user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                              user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 20 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                                      Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(21);
                    __builder3.AddAttribute(22, "Component", "UserName");
                    __builder3.AddAttribute(23, "Text", "UserName");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\n              ");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(27);
                    __builder3.AddAttribute(28, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "style", "width: 100%");
                    __builder3.AddAttribute(30, "Name", "UserName");
                    __builder3.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                  Security.User.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Security.User.UserName = __value, Security.User.UserName))));
                    __builder3.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Security.User.UserName));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(37, "class", "row");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(40);
                    __builder3.AddAttribute(41, "Component", "OldPassword");
                    __builder3.AddAttribute(42, "style", "width: 100%");
                    __builder3.AddAttribute(43, "Text", "Old Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(47);
                    __builder3.AddAttribute(48, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(49, "Name", "OldPassword");
                    __builder3.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                  OldPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OldPassword = __value, OldPassword))));
                    __builder3.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => OldPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(54);
                    __builder3.AddAttribute(55, "Component", "OldPassword");
                    __builder3.AddAttribute(56, "style", "position: absolute");
                    __builder3.AddAttribute(57, "Text", "Old Password is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n            ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(61, "class", "row");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(64);
                    __builder3.AddAttribute(65, "Component", "NewPassword");
                    __builder3.AddAttribute(66, "style", "width: 100%");
                    __builder3.AddAttribute(67, "Text", "New Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\n              ");
                    __builder3.OpenElement(69, "div");
                    __builder3.AddAttribute(70, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(71);
                    __builder3.AddAttribute(72, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(73, "Name", "NewPassword");
                    __builder3.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                  NewPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewPassword = __value, NewPassword))));
                    __builder3.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(78);
                    __builder3.AddAttribute(79, "Component", "NewPassword");
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.AddAttribute(81, "Text", "Password is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n            ");
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(85, "class", "row");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(88);
                    __builder3.AddAttribute(89, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.AddAttribute(91, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n              ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(95);
                    __builder3.AddAttribute(96, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(97, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                  ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ConfirmPassword = __value, ConfirmPassword))));
                    __builder3.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(102);
                    __builder3.AddAttribute(103, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(104, "style", "position: absolute");
                    __builder3.AddAttribute(105, "Text", "ConfirmPassword is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    __builder3.AddAttribute(112, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 70 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 70 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                                           Security.User.UserName == "administrator"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(115, "Icon", "save");
                    __builder3.AddAttribute(116, "Text", "Change password");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(117, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(118);
                    __builder3.AddAttribute(119, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(120, "Text", "Cancel");
                    __builder3.AddAttribute(121, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Profile.razor"
                                                                                    BtnCancelClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
