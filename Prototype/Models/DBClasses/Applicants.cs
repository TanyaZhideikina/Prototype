using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    //TG этот класс = таблица (Applicants = Кандидаты) содержит в себе информацию о людях, которые ищут работу на нашем сайте
    class Applicants
    {
        //TG поле индификатор кандидата, первичный ключ этой таблицы, я думаю intовский номер будет норм
        [Key]
        public int IdApplicant { get; set; }

        //TG поле имя кандидата, обычная строка
        public string Name { get; set; }

        //TG поле фамилия кандидата, обычная строка
        public string SecondName { get; set; }

        //TG поле Отчество кандидата, обычная строка, у меня сомнения по поводу названия
        //(не лучше ли назвать FirstName, MiddleName, LastName(да такие слова в инглише есть))
        public string Patronymic { get; set; }

        //TG поле возраст кандидата, обычный int(стоит ли этот тип заменить на тип без минусовых значений(такие есть))
        public int Age { get; set; }

        //TG дата рождения кандиата
        public DateTime DateOfBirth { get; set; }

        //TG город проживания кандидата(город рождения я думаю делать не будем ибо эти данные не так важны)
        public string City { get; set; }

        //TG индефикатор таблицы Контактов Кандидата, Foreighn Key вторичный ключ по которому будет идти связка с таблицей Контакты
        public int IdContact { get; set; }

        //TG индефикатор таблицы Образование Кандидата, Foreighn Key вторичный ключ по которому будет идти связка с таблицей Образование
        public int IdEducation { get; set; }

        //TG индефикатор таблицы Опыт Кандидата, Foreighn Key вторичный ключ по которому будет идти связка с 
        //таблицей в которой будет описано какие позиции и где уже занимал кандидат
        public int IdExperience { get; set; }

        //TG поле Желаемая Позиция (позиция, на которую претендует кандидат), обычный string
        public string DesiredPosition { get; set; }

        //TG поле Желаемая Зарплата (сколько бабла желает получать кандидат), обычный int, думаю может тоже заменить на тип без минусовых значений
        public int DesiredRate { get; set; }

        //TG поле Достижения Кандидата, пока что это обычный string
        public string Achievements { get; set; }

        //TG поле Требования Кандидата к будущему работадателю, пускай будет может добавим когда-то добавим такой функционал, пока обычный string
        public string Requirements { get; set; }

    }
}
