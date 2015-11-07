using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    //TG таблица Контакты, будет использоваться двумя таблицами -  это Контакты или Работадатели или Кандидаты
    class Contacts
    {
        //TG идентификатор контакта
        [Key]
        public int IdContant { get; set; }

        //TG адресс(есть и у контакта, и у работадателя), обычный string
        public string Address { get; set; }

        //TG телефонный номер(есть и у контакта, и у работадателя), будет форматированная строка 
        public string PhoneNumber { get; set; }

        //TG мыло (есть и у контакта, и у работадателя), будет форматированная строка 
        public string Email { get; set; }

        //TG id в различных социальных сетях(ссылки на вк, фейсбук, linkedIn)
        public string SocialNetworkID { get; set; }
    }
}
