#pragma checksum "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76124596a3f04c5295f3ae2e140d99480940543f"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_Assignment.Shared
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
#line 2 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Shared\MainLayout.razor"
using DNP_Assignment.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-7dyduod6fi");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-7dyduod6fi");
            __builder.OpenComponent<DNP_Assignment.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    \n    ");
            __builder.AddMarkupContent(8, "<style b-7dyduod6fi>\n        body {\n            background-image:url( https://i.natgeofe.com/n/9135ca87-0115-4a22-8caf-d1bdef97a814/75552_square.jpg);}\n         \n    </style>\n\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-7dyduod6fi");
            __builder.AddMarkupContent(12, "<div class=\"top-row px-4\" b-7dyduod6fi><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-7dyduod6fi>About</a></div>\n\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-7dyduod6fi");
            __builder.AddContent(16, 
#nullable restore
#line 22 "C:\Users\amara\RiderProjects\DNP_Assignment_1\DNP Assignment\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
