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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace FuelCalculationView
{
    /// <summary>
    /// Класс, описывающий основную форму
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            dataGridViewMain.DataSource = _totalVehicleList;

           dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Список всех ТС в программе
        /// </summary>
        private BindingList<VehiclesBase> _totalVehicleList
            = new BindingList<VehiclesBase>();

        #region Кнопки

        /// <summary>
        /// Кнопка добавления транспортных средств
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVehicle_Click(object sender, EventArgs e)
        {
            var addVehicleForm 
                = new AddVehicleForm(_totalVehicleList).ShowDialog();
        }

        /// <summary>
        /// Кнопка для удаления выделенных строк в dataGridViewMain
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteVehicle_Click(object sender, EventArgs e)
        {
            int counter = dataGridViewMain.SelectedRows.Count;
            var listToRemove = new List<VehiclesBase>();

            foreach (DataGridViewRow delRow
                in dataGridViewMain.SelectedRows)
            {
                dataGridViewMain.Rows.Remove(delRow);

                foreach (VehiclesBase vehicle in _totalVehicleList)
                {
                    if (Convert.ToString(
                        vehicle.Type) == Convert.ToString(
                                        delRow.Cells[0].Value) &&
                        Convert.ToString(
                            vehicle.Name) == Convert.ToString(
                                        delRow.Cells[1].Value) &&
                        Convert.ToString(
                            vehicle.Weight) == Convert.ToString(
                                        delRow.Cells[2].Value))
                    {
                        listToRemove.Add(vehicle);
                    }
                }
            }
            foreach (var remVehicle in listToRemove)
            {
                _totalVehicleList.Remove(remVehicle);
            }

            if (counter != 0)
            {
                MessageBox.Show($"Удалено строк: {counter}",
                    "Удаление строк",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Кнопка, инициализирующая расчёт расхода топлива для выделенного ТС
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFuelCost_Click(object sender, EventArgs e)
        {
            try
            {
                FuelCostForm fuelCostForm 
                    = new FuelCostForm(FindVehicleBySelectedRow());

                fuelCostForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Кнопка открытия формы поиска ТС
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindVehicle_Click(object sender, EventArgs e)
        {
            var findVehicleForm 
                = new FindVehicleForm(_totalVehicleList).ShowDialog();
        }

        /// <summary>
        /// Кнопка очистки списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            _totalVehicleList.Clear();
        }

        /// <summary>
        /// Кнопка сохранения списка в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveList_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "vehicles" +
                         "(*.ead)|*.ead|All files (*.*)|*.*",
                AddExtension = true,
                Title = "Save vehicles information"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();
                var fileSave = saveFileDialog.FileName;
                using (var fileStream = new FileStream(
                    fileSave, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fileStream, _totalVehicleList);

                    MessageBox.Show("Файл успешно сохранён!");
                }
            }
        }

        /// <summary>
        /// Кнопка загрузки списка ТС из файла формата .ead
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDownloadList_Click(object sender, EventArgs e)
        {
            //TODO: Также как с сейвфайлдиалогом +
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "ead файлы (*.ead)|*.ead*",
                RestoreDirectory = true,
                Title = "Load vehicles information"
            }; ;

            //openFileDialog.Filter = "ead файлы (*.ead)|*.ead*";
            //
            //openFileDialog.RestoreDirectory = true;
            //
            //openFileDialog.Title = "Load vehicles information";

            var forbinary = new BinaryFormatter();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (Path.GetExtension(filePath) == ".ead")
                {
                    try
                    {
                        using (var fileStream = new FileStream(
                            filePath, FileMode.OpenOrCreate))
                        {
                            var newVehicle = (BindingList<VehiclesBase>)
                                forbinary.Deserialize(fileStream);

                            _totalVehicleList.Clear();

                            foreach (var vehicles in newVehicle)
                            {
                                _totalVehicleList.Add(vehicles);
                            }
                            MessageBox.Show("Файл успешно загружен!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удаётся загрузить файл!");
                    }
                }
                else
                {
                    MessageBox.Show("Файл имел некорректный формат!");
                }
            }
        }

        /// <summary>
        /// Кнопка генерации рандомных ТС
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRandomVehicle_Click(object sender, EventArgs e)
        {
            // Список имён.
            string[] nameList = new string[]
            {
                "BMW",
                "Rapror",
                "Mazerati",
                "Dodge",
                "Mazda",
                "Tesla",
                "Mitsubishi"
            };

            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                var typeVehicle = ((VehiclesTypes)rnd.Next(0, 3)).GetClassByType();

                var vehicle = Activator.CreateInstance(typeVehicle) as VehiclesBase;

                vehicle.Name = nameList[rnd.Next(0, nameList.Length)];
                vehicle.Weight = rnd.Next(500, 10000);

                _totalVehicleList.Add(vehicle);
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Поиск ТС по выделенной строке
        /// </summary>
        /// <returns></returns>
        private VehiclesBase FindVehicleBySelectedRow()
        {
            foreach (var vehicle in _totalVehicleList)
            {
                if (Convert.ToString(vehicle.Name) == Convert.ToString(
                    dataGridViewMain.SelectedRows[0].Cells[0].Value) &&
                    Convert.ToString(vehicle.Type) == Convert.ToString(
                        dataGridViewMain.SelectedRows[0].Cells[1].Value) &&
                    Convert.ToString(vehicle.Weight) == Convert.ToString(
                        dataGridViewMain.SelectedRows[0].Cells[2].Value))
                {
                    return vehicle;
                }
            }

            throw new Exception("Не найдено ТС.");
        }

        #endregion
    }
}
