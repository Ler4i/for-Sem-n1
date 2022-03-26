using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4.Models
{
    public class UserIdentity
    {
        public string? NumberPrefix { get; set; }
        public string? Number { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}
