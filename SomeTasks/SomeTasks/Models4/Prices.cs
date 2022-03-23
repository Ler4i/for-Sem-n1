using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4
{
    public class Prices
    {
        public int PricesId { get; set; }
        public float Price { get; set; }


        public int ProductsId { get; set; }
        public Products Products { get; set; }

    }
}
