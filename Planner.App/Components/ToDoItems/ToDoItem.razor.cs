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

        [CascadingParameter]
        public Error Error { get; set; }

        [Parameter]
        public ToDoItemDetail Item { get; set; }

        [Parameter]
        public EventCallback<ToDoItemDetail> OnItemDeleted { get; set; }

        [Parameter]
        public EventCallback<ToDoItemDetail> OnItemEdited { get; set; }

        private bool _isChecked = true;

        private bool _isEditMode = false;
        private bool _isBusy = false;
        private string _description = String.Empty;
        private string _errorMessage = String.Empty;
        private string _descriptionStyle => $"cursor:pointer; {(!_isChecked ? "" : "text-decoration: line-through")}";

        protected override void OnInitialized()
        {
            _isChecked = Item.IsDone;
        }

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
                Error.HandleError(ex);
            }

            _isBusy = false;
        }

        private async Task EditItemAsync()
        {
            _errorMessage = String.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(_description))
                {
                    _errorMessage = "Description is required";
                    return;
                }
                _isBusy = true;

                // call the API to add the item
                var result = await ToDoItemsService.EditAsync(Item.Id, _description, Item.PlanId);
                ToggleEditMode(false);

                //Notify the parent about the newly added item
                await OnItemEdited.InvokeAsync(result.Value);
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

        private async Task ToggleItemAsync(bool value)
        {
            _errorMessage = String.Empty;
            try
            {
                _isBusy = true;

                // call the API to add the item
                await ToDoItemsService.ToggleAsync(Item.Id);
                Item.IsDone = !Item.IsDone;
                _isChecked = Item.IsDone;
                //Notify the parent about the newly added item
                await OnItemEdited.InvokeAsync(Item);
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