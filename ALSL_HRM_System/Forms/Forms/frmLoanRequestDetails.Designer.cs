namespace ALSL_HRM_System.Forms
{
    partial class frmLoanRequestDetails
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
            this.rbtBankLoan = new System.Windows.Forms.RadioButton();
            this.rbtInHouseLoan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoanRequestNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployeeNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvLoanRequestDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanRequestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtBankLoan
            // 
            this.rbtBankLoan.AutoSize = true;
            this.rbtBankLoan.Checked = true;
            this.rbtBankLoan.Location = new System.Drawing.Point(76, 26);
            this.rbtBankLoan.Name = "rbtBankLoan";
            this.rbtBankLoan.Size = new System.Drawing.Size(77, 17);
            this.rbtBankLoan.TabIndex = 0;
            this.rbtBankLoan.TabStop = true;
            this.rbtBankLoan.Text = "Bank Loan";
            this.rbtBankLoan.UseVisualStyleBackColor = true;
            this.rbtBankLoan.CheckedChanged += new System.EventHandler(this.rbtChange_CheckedChanged);
            // 
            // rbtInHouseLoan
            // 
            this.rbtInHouseLoan.AutoSize = true;
            this.rbtInHouseLoan.Location = new System.Drawing.Point(187, 26);
            this.rbtInHouseLoan.Name = "rbtInHouseLoan";
            this.rbtInHouseLoan.Size = new System.Drawing.Size(95, 17);
            this.rbtInHouseLoan.TabIndex = 1;
            this.rbtInHouseLoan.Text = "In-House Loan";
            this.rbtInHouseLoan.UseVisualStyleBackColor = true;
            this.rbtInHouseLoan.CheckedChanged += new System.EventHandler(this.rbtChange_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Request No";
            // 
            // txtLoanRequestNumber
            // 
            this.txtLoanRequestNumber.Location = new System.Drawing.Point(187, 65);
            this.txtLoanRequestNumber.Name = "txtLoanRequestNumber";
            this.txtLoanRequestNumber.Size = new System.Drawing.Size(198, 20);
            this.txtLoanRequestNumber.TabIndex = 11;
            this.txtLoanRequestNumber.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEmployeeNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(70, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 116);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(117, 67);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 20);
            this.txtEmployeeName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Employee Name";
            // 
            // cmbEmployeeNumber
            // 
            this.cmbEmployeeNumber.FormattingEnabled = true;
            this.cmbEmployeeNumber.Location = new System.Drawing.Point(117, 28);
            this.cmbEmployeeNumber.Name = "cmbEmployeeNumber";
            this.cmbEmployeeNumber.Size = new System.Drawing.Size(137, 21);
            this.cmbEmployeeNumber.TabIndex = 27;
            this.cmbEmployeeNumber.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeNumber_SelectedIndexChanged);
            this.cmbEmployeeNumber.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpRequestDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtInstallmentAmount);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLoanAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDuration);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbLoanType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(415, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 235);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loan Details";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(88, 163);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(191, 20);
            this.dtpRequestDate.TabIndex = 38;
            this.dtpRequestDate.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Months";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Installment Amount";
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(393, 206);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(124, 20);
            this.txtInstallmentAmount.TabIndex = 35;
            this.txtInstallmentAmount.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Loan Amount";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(88, 203);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(189, 20);
            this.txtLoanAmount.TabIndex = 33;
            this.txtLoanAmount.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(393, 166);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(124, 20);
            this.txtDuration.TabIndex = 31;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Request Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.cmbBank);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(11, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 71);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "If Bank Loan";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(343, 35);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(124, 21);
            this.cmbBranch.TabIndex = 38;
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(77, 35);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(157, 21);
            this.cmbBank.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bank";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Location = new System.Drawing.Point(88, 36);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(157, 21);
            this.cmbLoanType.TabIndex = 27;
            this.cmbLoanType.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Loan Type";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 95);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 40;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 135);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 36;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvLoanRequestDetails
            // 
            this.dgvLoanRequestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanRequestDetails.Location = new System.Drawing.Point(79, 285);
            this.dgvLoanRequestDetails.Name = "dgvLoanRequestDetails";
            this.dgvLoanRequestDetails.Size = new System.Drawing.Size(866, 227);
            this.dgvLoanRequestDetails.TabIndex = 42;
            this.dgvLoanRequestDetails.SelectionChanged += new System.EventHandler(this.dgvLoanRequestDetails_SelectionChanged);
            // 
            // frmLoanRequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 524);
            this.Controls.Add(this.dgvLoanRequestDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLoanRequestNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtInHouseLoan);
            this.Controls.Add(this.rbtBankLoan);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLoanRequestDetails";
            this.Text = "Loan Request Details";
            this.Load += new System.EventHandler(this.frmLoanRequestDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanRequestDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtBankLoan;
        private System.Windows.Forms.RadioButton rbtInHouseLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanRequestNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEmployeeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvLoanRequestDetails;
    }
}