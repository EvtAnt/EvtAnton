using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Вертолёт
    /// </summary>
    [Serializable]
    public class Helicopter : VehiclesBase
    {
        /// <summary>
        /// Вертолёт
        /// </summary>
        /// <param name="name">Название вертолёта.</param>
        /// <param name="weight">Масса вертолёта, кг.</param>
        public Helicopter(string name, double weight)
        {
            Weight = weight;
            Type = VehiclesTypes.HybridCar;
            Name = name;
        }

        /// <summary>
        /// Конструктор по умолчанию вертолёта
        /// </summary>
        public Helicopter()
        {
            Type = VehiclesTypes.Helicopter;
        }

        /// <summary>
        /// Расчёт расхода топлива вертолёта
        /// </summary>
        /// <param name="distance">Расстояние, проходимое вертолётом</param>
        /// <returns>Расход топлива вертолёта</returns>
        public override double FuelCost()
        {
            return Distance * (Weight / 3000);
        }
    }
}
