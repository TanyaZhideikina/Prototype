using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class ExperienceDbInitializer : DropCreateDatabaseAlways<SiteContext>
    {
        //TG сигнатуру следующего метода изменять нельзя ибо єто часть Entity фреймворка
        //ссылка на тьюториал по методу
        //http://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx 
        protected override void Seed(SiteContext db)
        {
            //добавляем строку в таблицу
            db.Experience.Add(new Experience
            {
                IDExperience = 000001,
                Position = "Junior Asp.NET deveoper",
                Duration = 0,
                Period = DateTime.Now
            });

            base.Seed(db);
        }
    }
}
