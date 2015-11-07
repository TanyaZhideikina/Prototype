using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{   //TG таблица Опыт Кандидата(здесь будет детальная информация об опыте кандидата)
    class Experience
    {
        //TG индефикатор позиции, которую занимал кандидат
        [Key]
        public int IDExperience { get; set; }

        //TG название позиции
        public string Position { get; set; }

        //TG продолфительность (сколько времени кандидат занимал должность) int  - плохой тип для єтого свойства
        public int Duration { get; set; }

        //TG период на протяжении которого кандидат занимал должность, DateTime - неудачный тип, не сильно катит, буду менять
        public DateTime Period { get; set; }
    }
}
