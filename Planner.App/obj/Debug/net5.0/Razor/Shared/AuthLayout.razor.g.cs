#pragma checksum "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21cef7b57c1aad272a1a3fb9461711bad4b32e4"
// <auto-generated/>
#pragma warning disable 1591
namespace Planner.App.Shared
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
    public partial class AuthLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudLayout>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(2);
                __builder2.AddAttribute(3, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(5);
                    __builder3.AddAttribute(6, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "ml-3");
                    __builder3.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(9, "Planner");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(11);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                              Icons.Material.Filled.MoreVert

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                                                                     Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 8 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                                                                                          Edge.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(20);
                    __builder3.AddAttribute(21, "Justify", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 11 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                          Justify.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Style", "mt-3");
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(24);
                        __builder4.AddAttribute(25, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                         12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "md", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                                 4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "lg", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
                                        4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 13 "C:\Github\Tutorials\BlazorWebAssembly\PlannerApp\Planner.App\Shared\AuthLayout.razor"
__builder5.AddContent(29, Body);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(31);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
