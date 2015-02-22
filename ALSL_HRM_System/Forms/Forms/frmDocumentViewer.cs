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

namespace ALSL_HRM_System.Forms.Forms
{
    public partial class frmDocumentViewer : Office2007Form
    {
        frmMDIMain form;
        String filePath;
        public frmDocumentViewer(frmMDIMain form, String filePath)
        {
            this.form = form;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.filePath = filePath;
        }

        private void frmDocumentViewer_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            pdfDocViewer.Height = 680;
            pdfDocViewer.Width = 1340;
            pdfDocViewer.src = filePath;
        }
    }
}
