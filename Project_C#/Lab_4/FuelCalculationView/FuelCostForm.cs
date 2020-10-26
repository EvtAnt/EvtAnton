using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelCalculationModel;

namespace FuelCalculationView
{
    /// <summary>
    /// Класс, описывающий форму для расчёта расхода топлива
    /// </summary>
    public partial class FuelCostForm : Form
    {
        /// <summary>
        /// Консруктор класса FuelCostForm
        /// </summary>
        /// <param name="vehicle"></param>
        public FuelCostForm(VehiclesBase vehicle)
        {
            InitializeComponent();

            _setVehicle = vehicle;

            TextBoxFuelCostText.Text = string.Empty;
        }

        /// <summary>
        /// Переданное транспортное средство с MainForm
        /// </summary>
        private VehiclesBase _setVehicle;

        /// <summary>
        /// Инициализация закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Расчёт расхода топлива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBoxDistance.Text))
                {
                    _setVehicle.Distance = Convert.ToDouble(TextBoxDistance.Text);

                    TextBoxFuelCostText.Text = $"{_setVehicle.Type} " +
                        $"{_setVehicle.Name} потратит " +
                        $"{_setVehicle.FuelCost()} л. топлива.";
                }
                else
                {
                    MessageBox.Show("Введите значение в поле {Расстояние, км}!");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверка введённых символов в "TextBoxDistance"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            var _enteredChar = e.KeyChar;
            
            // "e.KeyChar != 8" - код клавиши Backspace в таблице ASCII
            if (!Char.IsDigit(_enteredChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
