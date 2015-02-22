namespace ALSL_HRM_System.Forms
{
    partial class frmLoanDetails
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
            this.grpConfirmation = new System.Windows.Forms.GroupBox();
            this.chkConfirmed = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBankLoanNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpEmpDetails = new System.Windows.Forms.GroupBox();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtInHouseLoan = new System.Windows.Forms.RadioButton();
            this.rbtBankLoan = new System.Windows.Forms.RadioButton();
            this.cmbLoanReqNo = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvLoanDetails = new System.Windows.Forms.DataGridView();
            this.grpConfirmation.SuspendLayout();
            this.grpEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConfirmation
            // 
            this.grpConfirmation.Controls.Add(this.chkConfirmed);
            this.grpConfirmation.Controls.Add(this.dtpEndDate);
            this.grpConfirmation.Controls.Add(this.dtpStartDate);
            this.grpConfirmation.Controls.Add(this.label5);
            this.grpConfirmation.Controls.Add(this.label10);
            this.grpConfirmation.Controls.Add(this.txtBankLoanNo);
            this.grpConfirmation.Controls.Add(this.label8);
            this.grpConfirmation.Location = new System.Drawing.Point(484, 114);
            this.grpConfirmation.Name = "grpConfirmation";
            this.grpConfirmation.Size = new System.Drawing.Size(389, 149);
            this.grpConfirmation.TabIndex = 41;
            this.grpConfirmation.TabStop = false;
            this.grpConfirmation.Text = "Confirmation Details";
            // 
            // chkConfirmed
            // 
            this.chkConfirmed.AutoSize = true;
            this.chkConfirmed.Location = new System.Drawing.Point(310, 35);
            this.chkConfirmed.Name = "chkConfirmed";
            this.chkConfirmed.Size = new System.Drawing.Size(73, 17);
            this.chkConfirmed.TabIndex = 37;
            this.chkConfirmed.Text = "Confirmed";
            this.chkConfirmed.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(136, 102);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 38;
            this.dtpEndDate.TextChanged += new System.EventHandler(this.txtChanged_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(136, 71);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 37;
            this.dtpStartDate.TextChanged += new System.EventHandler(this.txtChanged_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Bank Loan No";
            // 
            // txtBankLoanNo
            // 
            this.txtBankLoanNo.Location = new System.Drawing.Point(136, 33);
            this.txtBankLoanNo.Name = "txtBankLoanNo";
            this.txtBankLoanNo.Size = new System.Drawing.Size(142, 20);
            this.txtBankLoanNo.TabIndex = 33;
            this.txtBankLoanNo.TextChanged += new System.EventHandler(this.txtChanged_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Start Date";
            // 
            // grpEmpDetails
            // 
            this.grpEmpDetails.Controls.Add(this.txtEmployeeNo);
            this.grpEmpDetails.Controls.Add(this.txtEmployeeName);
            this.grpEmpDetails.Controls.Add(this.label3);
            this.grpEmpDetails.Controls.Add(this.label2);
            this.grpEmpDetails.Location = new System.Drawing.Point(81, 136);
            this.grpEmpDetails.Name = "grpEmpDetails";
            this.grpEmpDetails.Size = new System.Drawing.Size(377, 127);
            this.grpEmpDetails.TabIndex = 40;
            this.grpEmpDetails.TabStop = false;
            this.grpEmpDetails.Text = "Employee Details";
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.Location = new System.Drawing.Point(127, 36);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(142, 20);
            this.txtEmployeeNo.TabIndex = 34;
            this.txtEmployeeNo.TextChanged += new System.EventHandler(this.txtChanged_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(127, 71);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(230, 20);
            this.txtEmployeeName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Loan Request No";
            // 
            // rbtInHouseLoan
            // 
            this.rbtInHouseLoan.AutoSize = true;
            this.rbtInHouseLoan.Location = new System.Drawing.Point(208, 42);
            this.rbtInHouseLoan.Name = "rbtInHouseLoan";
            this.rbtInHouseLoan.Size = new System.Drawing.Size(95, 17);
            this.rbtInHouseLoan.TabIndex = 36;
            this.rbtInHouseLoan.Text = "In-House Loan";
            this.rbtInHouseLoan.UseVisualStyleBackColor = true;
            this.rbtInHouseLoan.CheckedChanged += new System.EventHandler(this.rbtChange_CheckedChanged);
            // 
            // rbtBankLoan
            // 
            this.rbtBankLoan.AutoSize = true;
            this.rbtBankLoan.Checked = true;
            this.rbtBankLoan.Location = new System.Drawing.Point(88, 43);
            this.rbtBankLoan.Name = "rbtBankLoan";
            this.rbtBankLoan.Size = new System.Drawing.Size(77, 17);
            this.rbtBankLoan.TabIndex = 35;
            this.rbtBankLoan.TabStop = true;
            this.rbtBankLoan.Text = "Bank Loan";
            this.rbtBankLoan.UseVisualStyleBackColor = true;
            this.rbtBankLoan.CheckedChanged += new System.EventHandler(this.rbtChange_CheckedChanged);
            // 
            // cmbLoanReqNo
            // 
            this.cmbLoanReqNo.FormattingEnabled = true;
            this.cmbLoanReqNo.Location = new System.Drawing.Point(88, 91);
            this.cmbLoanReqNo.Name = "cmbLoanReqNo";
            this.cmbLoanReqNo.Size = new System.Drawing.Size(194, 21);
            this.cmbLoanReqNo.TabIndex = 34;
            this.cmbLoanReqNo.SelectedIndexChanged += new System.EventHandler(this.cmbLoanReqNo_SelectedIndexChanged);
            this.cmbLoanReqNo.TextChanged += new System.EventHandler(this.txtChanged_TextChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 87);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 47;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 127);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 287);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvLoanDetails
            // 
            this.dgvLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanDetails.Location = new System.Drawing.Point(81, 287);
            this.dgvLoanDetails.Name = "dgvLoanDetails";
            this.dgvLoanDetails.Size = new System.Drawing.Size(792, 203);
            this.dgvLoanDetails.TabIndex = 49;
            this.dgvLoanDetails.SelectionChanged += new System.EventHandler(this.dgvLoanDetails_SelectionChanged);
            // 
            // frmLoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 526);
            this.Controls.Add(this.dgvLoanDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbLoanReqNo);
            this.Controls.Add(this.grpConfirmation);
            this.Controls.Add(this.grpEmpDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtInHouseLoan);
            this.Controls.Add(this.rbtBankLoan);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLoanDetails";
            this.Text = "Loan Details";
            this.Load += new System.EventHandler(this.frmLoanDetails_Load);
            this.grpConfirmation.ResumeLayout(false);
            this.grpConfirmation.PerformLayout();
            this.grpEmpDetails.ResumeLayout(false);
            this.grpEmpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfirmation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBankLoanNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpEmpDetails;
        private System.Windows.Forms.ComboBox cmbLoanReqNo;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtInHouseLoan;
        private System.Windows.Forms.RadioButton rbtBankLoan;
        private System.Windows.Forms.CheckBox chkConfirmed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeNo;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvLoanDetails;
    }
}