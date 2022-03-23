using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Count { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        List<Products> Products { get; set; }

    }
}
