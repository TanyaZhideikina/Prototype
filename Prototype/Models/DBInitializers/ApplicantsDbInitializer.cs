using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class ApplicantsDbInitializer: DropCreateDatabaseAlways<SiteContext>
    {
        //TG сигнатуру следующего метода изменять нельзя ибо єто часть Entity фреймворка
        //ссылка на тьюториал по методу
        //http://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx 
        protected override void Seed(SiteContext db)
        {
            //добавляем строку в таблицу
            db.Applicants.Add(new Applicants
            {
                IdApplicant = 000001,
                Name = "Tania",
                SecondName = "Zhidejkina",
                Patronymic = "Anatoliivna",
                Age = 18,
                DateOfBirth = DateTime.Now,
                City = "Kiev",
                IdContact = 000001,
                IdEducation = 000001,
                DesiredPosition = "Asp.Net programmer",
                DesiredRate = 5000,
                Achievements = "cool girl",
                Requirements = ""
            });


            base.Seed(db);
        }
    }
}
