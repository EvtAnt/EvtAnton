using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LabWork_2_ClassLib;

namespace Lab_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            while (stop == false)
            {
                Console.Write("Генерация списка из 7 человек: ");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    Console.Write("*");
                }

                var personList = new PersonList();

                for (int i = 0; i < 7; i++)
                {
                    personList.AddPerson(RandomPerson.CreateRandomPerson());
                }

                Console.WriteLine("\nСписок успешно сгенерирован!\n\n");
                Console.WriteLine("Сгенериованный список: ");

                for (int i = 0; i < personList.Length; i++)
                {
                    Console.WriteLine($"№{i + 1} | {personList[i].InfoAboutPerson()}");
                }

                Console.Write("\nЧетвёртый человек в списке - ");

                if (personList[3] is Adult)
                {
                    Console.WriteLine("взрослый.");
                    var person = personList[3] as Adult;
                    Console.WriteLine(person.AdultWork());
                }
                else if (personList[3] is Child)
                {
                    Console.WriteLine("Ребёнок.");
                    var person = personList[3] as Child;
                    Console.WriteLine(person.ChildRelax());
                }

                Console.Write("\nПовторить? [y]: ");
                if (Console.ReadLine() != "y")
                {
                    stop = true;
                }
                //Console.ReadKey();
            }
        }
    }
}
