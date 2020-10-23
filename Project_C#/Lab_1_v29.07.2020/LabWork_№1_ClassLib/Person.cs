using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork__1_ClassLib
{
    /// <summary>
    /// Класс, описывающий персону
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string Surname { get; }

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender { get; }

        //TODO: RSDN
        /// <summary>
        /// Конструктор класса Person
        /// </summary>
        /// <param name="_surname"></param>
        /// <param name="_name"></param>
        /// <param name="_age"></param>
        /// <param name="_gen"></param>
        public Person(string _surname, string _name, int _age, Gender _gen)
        {
            Surname = _surname;
            //TODO: enumeration
            if (checkSurnameName(_surname) == 1 
                || checkSurnameName(_surname) == 2 
                || checkSurnameName(_surname) == 3)
            {
                throw new FormatException("Использованы недопустимые символы при вводе фамилии!");
            }

            Name = _name;
            if (checkSurnameName(_name) == 1 | checkSurnameName(_name) == 2 
                | checkSurnameName(_surname) == 3)
            {
                throw new FormatException("Использованы недопустимые символы при вводе имени!");
            }

            Age = _age;
            Gender = _gen; 
        }
        /// <summary>
        /// Метод для проверки соответствия строк заданным требованиям
        /// </summary>
        /// <param name="checkStroka"></param>
        private int checkSurnameName(string checkStroka)
        {
            char[] unnecСhar = { '~', '`', '!', '@', '"', '#', '$', ';',
                        '.', ':', ',', '?', '&', '?', '*', '(', ')', '_', '=', '+', '/'};
            char[] chisla = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            if (checkStroka.IndexOfAny(unnecСhar) != -1)
            {
                return 1;
            }
            if (checkStroka.IndexOf('-', 0, 1) != -1 | checkStroka.LastIndexOf('-', 0, 1) != -1)
            {
                return 2;
            }
            if (checkStroka.IndexOfAny(chisla, 0) != -1)
            {
                return 3;
            }
            return 0;
        }
    }
}
