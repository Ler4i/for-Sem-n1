using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class DiscountCards
    {
        public int DiscountCardsId { get; set; }
        public int Count { get; set; }
        public int Status { get; set; }

        public int ClientsId { get; set; }
        public Clients Clients { get; set; }
    }
}
