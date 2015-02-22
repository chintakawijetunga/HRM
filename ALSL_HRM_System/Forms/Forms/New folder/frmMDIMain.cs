using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ALSL_HRM_System.Forms
{
    public partial class frmMDIMain : Office2007Form
    {
        public frmMDIMain()
        {
            InitializeComponent();
        }

        private void somethingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            frmBankDetails obj1 = new frmBankDetails();
            obj1.Show();
        }
    }
}
