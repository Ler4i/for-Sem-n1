using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }


        public int OrderId { get; set; }
        public Order Order { get; set; }


        List<Prices> Prices { get; set; }

        List<Unit> Units { get; set; }

        public int UnitId { get; set; }

    }
}
