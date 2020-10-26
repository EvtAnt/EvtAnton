using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelCalculationModel;

namespace FuelCalculationView
{
    /// <summary>
    /// Класс, описывающий программу
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());     
        }
    }
}
