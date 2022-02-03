using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models1
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Case { get; set; } // дело

        public int WorkersId { get; set; }
        public Workers Workers { get; set; }
    }
}
