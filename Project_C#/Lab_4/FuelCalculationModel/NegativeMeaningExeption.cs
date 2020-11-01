using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalculationModel
{
    public class NegativeMeaningExeption : Exception
    {
        /// <summary>
        /// Ошибка при введении отрицательного значения
        /// </summary>
        /// <param name="meaning">Значение, которое должно быть >= 0</param>
        public NegativeMeaningExeption(string meaning)
            : base($"{meaning} не может иметь отрицательное значение!") { }
    }
}
