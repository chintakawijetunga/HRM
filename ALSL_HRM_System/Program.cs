using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALSL_HRM_System.DialogBoxes;
using ALSL_HRM_System.Forms.Forms;
using HRM_DBInstallation;

namespace ALSL_HRM_System.Forms
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
            Application.Run(new frmLoginUser());
        }
    }
}
