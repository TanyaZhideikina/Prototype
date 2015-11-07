using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class VacanciesDbInitializer : DropCreateDatabaseAlways<SiteContext>
    {
        //TG сигнатуру следующего метода изменять нельзя ибо єто часть Entity фреймворка
        //ссылка на тьюториал по методу
        //http://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx 
        protected override void Seed(SiteContext db)
        {
            //добавляем строку в таблицу
            db.Vacancies.Add(new Vacancies
            {
                IdVacancy = 000001,
                IdEmployer = 000001,
                PlacingDate = DateTime.Now,
                Position = "ASP.Net developer",
                Requirements = "...",
                Salary = 3333,
                WorkingHours = 8,
                Conditions = "...",
                State = "Open"
            });

            base.Seed(db);
        }
    }
}
