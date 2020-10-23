using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Класс, описывающий транспортное средство
    /// </summary>
    public abstract class VehiclesBase : IFuelCosts
    {
        /// <summary>
        /// Название ТС
        /// </summary>
        private string _name;

        /// <summary>
        /// Название ТС
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = (value != null && value.Replace(" ", "") != "")
                ? value : throw new Exception("Имя не может быть пустым! ");
        }

        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        public VehiclesTypes Type { get; set; }
            = VehiclesTypes.Undefined;

        /// <summary>
        /// Расстояние, которое необходимо преодолеть
        /// </summary>
        private double _distance;
        
        /// <summary>
        /// Расстояние, которое необходимо преодолеть
        /// </summary>
        public double Distance
        {
            get => _distance;
            set => _distance = (value >= 0) ? value :
                throw new NegativeMeaningExeption("Расстояние");
        }

        /// <summary>
        /// Масса ТС
        /// </summary>
        private double _weight;

        /// <summary>
        /// Масса ТС
        /// </summary>
        public double Weight
        {
            get => _weight;
            set => _weight = (value >= 0) ? value :
                throw new NegativeMeaningExeption("Масса ТС");
        }
      
        // Убрал *public abstract double FuelCost(double distance)*
        /// <summary>
        /// Расчёт затрачиваемого топлива
        /// </summary>
        /// <param name="distance">Расстояние, для которого рассчитывается расход топлива</param>
        /// <returns>Величина затрачиваемого топлива</returns>
        public abstract double FuelCost(); 
    }
}
