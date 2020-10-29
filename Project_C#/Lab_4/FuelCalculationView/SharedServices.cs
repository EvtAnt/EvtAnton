using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelCalculationModel;

namespace FuelCalculationView
{
    /// <summary>
    /// Класс, описывающий общие методы
    /// </summary>
    public class SharedServices
    {
        /// <summary>
        /// Метод динамической обработки символов, вводимых в textBox
        /// </summary>
        /// <param name="argument">Вводимый символ</param>
        public static void CheckCount(KeyPressEventArgs argument)
        {
            const int backspaceASCIICode = 8;

            if (!Char.IsDigit(argument.KeyChar) &&
                argument.KeyChar != ',' &&
                argument.KeyChar != backspaceASCIICode)
            {
                argument.Handled = true;
            }
        }

        /// <summary>
        /// Метод для проверки соответствия строк заданным требованиям
        /// </summary>
        /// <param name="checkStroka">Строка, передаваемая на проверку</param>
        /// <returns>Проверенная строка или Exception</returns>
        public static string CheckNameVehicle(string checkStroka)
        {
            char[] unnecСhar = { '~', '`', '!', '@', '"', '#', '$', ';',
                '.', ':', ',', '?', '&', '?', '*', '(', ')', '_', '=',
                '+', '/' };

            if (string.IsNullOrEmpty(checkStroka) || checkStroka == " ")
            {
                throw new ArgumentException("Ошибка: не указано имя ТС!");
            }
            else if (checkStroka.IndexOfAny(unnecСhar) != -1 ||
                checkStroka.IndexOf('-', 0, 1) != -1 ||
                checkStroka.LastIndexOf('-', 0, 1) != -1)
            {
                throw new FormatException("Использованы недопустимые " +
                                            "символы при вводе имени ТС!");
            }

            return checkStroka;
        }
    }
}
