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
    /// Класс, описывающий форму для поиска ТС
    /// </summary>
    public partial class FindVehicleForm : Form
    {
        /// <summary>
        /// Конструктор класса "FindVehicleForm"
        /// </summary>
        public FindVehicleForm(BindingList<VehiclesBase> totalVehicleList)
        {
            InitializeComponent();

            _localVehicleList = totalVehicleList;

            dataGridViewFoundVehicles.DataSource = _didisplayedList;
            
            dataGridViewFoundVehicles.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.Fill;

            // Внесение в Combobox всех типов ТС из "enum VehiclesTypes"
            var vehicleTypes = Enum.GetNames(typeof(VehiclesTypes));
            for (int i = 0; i < vehicleTypes.Length; i++)
            {
                comboBoxTypeVehicles.Items.Add(vehicleTypes[i]);
            }
        }

        /// <summary>
        /// Список ТС, используемый только в форме "FindVehicleForm"
        /// </summary>
        public BindingList<VehiclesBase> _localVehicleList;

        /// <summary>
        /// Список ТС, отображаемый в "dataGridViewFoundVehicles"
        /// </summary>
        private BindingList<VehiclesBase> _didisplayedList 
            = new BindingList<VehiclesBase>();

        /// <summary>
        /// Поиск ТС по задваемым параметрам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                _didisplayedList.Clear();

                // Предвариетльная проверка вводимого имени ТС
                if (checkBoxNameVehicle.Checked == true)
                {
                    CheckNameVehicle(textBoxVehiclesName.Text);
                }

                // Проверка выбора типа ТС
                if (checkBoxTypeVehicle.Checked == true &&
                    string.IsNullOrEmpty(comboBoxTypeVehicles.Text) == true)
                {
                    MessageBox.Show("Не выбран тип ТС!");
                    return;
                }

                // Поиск по "Тип ТС", "Имя ТС", "Масса ТС" 
                if (checkBoxTypeVehicle.Checked == true &&
                    checkBoxNameVehicle.Checked == true &&
                    checkBoxWeightVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (comboBoxTypeVehicles.Text ==
                            Convert.ToString(_localVehicleList[i].Type) &&
                            textBoxVehiclesName.Text ==
                            _localVehicleList[i].Name &&
                            Convert.ToDouble(textBoxVehicleWeight.Text) ==
                            _localVehicleList[i].Weight)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Тип ТС", "Имя ТС" 
                if (checkBoxTypeVehicle.Checked == true &&
                    checkBoxNameVehicle.Checked == true)
                {
                    //_didisplayedList.Clear();
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (comboBoxTypeVehicles.Text ==
                            Convert.ToString(_localVehicleList[i].Type) &&
                            textBoxVehiclesName.Text ==
                            _localVehicleList[i].Name)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Тип ТС", "Масса ТС" 
                if (checkBoxTypeVehicle.Checked == true &&
                    checkBoxWeightVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (comboBoxTypeVehicles.Text ==
                            Convert.ToString(_localVehicleList[i].Type) &&
                            Convert.ToDouble(textBoxVehicleWeight.Text) ==
                            _localVehicleList[i].Weight)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Имя ТС", "Масса ТС" 
                if (checkBoxNameVehicle.Checked == true &&
                    checkBoxWeightVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (textBoxVehiclesName.Text ==
                            _localVehicleList[i].Name &&
                            Convert.ToDouble(textBoxVehicleWeight.Text) ==
                            _localVehicleList[i].Weight)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Тип ТС"
                if (checkBoxTypeVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (comboBoxTypeVehicles.Text ==
                            Convert.ToString(_localVehicleList[i].Type))
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Имя ТС" 
                if (checkBoxNameVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (textBoxVehiclesName.Text ==
                            _localVehicleList[i].Name)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Поиск по "Масса ТС" 
                if (checkBoxWeightVehicle.Checked == true)
                {
                    for (int i = 0; i < _localVehicleList.Count; i++)
                    {
                        if (Convert.ToDouble(textBoxVehicleWeight.Text) ==
                            _localVehicleList[i].Weight)
                        {
                            _didisplayedList.Add(_localVehicleList[i]);
                        }
                    }
                    return;
                }
                // Не выбран ни один из параметров поиска ТС
                else if (checkBoxTypeVehicle.Checked == false &&
                    checkBoxNameVehicle.Checked == false &&
                    checkBoxWeightVehicle.Checked == false)
                {
                    MessageBox.Show("Не выбран ни один из параметров поиска ТС.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseFindVehicleForm_Click(
            object sender, 
            EventArgs e)
        {
            _didisplayedList.Clear();
            this.Close();
        }

        /// <summary>
        /// Проверка введённых символов в "TextBoxVehicleWeight"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxVehicleWeight_KeyPress(
            object sender, 
            KeyPressEventArgs e)
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
