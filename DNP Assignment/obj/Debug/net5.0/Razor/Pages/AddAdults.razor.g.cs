#pragma checksum "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf4200bd3c0e8b91b9e6c4d072bbcc181085b739"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using DNP_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\_Imports.razor"
using DNP_Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
using DNP_Assignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Adults</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                                            AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddContent(6, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, " FirstName:<br> \n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                                newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n    \n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, " LastName:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                                                                     newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, " JobTitle:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                                                                    job.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => job.JobTitle = __value, job.JobTitle))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => job.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, " \n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, " Salary:<br> ");
                __Blazor.DNP_Assignment.Pages.AddAdults.TypeInference.CreateInputNumber_0(__builder2, 36, 37, 
#nullable restore
#line 19 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
                                                                    job.Salary

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => job.Salary = __value, job.Salary)), 39, () => job.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "   \n    \n    ");
                __builder2.AddMarkupContent(41, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\AddAdults.razor"
       
    
    private Adult newAdult = new Adult();
    private Job job = new Job();

    private async void AddNewAdult()
    {
        newAdult.JobTitle = job;
       await _adultData.AddAdults(newAdult);
        NavigationManager.NavigateTo("/Adults");
    }
    
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData _adultData { get; set; }
    }
}
namespace __Blazor.DNP_Assignment.Pages.AddAdults
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
