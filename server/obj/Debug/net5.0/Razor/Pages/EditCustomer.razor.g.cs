#pragma checksum "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c97d7c558bbb1dec3dcf67d9feb29ab2e9088f"
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
#line 5 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using SimpleInvoiceManagementSoftware.Models.SimpleInvoice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using SimpleInvoiceManagementSoftware.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-customer/{CustomerId}")]
    public partial class EditCustomer : SimpleInvoiceManagementSoftware.Pages.EditCustomerComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Customer>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Customer>(
#nullable restore
#line 18 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                         customer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                                              customer != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Customer>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Customer>(this, 
#nullable restore
#line 18 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                                                                          Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Name");
                    __builder3.AddAttribute(19, "Component", "Name");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 26 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                          100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(27, "Name", "Name");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                  customer.Name

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Name = __value, customer.Name))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(32);
                    __builder3.AddAttribute(33, "Component", "Name");
                    __builder3.AddAttribute(34, "Text", "Name is required");
                    __builder3.AddAttribute(35, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(39, "class", "row");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(42);
                    __builder3.AddAttribute(43, "Text", "Description");
                    __builder3.AddAttribute(44, "Component", "Description");
                    __builder3.AddAttribute(45, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(49);
                    __builder3.AddAttribute(50, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 38 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                          200

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "style", "width: 100%");
                    __builder3.AddAttribute(52, "Name", "Description");
                    __builder3.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                  customer.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Description = __value, customer.Description))));
                    __builder3.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Description));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(59, "class", "row");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(62);
                    __builder3.AddAttribute(63, "Text", "Address");
                    __builder3.AddAttribute(64, "Component", "Address");
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n              ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(69);
                    __builder3.AddAttribute(70, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 48 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                          200

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(72, "Name", "Address");
                    __builder3.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                  customer.Address

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Address = __value, customer.Address))));
                    __builder3.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.Address));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(77);
                    __builder3.AddAttribute(78, "Component", "Address");
                    __builder3.AddAttribute(79, "Text", "Address is required");
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(84, "class", "row");
                    __builder3.OpenElement(85, "div");
                    __builder3.AddAttribute(86, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(87);
                    __builder3.AddAttribute(88, "Text", "City");
                    __builder3.AddAttribute(89, "Component", "City");
                    __builder3.AddAttribute(90, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(91, "\n              ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(94);
                    __builder3.AddAttribute(95, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 60 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                          100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(96, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(97, "Name", "City");
                    __builder3.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                  customer.City

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.City = __value, customer.City))));
                    __builder3.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => customer.City));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(102);
                    __builder3.AddAttribute(103, "Component", "City");
                    __builder3.AddAttribute(104, "Text", "City is required");
                    __builder3.AddAttribute(105, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\n            ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "row");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(111);
                    __builder3.AddAttribute(112, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 68 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "Icon", "save");
                    __builder3.AddAttribute(114, "Text", "Save");
                    __builder3.AddAttribute(115, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 68 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(117);
                    __builder3.AddAttribute(118, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 70 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(120, "Text", "Cancel");
                    __builder3.AddAttribute(121, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\EditCustomer.razor"
                                                                                                              Button2Click

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
