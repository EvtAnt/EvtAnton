using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LabWork_2_ClassLib;

namespace Lab_2_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
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

                switch(personList[3])
                {
                    case Adult adult:
                    {
                        Console.WriteLine("взрослый.");
                        Console.WriteLine(adult.AdultWork());
                        break;
                    }
                    case Child child:
                    {
                        Console.WriteLine("Ребёнок.");
                        Console.WriteLine(child.ChildRelax());
                        break;
                    }
                }

                Console.Write("\nПовторить? [y]: ");
                if (Console.ReadLine() != "y")
                {
                    return;
                }
            }
        }
    }
}
