// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\Adults.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Pages\Adults.razor"
       

    private IList<Adult> filterAdultList;
    private IList<Adult> AdultsToShow;
    private string? filterByFirstName;


    protected override async Task OnInitializedAsync()
    {
        filterAdultList = await _adultData.GetAdults();
        AdultsToShow = filterAdultList;
    }

    private async  void RemoveTodo(int adultId)
    {
        Adult adultToRemove = AdultsToShow.First(a => a.Id == adultId);
        await _adultData.RemoveAdults(adultId);
        navMan.NavigateTo("/Adults",true);
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
