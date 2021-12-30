using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.App.Components
{
    public partial class ConfirmationDialog
    {
        [CascadingParameter] 
        private MudDialogInstance MudDialog { get; set; }

        [Parameter] 
        public string ContentText { get; set; }

        [Parameter] 
        public string ButtonText { get; set; }

        [Parameter] 
        public Color Color { get; set; }

        void Submit() => MudDialog.Close(DialogResult.Ok(true));
        void Cancel() => MudDialog.Cancel();
    }
}
