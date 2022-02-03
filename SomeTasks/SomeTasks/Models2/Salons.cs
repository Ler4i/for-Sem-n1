using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class Salons
    {
        public int SalonsId { get; set; }
        public int Count { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }

        public int CitiesId { get; set; }
        public Cities Cities { get; set; }

        public List<Storages> Storages { get; set; }
        public List<Clients> Clients { get; set; }
        public List<Jewelry> Jewelry { get; set; }

    }
}
