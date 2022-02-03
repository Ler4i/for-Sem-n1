using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models1
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountOfPeople { get; set; }
        public string Status { get; set; }

        public List<Buildings> Buildings { get; set; }
    }
}
