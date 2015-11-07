using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prototype.Models;

namespace Prototype.Controllers
{
    public class HomeController : Controller
    {
        //TG подключаю контекст данных к HomeController
        SiteContext db = new SiteContext();

        public ActionResult Index()
        {
            //И так, народ, я пишу сейчас прототип базы в этом проекте , поэтому здесь в комментариях хочу объяснить что к чему и что я катаю
            //Все знают что MVC умеет лепить из классов и их свойств таблицы со строками - и это наше спасение. Сейчас я делаю прототип базы - 
            //просто пишу классы со свойствами(если не знаете или не до конца вдуплили, что такое поля или свойства - прогуглите и поймите)
            //Проект создала просто Basic Asp.net MVC 4.5 c подключенным MSSQL Server от Microsoft(это на случай если вам удалось открыть проект,
            //но вы его еще не запускали). Мои классы будут лежать просто в общей папке. Если вам удобней переместить в empty project или отдельную
            //папку - вперед. Здесь я розмещу перечень созданых классов. А еще в каждом классе я постараюсь написать, что значит каждое свойство и 
            //сам класс. Все коменты я буду писать с пометкой TG, чтоб ясно было, что это мой коммент
            //Applicants = Кандидаты
            //Employers = Работодатели
            //Contacts = Контакты Кандидата или Работадателя
            //Experience = Опыт Кандидата
            //Vacancies = Вакансии Работадателя
            //Education = Образование кандидата - таблица не содержит свойств ибо будет реформирована


            // получаем из бд все объекты Applicants
            IEnumerable<Applicants> Applicants = db.Applicants;
            // передаем все объекты в динамическое свойство Applicants в ViewBag
            ViewBag.Applicants = Applicants;

            // получаем из бд все объекты Employers
            IEnumerable<Employers> Employers = db.Employers;
            // передаем все объекты в динамическое свойство Employers в ViewBag
            ViewBag.Employers = Employers;

            // получаем из бд все объекты Contacts
            IEnumerable<Contacts> Contacts = db.Contacts;
            // передаем все объекты в динамическое свойство Contacts в ViewBag
            ViewBag.Contacts = Contacts;

            // получаем из бд все объекты Experience
            IEnumerable<Experience> Experience = db.Experience;
            // передаем все объекты в динамическое свойство Experience в ViewBag
            ViewBag.Experience = Experience;

            // получаем из бд все объекты Applicants
            IEnumerable<Vacancies> Vacancies = db.Vacancies;
            // передаем все объекты в динамическое свойство Vacancies в ViewBag
            ViewBag.Vacancies = Vacancies;

            // получаем из бд все объекты Education
            IEnumerable<Education> Education = db.Education;
            // передаем все объекты в динамическое свойство Education в ViewBag
            ViewBag.Education = Education;

            // возвращаем представление
            return View();
        }
        
    }
}