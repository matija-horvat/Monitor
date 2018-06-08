using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Monitor.Helpers;

namespace Monitor
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
            if (ConnectionHelper.GetSourceConnString() == String.Empty)
            {
                Application.Run(new SourceConn());
            }
            else
            {
                Application.Run(new ScriptsUpdate());
            }
            


        }
    }
}
