using AKSoftware.Localization.MultiLanguages;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKSoftware.Localization.MultiLanguages.Blazor;

namespace Planner.App.Components
{
    public partial class ConfirmationDialog
    {
        [Inject]
        public ILanguageContainerService Language { get; set; }

        [CascadingParameter] 
        private MudDialogInstance MudDialog { get; set; }

        [Parameter] 
        public string ContentText { get; set; }

        [Parameter] 
        public string ButtonText { get; set; }

        [Parameter] 
        public Color Color { get; set; }

        protected override void OnInitialized()
        {
            Language.InitLocalizedComponent(this);
        }

        void Submit() => MudDialog.Close(DialogResult.Ok(true));
        void Cancel() => MudDialog.Cancel();
    }
}
