using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class EmployersDbInitializer : DropCreateDatabaseAlways<SiteContext>
    {
        //TG сигнатуру следующего метода изменять нельзя ибо єто часть Entity фреймворка
        //ссылка на тьюториал по методу
        //http://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx 
        protected override void Seed(SiteContext db)
        {
            //добавляем строку в таблицу
            db.Employers.Add(new Employers
            {
                IdEmployer = 000001,
                Name = "Ciklum",
                City = "Kiev",
                IdContact = 000001,
                IdVacancy = 000001
            });

            base.Seed(db);
        }
    }
}
