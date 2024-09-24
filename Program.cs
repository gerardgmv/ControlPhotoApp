using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPhotoApp.Forms;
using System.Runtime.InteropServices;

namespace ControlPhotoApp
{

    static class Program
    {
        //[DllImport("user32.dll")]
        //public static extern bool LockWorkStation();
        // Bloquea el equipo


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

        }

    }
}
