using System;
using System.Windows.Forms;
using CalculatorLibrary.FuncModel;
using CalculatorLibrary.FuncModel.Interfaces;

namespace CalculatorUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.AddConfig();
            var socket = GlobalConfig.AddConfig();
            Application.Run(new CalculatorForm(socket));

        }
    }
}
