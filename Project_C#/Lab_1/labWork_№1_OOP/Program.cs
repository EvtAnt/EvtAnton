using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork__1_ClassLib;
using System.Globalization;

namespace labWork__1_OOP
{
    /// <summary>
    /// Класс, с которого начинается выполнение программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа для выполняемой программы
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var spisokOne = new PersonList();
            var spisokTwo = new PersonList();

            NapolnenieSpiska(spisokOne);
            NapolnenieSpiska(spisokTwo);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("1 - Выбрать список №1");
                Console.WriteLine("2 - Выбрать список №2");
                try
                {
                    int caseSwitch = Int32.Parse(Console.ReadLine());
                    int numberSpisok;
                    switch (caseSwitch)
                    {
                        case 1:
                            numberSpisok = 1;
                            ProcessSelectedList(spisokOne, 
                                spisokTwo,
                                numberSpisok);
                            break;

                        case 2:
                            numberSpisok = 2;
                            ProcessSelectedList(spisokTwo,
                                spisokOne,
                                numberSpisok);
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Ошибка: введено не числовое значение!");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Метод, предоставляющий инструмент обработки выбранного списка
        /// </summary>
        /// <param name="selectedSpisok">Обрабатываемый список</param>
        /// <param name="secondSpisok">Второй список</param>
        /// <param name="numberSpisok">Номер выбранного списка</param>
        public static void ProcessSelectedList (PersonList selectedSpisok,
                                                PersonList secondSpisok,
                                                int numberSpisok)
        {
            Console.WriteLine($"Выбран список №{numberSpisok}");

            Console.WriteLine("0 - Осуществить перенос персоны в другой список");
            Console.WriteLine("1 - Добавить персону в список");
            Console.WriteLine("2 - Удалить персону из списка по индексу");
            Console.WriteLine("3 - Вывести список персон");
            Console.WriteLine("4 - Поиск элемента по индексу");
            Console.WriteLine("5 - Удалить персону по фамилии");
            Console.WriteLine("6 - Вывод индекса элемента (фамилия)");
            Console.WriteLine("7 - Вывод количества элементов в списке");
            Console.WriteLine("8 - Очистить список");

            int caseSwitch = 0;
            try
            {
                caseSwitch = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка: введено не числовое значение!");
                Console.ReadKey();
            }

            switch (caseSwitch)
            {
                case 0:
                    try
                    {
                        Console.Write("Введите индекс переносимой персоны: ");
                        int indexPersonTransfer = Int32.Parse(Console.ReadLine());
                        CaseSwitchPersonTransfer(selectedSpisok,
                                                 secondSpisok,
                                                 indexPersonTransfer);
                    }
                    catch
                    {
                        Console.Write("Использовано не число!");
                        Console.ReadKey();
                    }
                    break;

                case 1:
                    CaseSwitchAddPerson(selectedSpisok);
                    break;

                case 2:
                    CaseSwitchDeletePersonToIndex(selectedSpisok);
                    break;
                case 3:
                    if (selectedSpisok.Length != 0)
                    {
                        for (int i = 1; i < selectedSpisok.Length + 1; i++)
                        {
                            PrintPerson(selectedSpisok[i - 1], i);
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Список пуст.");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    CaseSwitchFindElementToIndex(selectedSpisok);
                    break;

                case 5:
                    CaseSwitchDeletePerson(selectedSpisok);
                    break;

                case 6:
                    CaseSwitchOutputIndexSurname(selectedSpisok);
                    break;

                case 7:
                    Console.WriteLine("Список состоит из " +
                        $"{selectedSpisok.Length} элементов.");
                    Console.ReadKey();
                    break;
                
                case 8:
                    selectedSpisok.Clear();
                    break;
            }
        }

        /// <summary>
        /// Метод, осуществляющий копирование персоны из одного списка в другой
        /// </summary>
        /// <param name="selectedSpisok">Список, из которого копируется персона</param>
        /// <param name="secondSpisok">Список, в который копируется персона</param>
        /// <param name="indexPersonTransfer">Индекс копируемой персоны</param>
        public static void CaseSwitchPersonTransfer(PersonList selectedSpisok,
                                                    PersonList secondSpisok,
                                                    int indexPersonTransfer)
        {
            if (indexPersonTransfer == 0)
            {
                Console.WriteLine("Нумерация списка начинается с '1', " +
                                    "попробуйте ещё раз.");
                Console.ReadKey();
            }

            else if (selectedSpisok.Length >= indexPersonTransfer)
            {
                //Person personTransfer = selectedSpisok[indexPersonTransfer];

                Person newPersonToSecondSpisok = new Person(
                    selectedSpisok[indexPersonTransfer - 1].Surname,
                    selectedSpisok[indexPersonTransfer - 1].Name,
                    selectedSpisok[indexPersonTransfer - 1].Age,
                    selectedSpisok[indexPersonTransfer - 1].Gender);

                secondSpisok.AddPerson(newPersonToSecondSpisok);

                Console.WriteLine("\t>>> Персона успешно перенесена в " +
                    "другой список.");

                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Копирование невозможно: отсутствует " +
                                    "требуемый элемент списка.");
                Console.ReadKey();
            }
        }
       
        /// <summary>
        /// Метод, осуществляющий вывод персоны в консоль
        /// </summary>
        /// <param name="list">Передаваемый список</param>
        /// <param name="indexPerson">Индекс персоны в списке</param>
        public static void PrintPerson(Person person, int indexPerson)
        {
            Console.WriteLine($"№{indexPerson} |" +
                                $" Фамилия: {person.Surname} |" +
                                $" Имя: {person.Name} |" +
                                $" Возраст: {person.Age} |" +
                                $" Пол: {person.Gender}");
        }

        //RSDN
        public static void NameEnter(Action action, string enteringInstance)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите {enteringInstance}: ");
                    action.Invoke();
                    Console.WriteLine($"\t>>> {enteringInstance} успешно добавлена.");
                    Console.WriteLine();
                    break;
                }
                catch (Exception exception)
                {
                    if (exception is FormatException)
                    {
                        Console.WriteLine($"{exception.Message} {enteringInstance}!");
                        Console.ReadKey();
                    }
                }
            }
        }

        /// <summary>
        /// Метод, используемый в caseswitch, для добавление персоны в список
        /// </summary>
        /// <param name="spisok"></param>
        public static void CaseSwitchAddPerson(PersonList spisok)
        {
            var person = new Person();
            NameEnter(() => {person.Surname = Console.ReadLine();}, "фамилию");
            NameEnter(() => {person.Name = Console.ReadLine();}, "имя");

            #region Ввод возраста
            while (true)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    person.Age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\t>>> Возраст успешно добавлен.");
                    Console.WriteLine();
                    break;
                }
                catch (ArgumentOutOfRangeException age)
                {
                    Console.WriteLine($"{age.Message}");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Ошибка: при вводе возраста было " +
                        "введено не числовое значение!");
                }                
            }
            #endregion

            #region Ввод пола
            while (true)
            {
                try 
                {
                    Console.WriteLine("Введите пол: 1 - Male | 2 - Female");

                    int genderIndex = Int32.Parse(Console.ReadLine());

                    if (genderIndex != 1 & genderIndex != 2)
                    {
                        Console.WriteLine("Неверный ввод! Попробуйте снова.");
                        continue;
                    }

                    else
                    {
                        switch (genderIndex)
                        {
                            case 1:
                                person.Gender = Gender.Male;
                                Console.WriteLine("\t>>> Пол успешно добавлен.");
                                Console.WriteLine();
                                break;
                            case 2:
                                person.Gender = Gender.Female;
                                Console.WriteLine("\t>>> Пол успешно добавлен.");
                                Console.WriteLine();
                                break;
                        }
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка, введены не числа!");
                    Console.ReadKey();
                }
            }
            #endregion

            spisok.AddPerson(person);
            Console.WriteLine("\t>>> Персона успешно добавлена в список.");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, используемый в caseswitch, для удаления персоны из списка по индексу.
        /// </summary>
        public static void CaseSwitchDeletePersonToIndex(PersonList spisok)
        {
            try
            {
                Console.Write("Введите индекс персоны: ");
                int indexPerson = Int32.Parse(Console.ReadLine());
                if (indexPerson > 0)
                {
                    spisok.DeletePersonByIndex(indexPerson);
                    Console.WriteLine("\t>>> Персона успешно удалена из списка.");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Нумерация списка начинается с '1', " +
                                    "попробуйте ещё раз");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: введено не числовое значение!");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод, используемый в caseswitch, для поиска элемента по индексу
        /// </summary>
        /// <param name="spisok">Список, из которого удаляется персона</param>
        public static void CaseSwitchFindElementToIndex(PersonList spisok)
        {
            try
            {
                Console.Write("Введите индекс для поиска: ");
                int indexPerson = Int32.Parse(Console.ReadLine());
                if (indexPerson <= 0)
                {
                    Console.WriteLine("Ошибка: список нумеруется с '1'.");
                    Console.ReadKey();
                }
                else if (spisok.Length >= indexPerson)
                {
                    //В ОТДЕЛЬНЫЙ МЕТОД
                    PrintPerson(spisok[indexPerson - 1], indexPerson);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ошибка: список имеет длину " +
                                $"{spisok.Length}.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: введено не числовое значение!");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод, используемый в caseswitch, для удаление элементов по фамилии
        /// </summary>
        /// <param name="spisok">Список, из которого удалают персону</param>
        public static void CaseSwitchDeletePerson(PersonList spisok)
        {
            Console.Write("Введите фамилию для удаления: ");
            string Surname = Console.ReadLine();
            if (spisok.DeletePersonBySurname(Surname) == null)
            {
                Console.WriteLine("\t>>> Персона успешно удалена из списка.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\t{spisok.DeletePersonBySurname(Surname)}");
                Console.ReadKey();
            }          
        }

        /// <summary>
        /// Метод, используемый в caseswitch, для вывода индекса искомого элемента
        /// </summary>
        /// <param name="spisok">Список, в котором производится поиск</param>
        public static void CaseSwitchOutputIndexSurname(PersonList spisok)
        {
            Console.Write("Введите фамилию для проверки индекса: ");
            string Surname = Console.ReadLine();
            Console.WriteLine(spisok.OutputIndexSurname(Surname));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, для наполнения списка (тест)
        /// </summary>
        /// <param name="spisok">Передаваемый список</param>
        public static void NapolnenieSpiska(PersonList spisok)
        {
            Person personOne = new Person("Евтушенко", "Антон", 24, Gender.Male);
            Person personTwo = new Person("Аксёнов", "Алексей", 33, Gender.Male);
            Person personThree = new Person("Локтеева", "Анна", 12, Gender.Female);
            spisok.AddPerson(personOne);
            spisok.AddPerson(personTwo);
            spisok.AddPerson(personThree);
        }
    }
}
