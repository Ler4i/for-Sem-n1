using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models4.Models
{
    public class UserInformation
    {
        public int Id { get; set; }//столбец
        public string Email { get; set; }
        public bool IsBoy { get; set; }
        public string PhoneNumderPrefix { get; set; }
        public string PhoneNumder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
    }
}
