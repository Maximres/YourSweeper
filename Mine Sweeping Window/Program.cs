using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mine_Sweeping_Window
{
    static class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMineSweeping());
        }
    }
}