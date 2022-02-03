using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class ListOfPurchases//список покупок
    {
        public int ListOfPurchasesId { get; set; }
        public int Count { get; set; }
        public int Name { get; set; }

        public int ClientsId { get; set; }
        public Clients Clients { get; set; }

        public int JewelryId { get; set; }
        public Jewelry Jewelry { get; set; }
    }
}
