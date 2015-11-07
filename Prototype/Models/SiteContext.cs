using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Models
{
    class SiteContext : DbContext
    {
        //TG создаю контекст для всех таблиц DbSet - таблички
        public DbSet<Applicants> Applicants { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Employers> Employers { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Vacancies> Vacancies { get; set; }


    }
}
