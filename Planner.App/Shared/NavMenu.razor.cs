using AKSoftware.Localization.MultiLanguages;
using AKSoftware.Localization.MultiLanguages.Blazor;
using Microsoft.AspNetCore.Components;

namespace Planner.App.Shared
{
    public partial class NavMenu
    {
        [Inject]
        public ILanguageContainerService Language { get; set; }

        protected override void OnInitialized()
        {
            Language.InitLocalizedComponent(this);
        }
    }
}
