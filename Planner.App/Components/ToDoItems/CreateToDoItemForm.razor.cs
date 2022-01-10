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
using Planner.Client.Services.Interfaces;
using Planner.Client.Services.Exceptions;
using Planner.Shared.Models;

namespace Planner.App.Components
{
    public partial class CreateToDoItemForm
    {
        [Inject]
        public IToDoItemsService ToDoItemsService { get; set; }

        [CascadingParameter]
        public Error Error { get; set; }

        [Parameter]
        public string PlanId { get; set; }

        [Parameter]
        public EventCallback<ToDoItemDetail> OnToDoItemAdded { get; set; }

        private bool _isBusy = false;
        private string _description { get; set; }

        private string _errorMessage = string.Empty;

        private async Task AddToDoItemAsync()
        {
            _errorMessage = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(_description))
                {
                    _errorMessage = "Description is required";
                    return;
                }

                _isBusy = true;

                // call the API to add the item
                var result = await ToDoItemsService.CreateAsync(_description, PlanId);
                _description = string.Empty;

                //Notify the parent about the newly added item
                await OnToDoItemAdded.InvokeAsync(result.Value);
            }
            catch (ApiException ex)
            {
                _errorMessage = ex.Message;
            }
            catch (Exception ex)
            {

                // TODO: log errors
                Error.HandleError(ex);
            }

            _isBusy = false;
        }
    }
}