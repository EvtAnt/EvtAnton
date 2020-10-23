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
    //TODO: RSDN
    /// <summary>
    /// Класс, с которого начинается выполнение программы
    /// </summary>
    class Program
    {
        //TODO: RSDN
        /// <summary>
        /// Точка входа для выполняемо программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            var spisok = new PersonList();
            while (true)
            {
                Console.Clear();

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
                    case 1:
                        CaseSwitchAddPerson(spisok);
                        break;

                    case 2:
                        CaseSwitchDellPersonIndex(spisok);
                        break;
                    case 3:
                        spisok.CheckSpisok();
                        Console.ReadKey();
                        break;

                    case 4:
                        CaseSwitchFindElementToIndex(spisok);
                        break;

                    case 5:
                        CaseSwitchDellPerson(spisok);
                        break;

                    case 6:
                        CaseSwitchСheckIndexSurname(spisok);
                        break;

                    case 7:
                        spisok.checklengthSpisok();
                        break;

                    case 8:
                        spisok.clearSpisok();
                        break;
                }
            }
        }
        /// <summary>
        /// Метод, используемый в caseswitch, для добавление персоны в список
        /// </summary>
        /// <param name="spisok"></param>
        public static void CaseSwitchAddPerson(PersonList spisok)
        {
            string surname = "";
            string name = "";
            int age;
            Gender gen = Gender.Male;

            #region Ввод фамилии
            try
            {
                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Что то пошло не так при вводе фамилии...");
                //continue;
            }
            #endregion

            #region Ввод имени
            try
            {
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Что то пошло не так при вводе имени...");
                //continue;
            }
            #endregion

            #region Ввод возраста
            while (true)
            {
                try
                {
                    Console.Write("Введите возраст: ");
                    age = Int32.Parse(Console.ReadLine());
                    if (age < 0)
                    {
                        throw new ArgumentOutOfRangeException("Ошибка: " +
                            "Возраст отрицательный!");
                    }
                    break;
                }
                catch (ArgumentOutOfRangeException Age)
                {
                    Console.WriteLine("Ошибка: Возраст отрицательный!");
                }
                catch
                {
                    Console.WriteLine("Ошибка: Ввод текста!");
                }
            }
            #endregion

            #region Ввод пола
            //Console.Write("Введите пол: ");
            //gen = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Введите пол: 1 - Male | 2 - Female");
                try
                {
                    int genderIndex = Int32.Parse(Console.ReadLine());
                    if (genderIndex != 1 & genderIndex != 2)
                    {
                        Console.WriteLine("Ошибка: индекс лежит " +
                            "вне допустимого диапазона!");
                        continue;
                    }
                    switch (genderIndex)
                    {
                        case 1:
                            gen = Gender.Male;
                            break;
                        case 2:
                            gen = Gender.Female;
                            break;
                    }
                    break;
                }
                catch { Console.WriteLine("Неверный ввод, попробуйте снова."); }
            }
            #endregion

            try
            {
                var person = new Person(surname, name, age, gen);
                spisok.AddPerson(person);
            }
            catch (FormatException nameSurname)
            {
                Console.WriteLine($"{nameSurname.Message}");
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException Age)
            {
                Console.WriteLine($"{Age.Message}");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Метод, используемый в caseswitch, для удаления персоны из списка по индексу
        /// </summary>
        public static void CaseSwitchDellPersonIndex(PersonList spisok)
        {
            try
            {
                Console.Write("Введите индекс персоны: ");
                int indexPerson = Int32.Parse(Console.ReadLine());
                spisok.DellPersonIndex(indexPerson);
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
        /// <param name="spisok"></param>
        public static void CaseSwitchFindElementToIndex(PersonList spisok)
        {
            try
            {
                Console.WriteLine("Введите индекс для поиска: ");
                spisok.CheckPersona(Int32.Parse(Console.ReadLine()));
                Console.ReadKey();
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
        /// <param name="spisok"></param>
        public static void CaseSwitchDellPerson(PersonList spisok)
        {
            try
            {
                Console.Write("Введите фамилию для удаления: ");
                string Surname = Console.ReadLine();
                spisok.DellPerson(Surname);
            }
            catch
            {
                Console.WriteLine("Что то пошло не так:(");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Метод, используемый в caseswitch, для вывода индекса искомого элемента
        /// </summary>
        /// <param name="spisok"></param>
        public static void CaseSwitchСheckIndexSurname(PersonList spisok)
        {
            try
            {
                Console.Write("Введите фамилию для проверки индекса: ");
                string Surname = Console.ReadLine();
                spisok.СheckIndexSurname(Surname);
            }
            catch
            {
                Console.WriteLine("Что то пошло не так:(");
                Console.ReadKey();
            }
        }

    }

}
