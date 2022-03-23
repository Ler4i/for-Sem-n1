using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4
{
    public class User
    {
        public int UserId { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public float Money { get; set; }


        List<Order> Orders { get; set; }
    }
}
