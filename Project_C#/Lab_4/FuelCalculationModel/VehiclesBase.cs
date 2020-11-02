﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    /// <summary>
    /// Класс, описывающий транспортное средство
    /// </summary>
    [Serializable]
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
                ? value : throw new Exception("The name cannot be empty!");
        }

        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        public VehiclesTypes Type { get; set; }

        /// <summary>
        /// Расстояние, которое необходимо преодолеть
        /// </summary>
        private double _distance;

        [Browsable(false)]
        /// <summary>
        /// Расстояние, которое необходимо преодолеть
        /// </summary>
        public double Distance
        {
            get => _distance;
            set => _distance = (value >= 0) ? value :
                throw new NegativeMeaningExeption("Distance");
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
                throw new NegativeMeaningExeption("Vehicle weight");
        }
      
        /// <summary>
        /// Расчёт затрачиваемого топлива
        /// </summary>
        /// <param name="distance">Расстояние, для которого рассчитывается расход топлива</param>
        /// <returns>Величина затрачиваемого топлива</returns>
        public abstract double FuelCost(); 
    }
}
