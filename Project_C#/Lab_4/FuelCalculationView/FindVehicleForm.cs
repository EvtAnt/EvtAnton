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

            comboBoxTypeVehicles.Items.AddRange(Enum.GetNames(typeof(VehiclesTypes)));

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
        /// Добавление экземпляров в список, согласно параметрам поиска
        /// </summary>
        /// <param name="list">Передаваемый список</param>
        /// <returns>Список наеденных значений</returns>
        private BindingList<VehiclesBase> FindVehicles (BindingList<VehiclesBase> list, 
            Func<VehiclesBase, bool> action)
        {
            var localTmpList = new BindingList<VehiclesBase>();
            
            for (int i = 0; i < list.Count; i++)
            {
                if (action.Invoke(list[i]))
                {
                    localTmpList.Add(list[i]);
                }
            }
            if (localTmpList.Count != 0)
            {
                return localTmpList;
            }
            return localTmpList;
        }

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

                #region Проверки заполнения параметров поиска

                // Предвариетльная проверка вводимого имени ТС
                if (checkBoxNameVehicle.Checked == true)
                {
                    SharedServices.CheckNameVehicle(textBoxVehiclesName.Text);
                }

                // Предварительная проверка вводимой массы ТС
                if (checkBoxWeightVehicle.Checked == true)
                {
                    if (string.IsNullOrEmpty(textBoxVehicleWeight.Text) 
                        || textBoxVehicleWeight.Text == " ")
                    {
                        MessageBox.Show("Не указана масса ТС!");
                        return;
                    }
                }

                // Проверка выбора типа ТС
                if (checkBoxTypeVehicle.Checked == true &&
                    string.IsNullOrEmpty(comboBoxTypeVehicles.Text) == true)
                {
                    MessageBox.Show("Не выбран тип ТС!");
                    return;
                }

                #endregion

                if (checkBoxTypeVehicle.Checked)
                {
                    var action = new Func<VehiclesBase, bool>((vehicle) =>
                    {
                        return comboBoxTypeVehicles.Text == Convert.ToString(vehicle.Type);
                    });

                    _didisplayedList = FindVehicles(_localVehicleList, action);
                }

                if (checkBoxNameVehicle.Checked)
                {
                    var action = new Func<VehiclesBase, bool>((vehicle) =>
                    {
                        return comboBoxTypeVehicles.Text == Convert.ToString(vehicle.Name);
                    });

                    _didisplayedList = FindVehicles(_didisplayedList, action);
                }

                if (checkBoxWeightVehicle.Checked)
                {
                    var action = new Func<VehiclesBase, bool>((vehicle) =>
                    {
                        return comboBoxTypeVehicles.Text == Convert.ToString(vehicle.Weight);
                    });

                    _didisplayedList = FindVehicles(_didisplayedList, action);
                }

                if (!(checkBoxWeightVehicle.Checked
                    || checkBoxNameVehicle.Checked
                    || checkBoxTypeVehicle.Checked))
                {
                    MessageBox.Show("Не выбран ни один из параметров поиска ТС.");
                }

                dataGridViewFoundVehicles.DataSource = _didisplayedList;

                #region Варианты комбинаций параметров поиска
                //
                //// Параметры поиска "Тип ТС" и "Имя ТС" выбраны
                //if (checkBoxNameVehicle.Checked == true)
                //{
                //    // Параметры поиска "Тип ТС", "Имя ТС", "Масса ТС" выбраны
                //    if (checkBoxWeightVehicle.Checked == true)
                //    {
                //        for (int i = 0; i < _localVehicleList.Count; i++)
                //        {
                //            if (comboBoxTypeVehicles.Text ==
                //                Convert.ToString(_localVehicleList[i].Type) &&
                //                textBoxVehiclesName.Text ==
                //                _localVehicleList[i].Name &&
                //                Convert.ToDouble(textBoxVehicleWeight.Text) ==
                //                _localVehicleList[i].Weight)
                //            {
                //                _didisplayedList.Add(_localVehicleList[i]);
                //            }
                //        }
                //        EmptyListMssage(_didisplayedList);
                //        return;
                //    }
                //    // Не выбран параметр поиска "Масса ТС"
                //    else
                //    {
                //        for (int i = 0; i < _localVehicleList.Count; i++)
                //        {
                //            if (comboBoxTypeVehicles.Text ==
                //                Convert.ToString(_localVehicleList[i].Type) &&
                //                textBoxVehiclesName.Text ==
                //                _localVehicleList[i].Name)
                //            {
                //                _didisplayedList.Add(_localVehicleList[i]);
                //            }
                //        }
                //        EmptyListMssage(_didisplayedList);
                //        return;
                //    }
                //}
                //// Параметры поиска "Тип ТС" и "Масса ТС" выбраны
                //// Не выбран параметр поиска "Имя ТС"
                //else if (checkBoxWeightVehicle.Checked == true)
                //{
                //    for (int i = 0; i < _localVehicleList.Count; i++)
                //    {
                //        if (comboBoxTypeVehicles.Text ==
                //            Convert.ToString(_localVehicleList[i].Type) &&
                //            Convert.ToDouble(textBoxVehicleWeight.Text) ==
                //            _localVehicleList[i].Weight)
                //        {
                //            _didisplayedList.Add(_localVehicleList[i]);
                //        }
                //    }
                //    EmptyListMssage(_didisplayedList);
                //    return;
                //}
                //// Параметром поиска выбран только "Тип ТС"
                //else
                //{
                //    for (int i = 0; i < _localVehicleList.Count; i++)
                //    {
                //        if (comboBoxTypeVehicles.Text ==
                //            Convert.ToString(_localVehicleList[i].Type))
                //        {
                //            _didisplayedList.Add(_localVehicleList[i]);
                //        }
                //    }
                //    EmptyListMssage(_didisplayedList);
                //    return;
                //}
                //
                //// Параметр поиска "Имя ТС" выбран
                //if (checkBoxNameVehicle.Checked == true)
                //{
                //    // Параметры поиска "Имя ТС" и "Масса ТС" выбраны
                //    if (checkBoxWeightVehicle.Checked == true)
                //    {
                //        for (int i = 0; i < _localVehicleList.Count; i++)
                //        {
                //            if (textBoxVehiclesName.Text ==
                //                _localVehicleList[i].Name &&
                //                Convert.ToDouble(textBoxVehicleWeight.Text) ==
                //                _localVehicleList[i].Weight)
                //            {
                //                _didisplayedList.Add(_localVehicleList[i]);
                //            }
                //        }
                //        EmptyListMssage(_didisplayedList);
                //        return;
                //    }
                //    // Параметром поиска выбран только "Имя ТС"
                //    else
                //    {
                //        for (int i = 0; i < _localVehicleList.Count; i++)
                //        {
                //            if (textBoxVehiclesName.Text ==
                //                _localVehicleList[i].Name)
                //            {
                //                _didisplayedList.Add(_localVehicleList[i]);
                //            }
                //        }
                //        EmptyListMssage(_didisplayedList);
                //        return;
                //    }
                //}
                //
                //// Параметром поиска выбран только "Масса ТС"
                //if (checkBoxWeightVehicle.Checked == true)
                //{
                //    for (int i = 0; i < _localVehicleList.Count; i++)
                //    {
                //        if (Convert.ToDouble(textBoxVehicleWeight.Text) ==
                //            _localVehicleList[i].Weight)
                //        {
                //            _didisplayedList.Add(_localVehicleList[i]);
                //        }
                //    }
                //    EmptyListMssage(_didisplayedList);
                //    return;
                //}
                // Не выбран ни один из параметров поиска


                #endregion
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
            SharedServices.CheckCount(e, textBoxVehicleWeight.Text);
        }

        /// <summary>
        /// Сообщение об отсутствии совпадений при поиске ТС
        /// </summary>
        /// <param name="vehiclesList">Список совпадений</param>
        public void EmptyListMssage(BindingList<VehiclesBase> vehiclesList)
        {
            if (vehiclesList.Count == 0)
            {
                MessageBox.Show("Совпадений не обнаружено!");
            }
        }
    }
}
