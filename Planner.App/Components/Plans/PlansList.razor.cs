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
    public partial class PlansList
    {
        [Inject]
        public IPlansService PlansService { get; set; }

        [Inject]
        private NavigationManager Navigation { get; set; }

        [Inject]
        public IDialogService DialogService { get; set; }

        private bool _isBusy = false;
        private string _errorMessage = string.Empty;
        private int _pageNumber = 1;
        private int _pageSize = 10;
        private string _query = string.Empty;
        private int _totalPages = 1;

        private List<PlanSummary> _plans = new();

        private async Task<PagedList<PlanSummary>> GetPlansAsync(string query = "", int pageNumber = 1, int pageSize = 10)
        {
            _isBusy = true;
            try
            {
                var result = await PlansService.GetPlansAsync(query, pageNumber, pageSize);
                _plans = result.Value.Records.ToList();
                _pageNumber = result.Value.Page;
                _pageSize = result.Value.PageSize;
                _totalPages = result.Value.TotalPages;

                return result.Value;
            }
            catch (ApiException ex)
            {
                _errorMessage = ex.ApiErrorResponse.Message;
            }
            catch (Exception ex)
            {
                // TODO log error
                _errorMessage = ex.Message;
            }

            _isBusy = false;
            return null;
        }

        #region View Toggler
        private bool _isCardsViewEnabled = true;

        private void SetCardsView()
        {
            _isCardsViewEnabled = true;
        }

        private void SetTableView()
        {
            _isCardsViewEnabled = false;
        }
        #endregion View Toggler

        #region Edit
        private void EditPlan(PlanSummary plan)
        {
            Navigation.NavigateTo($"/plans/form/{plan.Id}");
        }
        #endregion Edit

        #region Delete
        private async Task DeletePlanAsync(PlanSummary plan)
        {
            var parameters = new DialogParameters();
            parameters.Add("ContentText", $"Do you really want to delete the plan '{plan.Title}'?");
            parameters.Add("ButtonText", "Delete");
            parameters.Add("Color", Color.Error);

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = DialogService.Show<ConfirmationDialog>("Delete", parameters, options);
            var confirmationResult = await dialog.Result;

            if (!confirmationResult.Cancelled)
            {
                //Confirmed to delete
                await PlansService.DeleteAsync(plan.Id);
            }
        }
        #endregion Delete
    }
}
