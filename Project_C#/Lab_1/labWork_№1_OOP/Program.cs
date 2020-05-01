using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork__1_ClassLib;

namespace labWork__1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            
            var spisok = new PersonList();

            Console.Write("Введите Фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите пол: ");
            string gen = Gender(Console.ReadLine());

            var person = new Person(surname, name, age, gen);

            spisok.addPerson(person);
        }
        
    }
}
