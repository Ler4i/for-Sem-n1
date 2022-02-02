using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models
{
    public class ListOfMusic
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Genre { get; set; }
        public string Executor { get; set; }
        public float Time { get; set; }

        // Это свойство будет использоваться как внешний ключ
        public int UserId { get; set; }

        // Ссылка на юзера
        public User User { get; set; }
    }
}
