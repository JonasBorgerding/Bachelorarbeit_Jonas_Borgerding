#pragma checksum "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd47a95eabbc4479d66a9c2671a446eb58a803eb"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenServerSide.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/_Imports.razor"
using RadzenServerSide.Shared;

#line default
#line hidden
#line 6 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
using Radzen;

#line default
#line hidden
#line 7 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
using Radzen.Blazor;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/person-information")]
    public partial class PersonInformation : RadzenServerSide.Pages.PersonInformationComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-9");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Person>>(10);
                __builder2.AddAttribute(11, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                 false

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenServerSide.Pages.Person>>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                      PersonData

#line default
#line hidden
                ));
                __builder2.AddAttribute(15, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridEditMode>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                            DataGridEditMode.Single

#line default
#line hidden
                ));
                __builder2.AddAttribute(16, "ExpandMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                                                                 DataGridExpandMode.Single

#line default
#line hidden
                ));
                __builder2.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                                                                                                                                            100

#line default
#line hidden
                ));
                __builder2.AddAttribute(18, "style", "height: calc(60vh - 75px)");
                __builder2.AddAttribute(19, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<RadzenServerSide.Pages.Person>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<RadzenServerSide.Pages.Person>(this, 
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                                                                                                                                                                                               Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(20, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(22);
                    __builder3.AddAttribute(23, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 14 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(24, "Property", "Forename");
                    __builder3.AddAttribute(25, "Title", "Vorname");
                    __builder3.AddAttribute(26, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(28);
                    __builder3.AddAttribute(29, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 16 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(30, "Property", "Surname");
                    __builder3.AddAttribute(31, "Title", "Nachname");
                    __builder3.AddAttribute(32, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(34);
                    __builder3.AddAttribute(35, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 18 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(36, "Property", "CityCode");
                    __builder3.AddAttribute(37, "Title", "PLZ");
                    __builder3.AddAttribute(38, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(40);
                    __builder3.AddAttribute(41, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 20 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(42, "Property", "City");
                    __builder3.AddAttribute(43, "Title", "Stadt");
                    __builder3.AddAttribute(44, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(46);
                    __builder3.AddAttribute(47, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(48, "Property", "State");
                    __builder3.AddAttribute(49, "Title", "Bundesland");
                    __builder3.AddAttribute(50, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(52, (__value) => {
#line 12 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Person>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n      ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-3");
                __builder2.AddAttribute(57, "style", "text-align: right");
                __builder2.AddMarkupContent(58, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtml>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "\n");
#line 29 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
           foreach (var filter in Filters)
          {

#line default
#line hidden
                    __builder3.AddContent(62, "            ");
                    __builder3.OpenComponent<RadzenServerSide.Shared.DropdownInput>(63);
                    __builder3.AddAttribute(64, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 31 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                  filter.Title

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(65, "DropdownValues", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#line 31 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                 filter.DefaultValues

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 31 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                     s => FilterValues[filter.QueryLabel] = s

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\n");
#line 32 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
          }

#line default
#line hidden
                    __builder3.AddContent(68, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(70);
                __builder2.AddAttribute(71, "style", "width: 100%");
                __builder2.AddAttribute(72, "Text", "Filter Anwenden");
                __builder2.AddAttribute(73, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 34 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                         Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "row");
                __builder2.AddMarkupContent(79, "\n      ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-md-12");
                __builder2.AddMarkupContent(82, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Meeting>>(83);
                __builder2.AddAttribute(84, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 40 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                              true

#line default
#line hidden
                ));
                __builder2.AddAttribute(85, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 40 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                  true

#line default
#line hidden
                ));
                __builder2.AddAttribute(86, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenServerSide.Pages.Meeting>>(
#line 40 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                               MeetingData

#line default
#line hidden
                ));
                __builder2.AddAttribute(87, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 40 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                                             100

#line default
#line hidden
                ));
                __builder2.AddAttribute(88, "style", "height: calc(40vh - 75px); margin-top: 1vh");
                __builder2.AddAttribute(89, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(90, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Meeting>>(91);
                    __builder3.AddAttribute(92, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 42 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(93, "Property", "PersonInformation");
                    __builder3.AddAttribute(94, "Title", "Personen Information");
                    __builder3.AddAttribute(95, "Width", "75%");
                    __builder3.AddAttribute(96, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Meeting>>(98);
                    __builder3.AddAttribute(99, "Format", "date-time");
                    __builder3.AddAttribute(100, "FormatString", "{0:d}");
                    __builder3.AddAttribute(101, "Property", "Date");
                    __builder3.AddAttribute(102, "Title", "Datum");
                    __builder3.AddAttribute(103, "Width", "25%");
                    __builder3.AddAttribute(104, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(106, (__value) => {
#line 40 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                          grid1 = (Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Meeting>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(107, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
