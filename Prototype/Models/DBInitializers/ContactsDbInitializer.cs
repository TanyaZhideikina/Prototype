using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class ContactsDbInitializer : DropCreateDatabaseAlways<SiteContext>
    {
        //TG сигнатуру следующего метода изменять нельзя ибо єто часть Entity фреймворка
        //ссылка на тьюториал по методу
        //http://www.entityframeworktutorial.net/code-first/seed-database-in-code-first.aspx 
        protected override void Seed(SiteContext db)
        {
            //добавляем строку в таблицу
            db.Contacts.Add(new Contacts
            {
                IdContant = 000001,
                Address = "Kernatovskogo street, Kiev, Ukraine",
                PhoneNumber = "+380960152650",
                Email = "zhidejkina@gmail.com",
                SocialNetworkID = "zhidejkina"
            });

            base.Seed(db);
        }
    }
}
