using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class Cities
    {
        public int CitiesId { get; set; }
        public string Name { get; set; }

        public List<Salons> Salons { get; set; }
    }
}
