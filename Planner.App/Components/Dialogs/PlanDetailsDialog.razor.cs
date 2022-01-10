using Microsoft.AspNetCore.Components;
using MudBlazor;
using Planner.App.Shared;
using Planner.Client.Services.Exceptions;
using Planner.Client.Services.Interfaces;
using Planner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AKSoftware.Localization.MultiLanguages;
using AKSoftware.Localization.MultiLanguages.Blazor;

namespace Planner.App.Components
{
    public partial class PlanDetailsDialog
    {
        [CascadingParameter] 
        MudDialogInstance MudDialog { get; set; }

        [Inject]
        public IPlansService PlansService { get; set; }

        [Inject]
        public ILanguageContainerService Language { get; set; }

        [CascadingParameter]
        public Error Error { get; set; }

        [Parameter]
        public string PlanId { get; set; }

        private PlanDetail _plan;
        private bool _isBusy;
        private string _errorMessage = string.Empty;
        private List<ToDoItemDetail> _items = new();

        private void Close()
        {
            MudDialog.Cancel();
        }

        protected override void OnParametersSet()
        {
            if (PlanId == null)
            {
                throw new ArgumentNullException(nameof(PlanId));
            }
            base.OnParametersSet();
        }

        protected async override Task OnInitializedAsync()
        {
            Language.InitLocalizedComponent(this);
            await FetchPlanAsync();
        }

        private async Task FetchPlanAsync()
        {
            _isBusy = true;

            try
            {
                var result = await PlansService.GetByIdAsync(PlanId);
                _plan = result.Value;
                _items = _plan.ToDoItems;
                StateHasChanged();
            }
            catch (ApiException ex)
            {
                // TODO: Log errors
            }
            catch (Exception ex)
            {

                // TODO: Log errors
                Error.HandleError(ex);
            }

            _isBusy = false;
        }

        private void OnToDoItemAddedCallback(ToDoItemDetail todoItem)
        {
            _items.Add(todoItem);
        }

        private void OnToDoItemDeletedCallback(ToDoItemDetail toDoItem)
        {
            _items.Remove(toDoItem);
        }

        private void OnToDoItemEditedCallback(ToDoItemDetail toDoItem)
        {
            var editedItem = _items.SingleOrDefault(i => i.Id == toDoItem.Id);
            editedItem.Description = toDoItem.Description;
            editedItem.IsDone = toDoItem.IsDone;
        }
    }
}
