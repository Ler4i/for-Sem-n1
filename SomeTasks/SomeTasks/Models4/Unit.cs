using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }


        public int ProductsId { get; set; }
        public Products Products { get; set; }
    }
}
