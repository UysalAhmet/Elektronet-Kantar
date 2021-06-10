using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Properties.Settings.Default.Reset();
            Properties.Settings.Default.Bilgisayar = Environment.MachineName;
            Properties.Settings.Default.Save();
            
            Application.Run(new Yetki());
        }
    }
}
