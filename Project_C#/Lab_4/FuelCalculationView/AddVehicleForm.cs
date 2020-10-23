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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();

            // Внесение в Combobox всех типов ТС из "enum VehiclesTypes"
            var vehicleTypes = Enum.GetNames(typeof(VehiclesTypes));
            for(int i = 0; i < vehicleTypes.Length; i++)
                comboBoxTypesOfVehicle.Items.Add(vehicleTypes[i]);           
        }

        /// <summary>
        /// Полный список ТС
        /// </summary>
        private List<VehiclesBase> _totalVehicleList;

        /// <summary>
        /// Конструктор с ссылкой на главную форму и полный список ТС
        /// </summary>
        /// <param name="totalVehicleList"></param>
        public AddVehicleForm(List<VehiclesBase> totalVehicleList)
            : this()
        {
            _totalVehicleList = totalVehicleList;
        }

        /// <summary>
        /// Добавление транспортного средства в DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            _totalVehicleList.Add(
                CreateVehicleByString(
                    comboBoxTypesOfVehicle.Text, 
                    textBoxNamesOfVehicle.Text, 
                    textBoxWeightOfVehicle.Text));


            this.Close();
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
            Type typeClass = null;

            switch (type)
            {
                case nameof(Car):
                    {
                        //typeClass = typeof(Car);
                        Car car = new Car();
                        car.Name = name;
                        car.Weight = Convert.ToDouble(weight);
                        return car;
                        break;
                    }
                //case nameof(HybridCar):
                //    {
                //        //typeClass = typeof(HybridCar);
                //        break;
                //    }
                //case nameof(Helicopter):
                //    {
                //        //typeClass = typeof(Helicopter);
                //        break;
                //    }
                default:
                    {
                        throw new Exception("Не указан тип ТС!");
                    }
            }

            //VehiclesBase veh = new VehiclesBase();

            //ConstructorInfo paramCons = typeClass.GetConstructor(
            //    new Type[] { typeof(string), typeof(double) });
            //
            //return (VehiclesBase)paramCons.Invoke(new object[] { name, Convert.ToDouble(weight) });
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
            char _enteredChar = e.KeyChar;

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
