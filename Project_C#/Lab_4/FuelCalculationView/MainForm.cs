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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            InitializeDataGridColums();

            TestRow();
        }

        /// <summary>
        /// Список всех ТС в программе
        /// </summary>
        private List<VehiclesBase> _totalVehicleList 
            = new List<VehiclesBase> { };

        /// <summary>
        /// Обновляет содержимое DataGridViewMain содержимым vehicleList
        /// </summary>
        /// <param name="vehicleList">Источник данных для DataGridViewMain</param>
        private void RefreshDataGrid(List<VehiclesBase> vehicleList)
        {
            dataGridViewMain.Rows.Clear();
            foreach (var vehicle in vehicleList)
            {
                dataGridViewMain.Rows.Add(
                    vehicle.Type, 
                    vehicle.Name, 
                    vehicle.Weight);
            }
        }

        /// <summary>
        /// Задание колонок в DataGridView
        /// </summary>
        private void InitializeDataGridColums()
        {
            dataGridViewMain.Columns.Add("TypeVehicle", "Тип ТС");
            dataGridViewMain.Columns[0].Width = 70;

            dataGridViewMain.Columns.Add("NameVehicle", "Имя ТС");
            dataGridViewMain.Columns[1].Width = 80;

            dataGridViewMain.Columns.Add("WeightVehicle", "Масса ТС, кг");
            dataGridViewMain.Columns[2].Width = 100;

            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Кнопка Add Vehicle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.Show();
        }

        /// <summary>
        /// Добавление тестовых строк
        /// </summary>
        private void TestRow()
        {

            dataGridViewMain.Rows.Add(2);

            dataGridViewMain.Rows[0].Cells[0].Value = VehiclesTypes.Car;
            dataGridViewMain.Rows[0].Cells[1].Value = "BMW";
            dataGridViewMain.Rows[0].Cells[2].Value = 300;

            dataGridViewMain.Rows[1].Cells[0].Value = VehiclesTypes.Helicopter;
            dataGridViewMain.Rows[1].Cells[1].Value = "Raptor";
            dataGridViewMain.Rows[1].Cells[2].Value = 2000;
        }
    }
}
