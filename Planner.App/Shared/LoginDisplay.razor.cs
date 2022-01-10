using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using AKSoftware.Localization.MultiLanguages;
using AKSoftware.Localization.MultiLanguages.Blazor;

namespace Planner.App.Shared
{
    public partial class LoginDisplay
    {
        [Inject]
        private ILocalStorageService Storage {get; set;}

        [Inject]
        private NavigationManager Navigation { get; set; }

        [Inject] 
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        public ILanguageContainerService Language { get; set; }

        protected override void OnInitialized()
        {
            Language.InitLocalizedComponent(this);
        }

        private async Task LogOutAsync()
        {
            await Storage.RemoveItemAsync("access_token");
            await Storage.RemoveItemAsync("expiry_date");

            await AuthenticationStateProvider.GetAuthenticationStateAsync();
            Navigation.NavigateTo("/authentication/login");
        }
    }
}
