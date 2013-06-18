using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FinanceApp.Data;
namespace FinanceApp
{
    static class Program
    {
        public static FinanceAppEntities entity;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            entity = new FinanceAppEntities();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
