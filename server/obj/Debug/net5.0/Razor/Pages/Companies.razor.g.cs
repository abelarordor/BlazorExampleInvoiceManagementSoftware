#pragma checksum "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9602eac9d762f5fcc0d610d64fda136372243b9"
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
#line 6 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using SimpleInvoiceManagementSoftware.Models.SimpleInvoice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using SimpleInvoiceManagementSoftware.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
           [Authorize(Roles="Authenticated, Invoicing")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies")]
    public partial class Companies : SimpleInvoiceManagementSoftware.Pages.CompaniesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Companies");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-bottom: 10px; margin-left: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 23 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await Load();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                     getCompaniesResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                     FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>(this, 
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(44, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(45);
                    __builder3.AddAttribute(46, "Property", "CompanyId");
                    __builder3.AddAttribute(47, "Title", "Company Id");
                    __builder3.AddAttribute(48, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(50);
                    __builder3.AddAttribute(51, "Property", "Name");
                    __builder3.AddAttribute(52, "Title", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(54);
                    __builder3.AddAttribute(55, "Property", "Description");
                    __builder3.AddAttribute(56, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(58);
                    __builder3.AddAttribute(59, "Property", "Address");
                    __builder3.AddAttribute(60, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(62);
                    __builder3.AddAttribute(63, "Property", "City");
                    __builder3.AddAttribute(64, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>>(66);
                    __builder3.AddAttribute(67, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 45 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Width", "70px");
                    __builder3.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>)((simpleInvoiceManagementSoftwareModelsSimpleInvoiceCompany) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(72);
                        __builder4.AddAttribute(73, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 47 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Icon", "close");
                        __builder4.AddAttribute(75, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 47 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                               simpleInvoiceManagementSoftwareModelsSimpleInvoiceCompany.CompanyId != 1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                                                                                   (args) =>GridDeleteButtonClick(args, simpleInvoiceManagementSoftwareModelsSimpleInvoiceCompany)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(78, "onclick", 
#nullable restore
#line 47 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                                                                                                                                                                                                                                                                                                                               true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(79, (__value) => {
#nullable restore
#line 33 "C:\_blazor\product\BlazorExampleGithubInvoiceManagement\server\Pages\Companies.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<SimpleInvoiceManagementSoftware.Models.SimpleInvoice.Company>)__value;

#line default
#line hidden
#nullable disable
                }
                );
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
