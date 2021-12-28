﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Planner.App.Pages
{
    public partial class Index
    {
        private string _pageName { get; set; } = @"/authentication/login";

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private void GoToPage()
        {         
            NavigationManager.NavigateTo(_pageName);
        }
    }
}
