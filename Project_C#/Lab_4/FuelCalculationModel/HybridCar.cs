using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Гибридный автомобиль
    /// </summary>
    [Serializable]
    public class HybridCar : VehiclesBase
    {
        /// <summary>
        /// Гибридный автомобиль
        /// </summary>
        /// <param name="name">Название гибридного автомобиля.</param>
        /// <param name="weight">Масса гибридного автомобиля, кг.</param>
        public HybridCar(string name, double weight)
        {
            Weight = weight;
            Type = VehiclesTypes.HybridCar;
            Name = name;
        }

        /// <summary>
        /// Конструктор по умолчанию гибридного автомобиля
        /// </summary>
        public HybridCar()
        {
            Type = VehiclesTypes.HybridCar;
        }

        /// <summary>
        /// Расчёт расхода топлива гибридного автомобиля
        /// </summary>
        /// <param name="distance">Проходимое расстояние</param>
        /// <returns>Расход топлива гибридного автомобиля</returns>
        public override double FuelCost()
        {
            return Distance * (Weight / 25000);
        }
    }
}
