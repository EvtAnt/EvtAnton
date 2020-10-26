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
using System.Reflection;

namespace FuelCalculationView
{
    /// <summary>
    /// Класс, описывающий форму "AddVehicleForm"
    /// </summary>
    public partial class AddVehicleForm : Form
    {
        /// <summary>
        /// Конструктор класса "AddVehicleForm"
        /// </summary>
        /// <param name="vehicleList">Текущий список ТС</param>
        public AddVehicleForm(BindingList<VehiclesBase> vehicleList)
        {
            InitializeComponent();

            // Внесение в Combobox всех типов ТС из "enum VehiclesTypes"
            var vehicleTypes = Enum.GetNames(typeof(VehiclesTypes));
            for (int i = 0; i < vehicleTypes.Length; i++)
            { 
                comboBoxTypesOfVehicle.Items.Add(vehicleTypes[i]);
            }
                
            _totalVehicleList = vehicleList;
        }

        /// <summary>
        /// Полный список ТС
        /// </summary>
        private BindingList<VehiclesBase> _totalVehicleList;

        /// <summary>
        /// Добавление транспортного средства в DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(comboBoxTypesOfVehicle.Text))
                {
                    _totalVehicleList.Add(
                    CreateVehicleByString(
                        comboBoxTypesOfVehicle.Text,
                        CheckNameVehicle(textBoxNamesOfVehicle.Text),
                        textBoxWeightOfVehicle.Text));

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не указан тип ТС!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Создание ТС по строковым значениям
        /// </summary>
        /// <param name="type">Тип ТС</param>
        /// <param name="name">Название ТС</param>
        /// <param name="weight">Масса ТС в кг</param>
        /// <returns></returns>
        public static VehiclesBase CreateVehicleByString(string type, string name, string weight)
        {
            switch (type)
            {
                case nameof(Car):
                {
                    var car = new Car();
                    AddNameAndWeightVehicle(car, name, weight);
                    return car;
                }
                case nameof(HybridCar):
                {
                    var hybridCar = new HybridCar();
                    AddNameAndWeightVehicle(hybridCar, name, weight);
                    return hybridCar;
                }
                case nameof(Helicopter):
                {
                    var helicopter = new Helicopter();
                    AddNameAndWeightVehicle(helicopter, name, weight);
                    return helicopter;
                }
                default:
                {
                    throw new Exception("Не указан тип ТС!");
                }
            }
        }

        /// <summary>
        /// Добавление имени и массы ТС с проверкой заполнения
        /// текстовых полей в форме.
        /// </summary>
        /// <param name="vehicle">Транспортное средство</param>
        /// <param name="name">Имя ТС</param>
        /// <param name="weight">Масса ТС</param>
        private static void AddNameAndWeightVehicle(
            VehiclesBase vehicle, 
            string name, 
            string weight)
        {
            vehicle.Name = name;
            vehicle.Weight = (!string.IsNullOrEmpty(weight)) ? 
                Convert.ToDouble(weight) :
                throw new ArgumentException(
                    "Ошибка: Не указана масса ТС!");
        }

        /// <summary>
        /// Закрытие "AddVehicleForm"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Проверка введённых символов в textBox "vehicleWeight"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehicleWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// Метод для проверки соответствия строк заданным требованиям
        /// </summary>
        /// <param name="checkStroka">Строка, передаваемая на проверку</param>
        /// <returns>Проверенная строка или Exception</returns>
        private static string CheckNameVehicle(string checkStroka)
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
