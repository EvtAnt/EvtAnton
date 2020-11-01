using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Автомобиль с ДВС
    /// </summary>
    [Serializable]
    public class Car : VehiclesBase
    {
        /// <summary>
        /// Автомобиль с ДВС
        /// </summary>
        /// <param name="name">Название автомобиля с ДВС.</param>
        /// <param name="weight">Масса автомобиля с ДВС, кг.</param>
        public Car(string name, double weight)
        {
            Weight = weight;
            Type = VehiclesTypes.Car;
            Name = name;
        }

        /// <summary>
        /// Конструктор по умолчанию автомобиля с ДВС
        /// </summary>
        public Car()
        {
            Type = VehiclesTypes.Car;
        }

        /// <summary>
        /// Расчёт расхода топлива автомобиля с ДВС
        /// </summary>
        /// <param name="distance">Проходимое расстояние автомобилем с ДВС</param>
        /// <returns>Расход топлива автомобиля с ДВС</returns>
        public override double FuelCost()
        {
            return Distance * (Weight / 10000);
        }
    }
}
