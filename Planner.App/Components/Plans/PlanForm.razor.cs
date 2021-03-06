using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Planner.App.Shared;
using Planner.Client.Services.Exceptions;
using Planner.Client.Services.Interfaces;
using Planner.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AKSoftware.Localization.MultiLanguages;
using AKSoftware.Localization.MultiLanguages.Blazor;

namespace Planner.App.Components
{
    public partial class PlanForm
    {
        [Inject]
        public IPlansService PlansService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ILanguageContainerService Language { get; set; }

        [CascadingParameter]
        public Error Error { get; set; }

        [Parameter]
        public string Id { get; set; }

        private bool _isEditMode => Id != null;

        private PlanDetail _model = new PlanDetail();
        private bool _isBusy = false;
        private Stream _stream = null;
        private string _fileName = string.Empty;
        private string _errorMessage = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Language.InitLocalizedComponent(this);

            if (_isEditMode)
            {
                await FetchPlanByIdAsync();
            }
        }

        private async Task SubmitFormAsync()
        {
            _isBusy = true;

            try
            {
                FormFile formFile = null;
                if (_stream != null)
                {
                    formFile = new FormFile(_stream, _fileName);
                }

                if (_isEditMode)
                {
                    await PlansService.EditAsync(_model, formFile);
                }
                else
                {
                    await PlansService.CreateAsync(_model, formFile);
                }
                // Success
                Navigation.NavigateTo("/plans");
            }
            catch (ApiException ex)
            {
                _errorMessage = ex.ApiErrorResponse.Message;
            }
            catch (Exception ex)
            {
                // Handle errors
                Error.HandleError(ex);
            }

            _isBusy = false;
        }

        private async Task FetchPlanByIdAsync()
        {
            _isBusy = true;

            try
            {
                var result = await PlansService.GetByIdAsync(Id);
                _model = result.Value;
            }
            catch (ApiException ex)
            {
                _errorMessage = ex.ApiErrorResponse.Message;
            }
            catch (Exception ex)
            {
                // Handle errors
                Error.HandleError(ex);
            }

            _isBusy = false;
        }

        private async Task OnChooseFileAsync(InputFileChangeEventArgs e)
        {
            _errorMessage = string.Empty;
            var file = e.File;
            if (file != null)
            {
                if (file.Size >= 2097152)
                {
                    _errorMessage = Language["FileSizeLimitError"];
                    return;
                }

                string[] allowedExtensions = new[] { ".jpg", ".png", ".bmp", ".svg" };

                string extension = Path.GetExtension(file.Name).ToLower();

                if (!allowedExtensions.Contains(extension))
                {
                    _errorMessage = Language["InvalidImageFile"];
                    return;
                }

                using (var stream = file.OpenReadStream(2097152))
                {
                    var buffer = new byte[file.Size];
                    await stream.ReadAsync(buffer, 0, (int)file.Size);
                    _stream = new MemoryStream(buffer);
                    _stream.Position = 0;
                    _fileName = file.Name;
                }
            }
        }
    }
}
