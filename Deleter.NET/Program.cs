using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Deleter.NET
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
            FormMain main = new FormMain();
            Application.Run(main);
        }
    }
}