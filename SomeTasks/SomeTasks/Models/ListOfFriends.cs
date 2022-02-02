using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models
{
    public class ListOfFriends
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public bool IsClose { get; set; }

        // Это свойство будет использоваться как внешний ключ
        public int UserId { get; set; }

        // Ссылка на юзера
        public User User { get; set; }
    }
}
