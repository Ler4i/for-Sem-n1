using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models1
{
    public class Workers
    {
        public int WorkersId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Post { get; set; }
        public int NumberOfFloor { get; set; }

        public int BuildingsId { get; set; }
        public Buildings Buildings { get; set; }

        public List<Clients> Clients { get; set; }
    }
}
