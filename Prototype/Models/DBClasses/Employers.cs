using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    //TG таблица Employers = Работодатели, может сделать их более ориентированными на hrов
    class Employers
    {
        //TG индефикатор таблицы Работадатели, Primary Key
        [Key]
        public int IdEmployer { get; set; }

        //TG имя работадателя = название компании = возможно имя hr
        public string Name { get; set; }

        //TG город, в котором находится компания(по какому городу происходит поиск), возможно свойство необязательное для заполнения
        public string City { get; set; }

        //TG индефикатор таблицы Контакты(ссылка на табл Контакты работадателя), Foreign Key
        public int IdContact { get; set; }

        //TG индефикатор таблицы Вакансии(ссылка на таблицу Вакансии, в которой описана вакансия работадателя), Foreign Key
        public int IdVacancy { get; set; }

    }
}
