using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models3
{
    public class StatusOfOrders
    {
        public int StatusOfOrdersId { get; set; }
        public bool Adopted { get; set; } //принят
        public bool Preparing { get; set; } //готовится
        public bool Sent { get; set; } //отправлен
        public bool Delivered { get; set; } //доставлен
        public bool Received { get; set; } //получен


        public int OrdersId { get; set; }
        public Orders Orders { get; set; }
    }
}
