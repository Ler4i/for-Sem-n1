using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4.Models
{
    public class UserUpdate
    {
        public int Id { get; set; }//столбец
        public string Email { get; set; }
        public string Login { get; set; }
        public bool IsBoy { get; set; }
        public string Password { get; set; }
        public string PhoneNumderPrefix { get; set; }
        public string PhoneNumder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }


        public string CurrentPhoneNumber { get; set; }//в данный момент
        public string CurrentNumderPrefix { get; set; }
        public string CurrentPassword { get; set; }
    }
}
