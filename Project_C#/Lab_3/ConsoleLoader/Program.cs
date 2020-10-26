using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelCalculationModel;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс, описывающий программу
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("***Запуск тестирования бизнес логики.***\n\n" +
                    "Выберите выполняемое действие:\n" +
                    "1 - Расчёт расхода топливаy автомобиля с ДВС.\n" +
                    "2 - Расчёт расхода топлива гибридного автомобиля.\n" +
                    "3 - Расчёт расхода топлива вертолёта.\n");

                int caseSwitch;

                try
                {
                    caseSwitch = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                

                IFuelCosts vehicle;
                switch (caseSwitch)
                {
                    case 1:
                        vehicle = GetInfo.CreateVehicle(VehiclesTypes.Car);
                        break;

                    case 2:
                        vehicle = GetInfo.CreateVehicle(VehiclesTypes.HybridCar);
                        break;

                    case 3:
                        vehicle = GetInfo.CreateVehicle(VehiclesTypes.Helicopter);
                        break;

                    default:
                        return;
                }

                Console.WriteLine($"\nДля {(vehicle as VehiclesBase).Type} " +
                    $"{(vehicle as VehiclesBase).Name} " +
                    $"на {vehicle.Distance} км потребуется " +
                    $"{vehicle.FuelCost()} литров топлива.");
                Console.WriteLine("\nНажмите любую кнопку");
                Console.ReadKey();
            }
        }
    }
}
