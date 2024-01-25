using DM_BA_88A.Utilities;
using System;
using System.Windows.Forms;

namespace DM_BA_88A
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
            InterfaceConfig.InitializeConfig();
            Application.Run(new Dashboard());
        }
    }
}