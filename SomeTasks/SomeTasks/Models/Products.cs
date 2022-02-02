using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public float Size { get; set; }
        public float Weight { get; set; }

        // Это свойство будет использоваться как внешний ключ
        public int UserId { get; set; }

        // Ссылка на юзера
        public User User { get; set; }
    }
}
