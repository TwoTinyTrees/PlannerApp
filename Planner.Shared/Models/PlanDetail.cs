using Microsoft.AspNetCore.Http;

namespace Planner.Shared.Models
{
    public class PlanDetail : PlanSummary
    {
        public IFormFile CoverFile { get; set; }
        
        // List of the to-dos
    }
}
