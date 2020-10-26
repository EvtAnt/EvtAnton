using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelCalculationModel;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс ввода информации о ТС через консоль
    /// </summary>
    public static class GetInfo
    {
        /// <summary>
        /// Создание ТС
        /// </summary>
        /// <param name="vehiclesTypes">Тип ТС</param>
        /// <returns></returns>
        public static VehiclesBase CreateVehicle(VehiclesTypes vehiclesTypes)
        {
            Console.WriteLine($"Выбранный тип ТС - {vehiclesTypes}");

            Type typeVehicle = vehiclesTypes.GetClassByType();

            var vehicle = Activator.CreateInstance(typeVehicle) as VehiclesBase;

            SetName(vehicle);
            SetWeight(vehicle);
            SetDistance(vehicle);

            return vehicle;
        }

        /// <summary>
        /// Метод для ввода названия ТС
        /// </summary>
        /// <param name="vehicle">Транспортное средство</param>
        private static void SetName(VehiclesBase vehicle)
        {
            while (true)
            {
                try
                {
                    Console.Write("Название ТС: ");
                    vehicle.Name = Console.ReadLine();
                    CheckNameCar(vehicle.Name);
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }    
        }

        /// <summary>
        /// Метод для ввода массы ТС
        /// </summary>
        /// <param name="vehicle">Транспортное средство</param>
        private static void SetWeight(VehiclesBase vehicle)
        {
            while (true)
            {
                try
                {
                    Console.Write("Масса, кг: ");
                    vehicle.Weight = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\t>>> {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Метод для ввода дистанции
        /// </summary>
        /// <param name="vehicle">Транспортное средство</param>
        private static void SetDistance(VehiclesBase vehicle)
        {
            while (true)
            {
                try
                {
                    Console.Write("Дистанция, км: ");
                    vehicle.Distance = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\t>>> {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Метод для проверки соответствия строк заданным требованиям
        /// </summary>
        /// <param name="checkStroka">Строка, передаваемая на проверку</param>
        private static void CheckNameCar(string checkStroka)
        {
            char[] unnecСhar = { '~', '`', '!', '@', '"', '#', '$', ';',
                '.', ':', ',', '?', '&', '?', '*', '(', ')', '_', '=',
                '+', '/'};

            if (checkStroka.IndexOfAny(unnecСhar) != -1 ||
                checkStroka.IndexOf('-', 0, 1) != -1 ||
                checkStroka.LastIndexOf('-', 0, 1) != -1)
            {
                throw new FormatException("\t>>> Использованы недопустимые " +
                                            "символы при вводе имени ТС!");
            }
        }
    }
}
