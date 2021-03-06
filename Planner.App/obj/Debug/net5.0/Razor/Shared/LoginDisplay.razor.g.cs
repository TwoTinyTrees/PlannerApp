#pragma checksum "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d02b5c3d13bb4d7d70593889b209e8091229ffb"
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
#line 1 "C:\Github\Practice\Planner.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\Practice\Planner.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Github\Practice\Planner.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Github\Practice\Planner.App\_Imports.razor"
using Planner.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Github\Practice\Planner.App\_Imports.razor"
using Planner.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Github\Practice\Planner.App\_Imports.razor"
using Planner.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Github\Practice\Planner.App\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Github\Practice\Planner.App\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudMenu>(2);
                __builder2.AddAttribute(3, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                        Icons.Filled.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 6 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                                    Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Direction>(
#nullable restore
#line 6 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                                                                Direction.Right

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OffsetY", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                                                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudMenuItem>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(10, "Welcome ");
#nullable restore
#line 7 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
__builder4.AddContent(11, context.User.FindFirst(ClaimTypes.GivenName).Value);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudMenuItem>(13);
                    __builder3.AddAttribute(14, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                  LogOutAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(16, "Logout");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(17, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudIconButton>(18);
                __builder2.AddAttribute(19, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                              Icons.Filled.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                                         Color.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Github\Practice\Planner.App\Shared\LoginDisplay.razor"
                                                                                   () => Navigation.NavigateTo("/authentication/login")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
