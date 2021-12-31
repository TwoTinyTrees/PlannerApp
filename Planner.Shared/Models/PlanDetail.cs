using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Planner.Shared.Models
{
    public class PlanDetail : PlanSummary
    {
        public IFormFile CoverFile { get; set; }

        // List of the to-dos

        public List<ToDoItemDetail> ToDoItems { get; set; }
    }

}
