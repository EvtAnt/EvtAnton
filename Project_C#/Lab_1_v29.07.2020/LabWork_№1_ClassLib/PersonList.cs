using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork__1_ClassLib
{
    /// <summary>
    /// Класс, реализующий методы взаимодействия со списком элементов
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Объявление экземпляра класса Person
        /// </summary>
        private Person[] _person = new Person[0];

        /// <summary>
        /// Метод, осуществляющий добавление элемента в список
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            //TODO: RSDN
            var _personBuffer = _person;

            // для переопределения длины массива Person
            _person = new Person[_personBuffer.Length + 1]; 

            for (int i = 0; i < _personBuffer.Length; i++)
            {
                _person[i] = _personBuffer[i];
            }

            _person[_personBuffer.Length] = person;
        }

        /// <summary>
        /// Метод, осуществляющий удаление элемента по индексу
        /// </summary>
        /// <param name="indexPerson">Индекс удаляемой персоны</param>
        public void DellPersonIndex(int indexPerson)
        {
            //TODO: RSDN
            var _personBuffer = _person;

            _person = new Person[_personBuffer.Length - 1];
            
            int indexArrayPerson = 0;
            for (int i = 0; i < _personBuffer.Length; i++)
            {
                if (indexPerson != i + 1)
                {
                    _person[i - indexArrayPerson] = _personBuffer[i];
                }
                else { indexArrayPerson = 1; }
            }
        }

        /// <summary>
        /// Метод, осуществляющий вывод списка элементов в консоль
        /// </summary>
        public void CheckSpisok()
        {
            if (_person.Length == 0)
            {
                Console.WriteLine("Список пуст.");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < _person.Length; i++)
            {
                //TODO: RSDN
                Console.WriteLine($"№{i + 1} |" +
                                  $" Фамилия: {_person[i].Surname} |" +
                                  $" Имя: {_person[i].Name} |" +
                                  $" Возраст: {_person[i].Age} |" +
                                  $" Пол: {_person[i].Gender}");
            }
        }
        /// <summary>
        /// Метод, осуществляющий вывод элемента списка по индексу
        /// </summary>
        public void CheckPersona(int indexPerson)
        {
            try
            {
                //TODO: Сделать проверку на границы 
                // просто if а не try catch
                Console.WriteLine($"№{indexPerson} | Фамилия: {_person[indexPerson - 1].Surname} | Имя: {_person[indexPerson - 1].Name} | " +
                    $"Возраст: {_person[indexPerson - 1].Age} | Пол: {_person[indexPerson - 1].Gender}");
                Console.ReadKey();
            }
            catch 
            {
                Console.WriteLine("В списке отсутствует искомый элемент.");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Метод, осуществляющий удаление элемента по фамилии
        /// </summary>
        /// <param name="dellSurname">Значение атрибута, по которому
        /// будет удаляться вся строка списка</param>
        public void DellPerson(string dellSurname)
        {
            int schetVhozdenii = 0;
            for (int i = 0; i < _person.Length; i++)
            {
                if (_person[i].Surname == dellSurname)
                {
                    schetVhozdenii++;
                }
            }

            var _personBuffer = _person;
            _person = new Person[_personBuffer.Length - schetVhozdenii];

            int indexArrayPerson = 0;
            for (int i = 0; i < _personBuffer.Length; i++)
            {
                if (_personBuffer[i].Surname != dellSurname)
                {
                    _person[i - indexArrayPerson] = _personBuffer[i];
                }
                else
                {
                    indexArrayPerson = 1;
                }
            }
        }

        /// <summary>
        /// Метод, осуществляющий вывод индекса искомого элемента
        /// </summary>
        /// <param name="checkSurnameIndex">Передаваемая строка "Фамилия"</param>
        public void СheckIndexSurname(string checkSurnameIndex)
        {
            for (int i = 0; i < _person.Length; i++)
            {
                if (_person[i].Surname == checkSurnameIndex)
                {
                    Console.WriteLine($"Индекс {i+1}");
                }
                else
                {
                    Console.WriteLine("Индекс не найден.");
                }
                Console.ReadKey();
            }
        }

        //TODO: RSDN
        /// <summary>
        /// Метод, осуществляющий вывод длины списка
        /// </summary>
        public void ChecklengthSpisok()
        {
            Console.WriteLine($"Список состоит из {_person.Length} элементов.");
            Console.ReadKey();
        }

        //TODO: RSDN
        /// <summary>
        /// Метод, осуществляющий очистку списка
        /// </summary>
        public void ClearSpisok()
        {
            _person = new Person[0];
        }

    }
}
