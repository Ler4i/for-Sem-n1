using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models3
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string PhonePrefix { get; set; }
        public string Email { get; set; }
        public bool IsBoy { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
