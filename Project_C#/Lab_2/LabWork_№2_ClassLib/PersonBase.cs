using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_ClassLib
{
    //TODO: Переделать в абстрактный класс +
    /// <summary>
    /// Класс, описывающий персону
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Приватное поле Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                CheckSurnameName(value);
                _surname = RegisterCorrection(value);
            }
        }

        /// <summary>
        /// Приватное поле Имя
        /// </summary>
        protected string _name;

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                CheckSurnameName(value);
                _name = RegisterCorrection(value);
            }
        }

        //TODO: сделать protected +
        /// <summary>
        /// Приватное поле Возраст
        /// </summary>
        protected int _age;

        //TODO: сделать абстрактным +
        /// <summary>
        /// Возраст человека
        /// </summary>
        public abstract int Age { get; set; }

        /// <summary>
        /// Приватное поле Пол
        /// </summary>
        private Gender _gender;

        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        /// <summary>
        /// Конструктор класса Person №1
        /// </summary>
        public PersonBase() { }

        /// <summary>
        /// Конструктор класса Person №2
        /// </summary>
        /// <param name="surname">Фамилия персоны</param>
        /// <param name="name">Имя персоны</param>
        /// <param name="age">Возраст персоны</param>
        /// <param name="gen">Пол персоны</param>
        public PersonBase(string surname, string name, int age, Gender gen)
        {
            Surname = surname;           
            Name = name;
            Age = age;
            Gender = gen; 
        }

        /// <summary>
        /// Метод для проверки соответствия строк заданным требованиям
        /// </summary>
        /// <param name="checkStroka">Строка, передаваемая на проверку</param>
        private void CheckSurnameName(string checkStroka)
        {
            char[] unnecСhar = { '~', '`', '!', '@', '"', '#', '$', ';', 
                '.', ':', ',', '?', '&', '?', '*', '(', ')', '_', '=', 
                '+', '/'};
            char[] chisla = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            if (checkStroka.IndexOfAny(unnecСhar) != -1 ||
                checkStroka.IndexOf('-', 0, 1) != -1 ||
                checkStroka.LastIndexOf('-', 0, 1) != -1 ||
                checkStroka.IndexOfAny(chisla, 0) != -1)
            {
                throw new FormatException("Использованы недопустимые " +
                                            "символы при вводе");
            }
        }

        /// <summary>
        /// Метод, исправляющий регистр имени/фамилии
        /// </summary>
        /// <param name="correctionNameSurname">
        /// Строка, передаваемая для исправления регистра</param>
        private string RegisterCorrection(string correctionNameSurname)
        {
            string firstLetter = correctionNameSurname.ToUpper().Substring(0, 1);                                               
            return correctionNameSurname
                    .ToLower()
                    .Remove(0, 1)
                    .Insert(0, firstLetter);
        }

        /// <summary>
        /// Метод, формирующий информацию о человеке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public virtual string InfoAboutPerson()
        {
            return $"Фамилия: {Surname} | Имя: {Name} | Возраст: {Age} | " +
                $"Пол: {Gender} | ";
        }

        /// <summary>
        /// Метод, формирующий краткую информацию о человеке
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public string LittleInfoAboutPerson()
        {
            return $"{Surname} {Name}";
        }
    }
}
