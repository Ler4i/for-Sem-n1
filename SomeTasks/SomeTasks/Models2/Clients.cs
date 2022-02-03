using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models2
{
    public class Clients
    {
        public int ClientsId {get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int SalonsId { get; set; }
        public Salons Salons { get; set; }

        public List<DiscountCards> DiscountCards { get; set; }
        public List<ListOfPurchases> ListOfPurchases { get; set; }

    }
}
