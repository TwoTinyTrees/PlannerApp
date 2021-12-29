using Planner.Shared.Models;
using Planner.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Client.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ApiResponse> RegisterUserAsync(RegisterRequest model);

        // TODO: migrate login to IAuthenticationService
    }
}
