using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models
{
    public class ListOfPublicSites
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsUseful { get; set; }
        public int count { get; set; }


        // Это свойство будет использоваться как внешний ключ
        public int UserId { get; set; }

        // Ссылка на юзера
        public User User { get; set; }
    }
}
