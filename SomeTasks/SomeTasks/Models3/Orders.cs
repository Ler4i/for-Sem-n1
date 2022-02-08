using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models3
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public string Status { get; set; }
        public int Count { get; set; }


        public int ClientId { get; set; }
        public Client Client { get; set; }

        public List<StatusOfOrders> StatusOfOrders { get; set; }
    }
}
