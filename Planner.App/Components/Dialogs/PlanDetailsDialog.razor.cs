using Microsoft.AspNetCore.Components;
using MudBlazor;
using Planner.Client.Services.Exceptions;
using Planner.Client.Services.Interfaces;
using Planner.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.App.Components
{
    public partial class PlanDetailsDialog
    {
        [CascadingParameter] 
        MudDialogInstance MudDialog { get; set; }

        [Inject]
        public IPlansService PlansService { get; set; }

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
            }

            _isBusy = false;
        }

        private void OnToDoItemAddedCallback(ToDoItemDetail todoItem)
        {
            _items.Add(todoItem);
        }
    }
}
