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
using Planner.Shared.Models;
using Planner.Client.Services.Interfaces;
using Planner.Client.Services.Exceptions;

namespace Planner.App.Components
{
    public partial class ToDoItem
    {
        [Inject]
        private IToDoItemsService ToDoItemsService { get; set; }

        [Parameter]
        public ToDoItemDetail Item { get; set; }

        [Parameter]
        public EventCallback<ToDoItemDetail> OnItemDeleted { get; set; }

        private bool _isChecked = true;

        private bool _isEditMode = false;
        private bool _isBusy = false;
        private string _description = String.Empty;

        private void ToggleEditMode(bool isCancel)
        {
            if (_isEditMode)
            {
                _isEditMode = false;
                _description = isCancel ? Item.Description : _description;
            }
            else
            {
                _isEditMode = true;
                _description = Item.Description;
            }
        }

        private async Task RemoveItemAsync()
        {
            try
            {
                _isBusy = true;

                // call the API to add the item
                await ToDoItemsService.DeleteAsync(Item.Id);
                _description = string.Empty;

                //Notify the parent about the newly added item
                await OnItemDeleted.InvokeAsync(Item);
            }
            catch (ApiException ex)
            {
                // TODO: handle errors
            }
            catch (Exception ex)
            {
                // TODO: log errors
            }

            _isBusy = false;
        }
    }
}