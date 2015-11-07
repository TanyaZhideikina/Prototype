using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//TG подкл
using System.Data.Entity;
using Prototype.Models;

namespace Prototype
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //TG инициализируем таблицу Applicants
            Database.SetInitializer(new ApplicantsDbInitializer());

            //TG инициализируем таблицу Employers
            Database.SetInitializer(new EmployersDbInitializer());

            //TG инициализируем таблицу Contacts
            Database.SetInitializer(new ContactsDbInitializer());

            //TG инициализируем таблицу Experience
            Database.SetInitializer(new ExperienceDbInitializer());

            //TG инициализируем таблицу Vacancies
            Database.SetInitializer(new VacanciesDbInitializer());

            //TG инициализируем таблицу Education
            Database.SetInitializer(new EducationDbInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
