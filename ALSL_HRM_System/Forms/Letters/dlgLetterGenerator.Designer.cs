namespace ALSL_HRM_System.Forms
{
    partial class dlgLetterGenerator
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.cmbComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(410, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 32);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(313, 221);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(81, 32);
            this.btnGenerate.TabIndex = 40;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // cmbComboBox
            // 
            this.cmbComboBox.FormattingEnabled = true;
            this.cmbComboBox.Location = new System.Drawing.Point(195, 38);
            this.cmbComboBox.Name = "cmbComboBox";
            this.cmbComboBox.Size = new System.Drawing.Size(152, 21);
            this.cmbComboBox.TabIndex = 44;
            this.cmbComboBox.SelectedIndexChanged += new System.EventHandler(this.cmbComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Service Extend Request ID";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(195, 80);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(293, 20);
            this.txtFullName.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Employee Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Employee Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Employee Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(195, 125);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(293, 20);
            this.txtAddress.TabIndex = 49;
            // 
            // dlgLetterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.cmbComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "dlgLetterGenerator";
            this.Text = "Letter Generator";
            this.Load += new System.EventHandler(this.frmServiceExtendRejectionLetter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ComboBox cmbComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
    }
}