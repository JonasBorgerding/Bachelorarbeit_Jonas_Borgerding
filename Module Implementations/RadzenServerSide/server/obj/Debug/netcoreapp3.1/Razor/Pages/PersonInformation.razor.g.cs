#pragma checksum "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec660fcc73502b988d36185d6914d1c4dc5f170"
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
#line 5 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
using Radzen.Blazor;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
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
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                 false

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                     true

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                         true

#line default
#line hidden
                ));
                __builder2.AddAttribute(14, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenServerSide.Pages.Person>>(
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                      PersonData

#line default
#line hidden
                ));
                __builder2.AddAttribute(15, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridEditMode>(
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                            DataGridEditMode.Single

#line default
#line hidden
                ));
                __builder2.AddAttribute(16, "ExpandMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                                                                                 DataGridExpandMode.Single

#line default
#line hidden
                ));
                __builder2.AddAttribute(17, "style", "height: calc(60vh - 75px)");
                __builder2.AddAttribute(18, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(20);
                    __builder3.AddAttribute(21, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 13 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(22, "Property", "Forename");
                    __builder3.AddAttribute(23, "Title", "Vorname");
                    __builder3.AddAttribute(24, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(26);
                    __builder3.AddAttribute(27, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 15 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(28, "Property", "Surname");
                    __builder3.AddAttribute(29, "Title", "Nachname");
                    __builder3.AddAttribute(30, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(32);
                    __builder3.AddAttribute(33, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(34, "Property", "CityCode");
                    __builder3.AddAttribute(35, "Title", "PLZ");
                    __builder3.AddAttribute(36, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(38);
                    __builder3.AddAttribute(39, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 19 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(40, "Property", "City");
                    __builder3.AddAttribute(41, "Title", "Stadt");
                    __builder3.AddAttribute(42, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Person>>(44);
                    __builder3.AddAttribute(45, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(46, "Property", "State");
                    __builder3.AddAttribute(47, "Title", "Bundesland");
                    __builder3.AddAttribute(48, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(50, (__value) => {
#line 11 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Person>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n      ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-3");
                __builder2.AddAttribute(55, "style", "text-align: right");
                __builder2.AddMarkupContent(56, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtml>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "\n");
#line 28 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
           foreach (var filter in Filters)
          {

#line default
#line hidden
                    __builder3.AddContent(60, "            ");
                    __builder3.OpenComponent<RadzenServerSide.Shared.DropdownInput>(61);
                    __builder3.AddAttribute(62, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 30 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                  filter.Title

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(63, "DropdownValues", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#line 30 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                 filter.DefaultValues

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 30 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                                     s => FilterValues[filter.QueryLabel] = s

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\n");
#line 31 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
          }

#line default
#line hidden
                    __builder3.AddContent(66, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(68);
                __builder2.AddAttribute(69, "style", "width: 100%");
                __builder2.AddAttribute(70, "Text", "Filter Anwenden");
                __builder2.AddAttribute(71, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 33 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                         Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row");
                __builder2.AddMarkupContent(77, "\n      ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-md-12");
                __builder2.AddMarkupContent(80, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Meeting>>(81);
                __builder2.AddAttribute(82, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RadzenServerSide.Pages.Meeting>>(
#line 39 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                        MeetingData

#line default
#line hidden
                ));
                __builder2.AddAttribute(83, "style", "height: calc(40vh - 75px); margin-top: 1vh");
                __builder2.AddAttribute(84, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Meeting>>(86);
                    __builder3.AddAttribute(87, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 41 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(88, "Property", "PersonInformation");
                    __builder3.AddAttribute(89, "Title", "Person");
                    __builder3.AddAttribute(90, "Width", "75%");
                    __builder3.AddAttribute(91, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<RadzenServerSide.Pages.Meeting>>(93);
                    __builder3.AddAttribute(94, "Format", "date-time");
                    __builder3.AddAttribute(95, "FormatString", "{0:d}");
                    __builder3.AddAttribute(96, "Property", "Date");
                    __builder3.AddAttribute(97, "Title", "Datum");
                    __builder3.AddAttribute(98, "Width", "25%");
                    __builder3.AddAttribute(99, "Type", "string");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(101, (__value) => {
#line 39 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Pages/PersonInformation.razor"
                          grid1 = (Radzen.Blazor.RadzenGrid<RadzenServerSide.Pages.Meeting>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
