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
        private Person[] _personList = new Person[0];

        /// <summary>
        /// Индексатор класса PersonList
        /// </summary>
        /// <param name="index">Индекс возвращаемой персоны</param>
        /// <returns></returns>
        public Person this[int index]
        {
            get => _personList[index];
        }

        /// <summary>
        /// Метод, осуществляющий добавление элемента в список
        /// </summary>
        /// <param name="person">Передаваемая персона с набором полей</param>
        public void AddPerson(Person person)
        {
            var personBuffer = _personList;

            // Переопределяем длинну массива для добавления новой персоны
            _personList = new Person[personBuffer.Length + 1]; 

            for (int i = 0; i < personBuffer.Length; i++)
            {
                _personList[i] = personBuffer[i];
            }

            _personList[personBuffer.Length] = person;
        }

        /// <summary>
        /// Метод, осуществляющий удаление элемента по индексу
        /// </summary>
        /// <param name="indexPerson">Индекс удаляемой персоны</param>
        public void DeletePersonByIndex(int indexPerson)
        {
            var personBuffer = _personList;

            _personList = new Person[personBuffer.Length - 1];
            
            int indexArrayPerson = 0;
            for (int i = 0; i < personBuffer.Length; i++)
            {
                if (indexPerson != i + 1)
                {
                    _personList[i - indexArrayPerson] = personBuffer[i];
                }
                else 
                { 
                    indexArrayPerson = 1; 
                }
            }
        }

        /// <summary>
        /// Свойство класса PersonList, возвращающее длину списка.
        /// </summary>
        public int Length
        {
            get { return _personList.Length; }
        }

        /// <summary>
        /// Метод, осуществляющий удаление элемента по фамилии.
        /// </summary>
        /// <param name="deleteSurname">Значение атрибута, по которому
        /// будет удаляться вся строка списка</param>
        public string DeletePersonBySurname(string deleteSurname)
        {
            int schetVhozdenii = 0;
            for (int i = 0; i < _personList.Length; i++)
            {
                if (_personList[i].Surname == deleteSurname)
                {
                    schetVhozdenii++;
                }
            }

            if (schetVhozdenii == 0)
            {
                return "<<< Искомая персона не наедена.";
            }

            var _personBuffer = _personList;
            _personList = new Person[_personBuffer.Length - schetVhozdenii];

            int indexArrayPerson = 0;
            for (int i = 0; i < _personBuffer.Length; i++)
            {
                if (_personBuffer[i].Surname != deleteSurname)
                {
                    _personList[i - indexArrayPerson] = _personBuffer[i];
                }
                else
                {
                    indexArrayPerson = 1;
                }
            }
            return null;
        }

        /// <summary>
        /// Метод, осуществляющий вывод индекса искомого элемента
        /// </summary>
        /// <param name="outputIndexSurname">Передаваемая строка "Фамилия"</param>
        public string OutputIndexSurname(string outputIndexSurname)
        {
            for (int i = 0; i < _personList.Length; i++)
            {
                if (_personList[i].Surname == outputIndexSurname)
                {
                    return "Индекс искомого элемента - " +
                        Convert.ToString(i + 1);
                }
                else
                {
                    return "Искомый элемент не найден";
                }
            }
            return "";
        }
        
        /// <summary>
        /// Метод, осуществляющий очистку списка
        /// </summary>
        public void Clear()
        {
            _personList = new Person[0];
        }
    }
}
