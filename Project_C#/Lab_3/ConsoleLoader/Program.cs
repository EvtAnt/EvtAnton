using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelCalculationModel;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IFuelCosts vehicle;

                Console.Clear();

                Console.WriteLine("***Запуск тестирования бизнес логики.***\n\n" +
                    "Выберите выполняемое действие:\n" +
                    "1 - Расчёт расхода топлива автомобиля с ДВС.\n" +
                    "2 - Расчёт расхода топлива гибридного автомобиля.\n" +
                    "3 - Расчёт расхода топлива вертолёта.\n");

                int caseSwitch = Int32.Parse(Console.ReadLine());

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

        /// <summary>
        /// Расчёт расхода топлива для автомобиля с ДВС
        /// </summary>
        public static void CarFuelCost()
        {
            var car = new Car();
        
            Console.Write("Введите название автомобиля: ");
            car.Name = Console.ReadLine();
        
            Console.Write("\nВведите массу автомобиля: ");
            car.Weight = Double.Parse(Console.ReadLine());
        
            Console.Write("\nВведите расстояние, которое нужно преодолеть автомобилю: ");
            car.Distance = Double.Parse(Console.ReadLine());
        
            Console.WriteLine($"{car.Type} {car.Name} потратит {car.FuelCost()} л. " +
                $"топлива для прохождения {car.Distance} км.");
        
            Console.ReadKey();
        }

        /// <summary>
        /// Расчёт расхода топлива для гибридного автомобиля
        /// </summary>
        public static void HybridCarFuelCost()
        {
            var hybridCar = new HybridCar();

            Console.Write("Введите название автомобиля: \n");
            hybridCar.Name = Console.ReadLine();

            Console.Write("Введите массу автомобиля: \n");
            hybridCar.Weight = Double.Parse(Console.ReadLine());

            Console.Write("Введите расстояние, которое нужно преодолеть автомобилю: \n");
            hybridCar.Distance = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{hybridCar.Type} {hybridCar.Name} " +
                $"потратит {hybridCar.FuelCost()} л. " +
                $"топлива для прохождения {hybridCar.Distance} км.");

            Console.ReadKey();
        }

        /// <summary>
        /// Расчёт расхода топлива для вертолёта
        /// </summary>
        public static void HelicopterFuelCost()
        {
            var helicopter = new Helicopter();

            Console.Write("Введите название автомобиля: \n");
            helicopter.Name = Console.ReadLine();

            Console.Write("Введите массу автомобиля: \n");
            helicopter.Weight = Double.Parse(Console.ReadLine());

            Console.Write("Введите расстояние, которое нужно преодолеть автомобилю: \n");
            helicopter.Distance = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{helicopter.Type} {helicopter.Name} " +
                $"потратит {helicopter.FuelCost()} л. " +
                $"топлива для прохождения {helicopter.Distance} км.");

            Console.ReadKey();
        }
    }
}
