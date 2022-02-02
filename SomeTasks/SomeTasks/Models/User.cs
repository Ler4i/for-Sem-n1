using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models
{
    public class User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsBoy { get; set; }
        public string Adress { get; set; }
        public string Counry { get; set; }

        // Ссылка на музыку и тд
        public List<ListOfMusic> ListOfMusiс { get; set; }
        public List<ListOfFriends> ListOfFriends { get; set; }

        public List<Products> Products { get; set; }

        public List<ListOfPublicSites> ListOfPublicSites { get; set; }

    }
}

