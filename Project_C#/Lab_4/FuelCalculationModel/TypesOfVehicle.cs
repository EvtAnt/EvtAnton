using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Типы ТС
    /// </summary>
    public enum VehiclesTypes
    {
        Car,
        HybridCar,
        Helicopter
    }

    public static class TypesOfVehicles
    {
        /// <summary>
        /// Получение класса ТС по его типу
        /// </summary>
        /// <param name="vehiclesTypes">Тип ТС, согласно набору VehiclesTypes</param>
        /// <returns></returns>
        public static Type GetClassByType(this VehiclesTypes vehiclesTypes)
        {
            switch (vehiclesTypes)
            {
                case VehiclesTypes.Car:
                    return typeof(Car);

                case VehiclesTypes.HybridCar:
                    return typeof(HybridCar);

                case VehiclesTypes.Helicopter:
                    return typeof(Helicopter);

                default:
                    throw new ArgumentException("Передан несуществующий тип ТС!");
            }
        }
    }
}
