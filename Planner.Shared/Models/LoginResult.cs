using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Shared.Models
{
    public class LoginResult
    {
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }    
    }
}
