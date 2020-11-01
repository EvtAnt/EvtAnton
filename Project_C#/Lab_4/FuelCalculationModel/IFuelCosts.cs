using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Интерфейс для получения расхода топлива транспортного средства
    /// </summary>
    public interface IFuelCosts
    {
        /// <summary>
        /// Преодолеваемое расстояние
        /// </summary>
        double Distance { get; set; }

        /// <summary>
        /// Расход топлива
        /// </summary>
        /// <param name="distance">Проходимая дистанция</param>
        /// <returns></returns>
        double FuelCost();
    }
}
