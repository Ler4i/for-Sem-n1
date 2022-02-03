using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class Jewelry //ювелирные украшения
    {
        public int JewelryId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public float Cost { get; set; }
        public int Weight { get; set; }
        public float Carat { get; set; }

        public int StoragesId { get; set; }
        public Storages Storages { get; set; }

        public List<ListOfPurchases> ListOfPurchases { get; set; }
    }
}
