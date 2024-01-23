using AnnarComMICROSESV60.Utilities;
using System;
using System.Windows.Forms;

namespace AnnarComMICROSESV60
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