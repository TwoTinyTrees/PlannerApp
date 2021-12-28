#pragma checksum "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0060639aa6f70a14d5b48002ecd9f8cfa50e8d22"
// <auto-generated/>
#pragma warning disable 1591
namespace Planner.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Planner.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Planner.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using Planner.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<Planner.App.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudButton>(4);
            __builder.AddAttribute(5, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Pages\Index.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Pages\Index.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "FullWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Pages\Index.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Pages\Index.razor"
                                                                                    GoToPage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "Authentication");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "<h2>Welcome</h2>");
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudLink>(16);
                __builder2.AddAttribute(17, "Href", "/authentication/Login");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, "Login");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591