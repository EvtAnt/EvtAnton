using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP
{
    /// <summary>
    /// Класс, содержащий в себе списки с именами и фамилиями
    /// </summary>
    class ListNameSurname
    {
        /// <summary>
        /// Список мужских имён
        /// </summary>
        public string[] firstNameMan = new string[]
        {
            "Алексей",
            "Антон",
            "Сергей",
            "Владимир",
            "Дмитрий",
            "Кирилл"
        };

        /// <summary>
        /// Список женских имён
        /// </summary>
        public string[] firstNameWoman = new string[]
        {
            "Анастасия",
            "Мария",
            "Анна",
            "Алеся",
            "Светлана",
            "Александра"
        };

        /// <summary>
        /// Список фамилий
        /// </summary>
        public string[] lastNameAll = new string[]
        {
            "Евтушенко",
            "Коваленко",
            "Петренко",
            "Бродт",
            "Паскарь",
            "Денисенко"
        };

    }
}
