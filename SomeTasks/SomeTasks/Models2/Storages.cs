using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class Storages //склады
    {
        public int StoragesId { get; set; }
        public string Adress { get; set; }
        public int Count { get; set; }

        public int SalonsId { get; set; }
        public Salons Salons { get; set; }

        public List<Jewelry> Jewelry { get; set; }
    }
}
