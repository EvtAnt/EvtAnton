﻿using System;
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

            comboBoxTypesOfVehicle.Items.AddRange(Enum.GetNames(typeof(VehiclesTypes)));
                
            _totalVehicleList = vehicleList;
        }

        /// <summary>
        /// Полный список ТС
        /// </summary>
        private BindingList<VehiclesBase> _totalVehicleList;

        /// <summary>
        /// Кнопка добавления транспортного средства в dataGridView
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
                        SharedServices.CheckNameVehicle(textBoxNamesOfVehicle.Text),
                        textBoxWeightOfVehicle.Text.Replace('.', ',')));

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vehicle type not specified!");
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
        private VehiclesBase CreateVehicleByString(string type, string name, string weight)
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
                    throw new Exception("Unexpected error in method " +
                        "CreateVehicleByString (default)");
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
        private void AddNameAndWeightVehicle(
            VehiclesBase vehicle, 
            string name, 
            string weight)
        {
            vehicle.Name = name;
            vehicle.Weight = 
                !string.IsNullOrEmpty(weight) 
                    ? Convert.ToDouble(weight) 
                    : throw new ArgumentException("Error: vehicle weight not specified!");
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
        private void VehicleWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            SharedServices.CheckCount(e, textBoxWeightOfVehicle.Text);
        }
    }
}
