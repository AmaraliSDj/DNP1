#pragma checksum "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9a6007d916a474fec8bcaf04604b53ff73ec12"
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
#line 1 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using DNP_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\_Imports.razor"
using DNP_Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
using DNP_Assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\n\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Search ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "Text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                                          (arg) => FilterByFirstname(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
 if (AdultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
}
else if (!AdultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 23 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>ID</th>\n            <th>FirstName</th>\n            <th>LastName</th>\n            <th>JobTitle</th>\n            <th>Salary</th></tr></thead>\n\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 39 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
         foreach (var item in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 42 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 43 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 45 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 46 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                     item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(28);
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "td");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
                                            () => RemoveTodo(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(33, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\amara\OneDrive\Desktop\DNP_Assignment_1-master\DNP Assignment\Pages\Adults.razor"
       

    private IList<Adult> filterAdultList;
    private IList<Adult> AdultsToShow;
    private string? filterByFirstName;


    protected override async Task OnInitializedAsync()
    {
        filterAdultList = _adultData.GetAdults();
        AdultsToShow = filterAdultList;
    }

    private void RemoveTodo(int adultId)
    {
        Adult adultToRemove = AdultsToShow.First(a => a.Id == adultId);
        _adultData.RemoveAdults(adultId);
    }


    private void FilterByFirstname(ChangeEventArgs changeEventArgs)
    {
        filterByFirstName = changeEventArgs.Value.ToString();

        if (filterByFirstName.Length <= 0)
        {
            AdultsToShow = filterAdultList;
        }
        else
        {
            AdultsToShow = AdultsToShow.Where(
                a => a.FirstName.ToLower().Contains(filterByFirstName.ToLower()) || a.FirstName.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                     a.LastName.ToLower().Contains(filterByFirstName.ToLower()) || a.LastName.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                     a.JobTitle.JobTitle.ToLower().Contains(filterByFirstName.ToLower()) || a.JobTitle.JobTitle.ToUpper().Contains(filterByFirstName.ToUpper()) ||
                     a.JobTitle.Salary.ToString().ToLower().Contains(filterByFirstName.ToLower()) || a.Id.ToString().ToLower().Contains(filterByFirstName.ToLower())).ToList();
        }
    }







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData _adultData { get; set; }
    }
}
#pragma warning restore 1591