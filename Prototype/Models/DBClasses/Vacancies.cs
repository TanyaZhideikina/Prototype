using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{   //TG таблица Вакансии Работодателя
    class Vacancies
    {
        //TG индефикатор самой вакансии, Primary Key
        [Key]
        public int IdVacancy { get; set; }
       
        //TG индефикатор работадателя, Foreign Key
        public int IdEmployer { get; set; }

        //TG время публикаии вакансии
        public DateTime PlacingDate{ get; set; }

        //TG предложенная позиция
        public string Position{ get; set; }

        //TG требования к кандидатупо данной вакансии
        public string Requirements { get; set; }

        //TG предложенная зарплата
        public int Salary { get; set; }

        //TG часы аботы(возможно стоит заменить на string - типо полная занятость, частичная итд)
        public int WorkingHours { get; set; }

        //TG
        public string Conditions { get; set; }

        //TG состояние вакансии(активна, закрыта, в архиве)
        public string State { get; set; }
    }
}
