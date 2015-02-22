namespace ALSL_HRM_System.Forms
{
    partial class dlgReportGenerator
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbDepartmentName = new System.Windows.Forms.ComboBox();
            this.cbDesignationName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "To(Month)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "From(Month)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(275, 194);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(76, 32);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(244, 84);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 25;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(23, 84);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 26;
            // 
            // cbDepartmentName
            // 
            this.cbDepartmentName.FormattingEnabled = true;
            this.cbDepartmentName.Location = new System.Drawing.Point(23, 145);
            this.cbDepartmentName.Name = "cbDepartmentName";
            this.cbDepartmentName.Size = new System.Drawing.Size(200, 21);
            this.cbDepartmentName.TabIndex = 27;
            // 
            // cbDesignationName
            // 
            this.cbDesignationName.FormattingEnabled = true;
            this.cbDesignationName.Location = new System.Drawing.Point(244, 145);
            this.cbDesignationName.Name = "cbDesignationName";
            this.cbDesignationName.Size = new System.Drawing.Size(200, 21);
            this.cbDesignationName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Designation";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(23, 26);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(100, 17);
            this.chkEnable.TabIndex = 31;
            this.chkEnable.Text = "Consider Period";
            this.chkEnable.UseVisualStyleBackColor = true;
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // dlgReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 238);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDesignationName);
            this.Controls.Add(this.cbDepartmentName);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "dlgReportGenerator";
            this.Text = "Report Generator";
            this.Load += new System.EventHandler(this.dlgReportGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.ComboBox cbDepartmentName;
        private System.Windows.Forms.ComboBox cbDesignationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEnable;
    }
}