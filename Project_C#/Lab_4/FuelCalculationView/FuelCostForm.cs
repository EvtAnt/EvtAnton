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

            textBoxFuelCostText.Text = string.Empty;
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
                if (!string.IsNullOrEmpty(textBoxDistance.Text))
                {
                    _setVehicle.Distance = Convert.ToDouble(textBoxDistance.Text);

                    textBoxFuelCostText.Text = $"{_setVehicle.Type} " +
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

        //TODO: Дубль +
        /// <summary>
        /// Проверка введённых символов в "TextBoxDistance"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            SharedServices.CheckCount(e);
        }
    }
}
