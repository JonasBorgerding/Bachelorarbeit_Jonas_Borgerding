#pragma checksum "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67aeb514bd2a38abd1d448a3f81053f3272cb229"
// <auto-generated/>
#pragma warning disable 1591
namespace RadzenServerSide.Shared
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
#line 3 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 4 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
using Radzen;

#line default
#line hidden
    public partial class DropdownInput : RadzenServerSide.Shared.DropdownInputComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width: 100%; position: relative; height: 65px;");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(3);
            __builder.AddAttribute(4, "style", "font-weight: bold; height: 24px; text-align: left; width: 100%; position: absolute; top: 0; left: 0;");
            __builder.AddAttribute(5, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 7 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
                                                                                                                                     Text

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n    ");
            __Blazor.RadzenServerSide.Shared.DropdownInput.TypeInference.CreateRadzenDropDown_0(__builder, 7, 8, 
#line 8 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
                           DropdownValues

#line default
#line hidden
            , 9, "position: absolute; top: 24px; left: 0; width: 100%; text-align: left;", 10, "Dropdown0", 11, 
#line 8 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
                                                         Value

#line default
#line hidden
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Value = __value, Value)), 13, () => Value);
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(15);
            __builder.AddAttribute(16, "style", "left: 0; position: absolute; top: 24px; width: calc(100% - 30px);");
            __builder.AddAttribute(17, "Name", "Textbox0");
            __builder.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 9 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
                                                                                                                             s => Value = s

#line default
#line hidden
            )));
            __builder.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 9 "/home/jonas/Desktop/Bachelorarbeit_Jonas_Borgerding/Module Implementations/RadzenServerSide/server/Shared/DropdownInput.razor"
                                                                                                                                                      Value

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RadzenServerSide.Shared.DropdownInput
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591