namespace ALSL_HRM_System.Forms.Forms
{
    partial class frmDocumentViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentViewer));
            this.pdfDocViewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDocViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfDocViewer
            // 
            this.pdfDocViewer.Enabled = true;
            this.pdfDocViewer.Location = new System.Drawing.Point(2, 0);
            this.pdfDocViewer.Name = "pdfDocViewer";
            this.pdfDocViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfDocViewer.OcxState")));
            this.pdfDocViewer.Size = new System.Drawing.Size(1135, 434);
            this.pdfDocViewer.TabIndex = 0;
            // 
            // frmDocumentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 437);
            this.Controls.Add(this.pdfDocViewer);
            this.DoubleBuffered = true;
            this.Name = "frmDocumentViewer";
            this.Text = "Document Viewer";
            this.Load += new System.EventHandler(this.frmDocumentViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pdfDocViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfDocViewer;
    }
}