using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.JSInterop;
using Planner.App;
using Planner.App.Shared;
using Planner.App.Components;
using MudBlazor;
using Blazored.FluentValidation;
using AKSoftware.Localization.MultiLanguages;
using AKSoftware.Localization.MultiLanguages.Blazor;

namespace Planner.App.Shared
{
    public partial class Error
    {
        [Inject]
        public ISnackbar Snackbar { get; set; }

        [Inject]
        public ILanguageContainerService Language { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void OnInitialized()
        {
            Language.InitLocalizedComponent(this);
        }

        public void HandleError(Exception ex)
        {
            Snackbar.Add(Language["GeneralError"], Severity.Error);

            // TODO: Log the error, send to the server, to applications

            Console.WriteLine($"{ex.Message} - {DateTime.Now}");
        }
    }
}