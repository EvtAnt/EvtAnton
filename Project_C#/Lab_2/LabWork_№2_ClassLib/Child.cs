using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_ClassLib
{
    /// <summary>
    /// Ребёнок
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Минимальный возраст ребёнка
        /// </summary>
        public const int minAge = 0;

        /// <summary>
        /// Максимальный возраст ребёнка
        /// </summary>
        public const int maxAge = 17;

        /// <summary>
        /// Возраст ребёнка
        /// </summary>
        public override int Age
        {
            get { return _age; }
            set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentOutOfRangeException(
                        $"{value} должен быть в пределах " +
                        $"от {minAge} до {maxAge}");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Детский сад или школа
        /// </summary>
        private string _nameKindergartenOrSchool;

        /// <summary>
        /// Название детского сада/школы
        /// </summary>
        public string NameKindergartenOrSchool
        {
            get { return _nameKindergartenOrSchool; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "Не указан детский сад/школа.");
                }
                _nameKindergartenOrSchool = value;
            }
        }

        /// <summary>
        /// Мать
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother
        {
            get { return _mother; }
            set { _mother = value; }
        }

        /// <summary>
        /// Отец
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father
        {
            get { return _father; }
            set { _father = value; }
        }

        /// <summary>
        /// Метод, формирующий информацию о ребёнке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public override string InfoAboutPerson()
        {
            var infoAboutPerson = base.InfoAboutPerson() +
                $"Учебное заведение: {NameKindergartenOrSchool} | ";

            if (Mother != null)
            {
                infoAboutPerson += $"Мама: {Mother.LittleInfoAboutPerson()} | ";
            }

            if (Father != null)
            {
                infoAboutPerson += $"Папа: {Father.LittleInfoAboutPerson()} | ";
            }

            return infoAboutPerson;
        }

        /// <summary>
        /// Метод, характерный для класса Child
        /// </summary>
        /// <returns>Строка</returns>
        public string ChildRelax()
        {
            return "Ребёнок отдыхает летом.";
        }
    }
}
