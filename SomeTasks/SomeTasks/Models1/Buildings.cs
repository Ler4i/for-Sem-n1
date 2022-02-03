using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeTasks.Models1
{
    public class Buildings
    {
        public int BuildingsId { get; set; }
        public float Number { get; set; }
        public int NumberOfFloor { get; set; } //номер этажа

        //ключ
        public int CityId { get; set; }
        //ссылка на главного
        public City City { get; set; }
        //ссылка на меньшего
        public List<Workers> Workers { get; set; }
    }
}
