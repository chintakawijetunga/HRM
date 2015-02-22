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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
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
            this.grpConfirmation.Location = new System.Drawing.Point(343, 84);
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
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(136, 71);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 37;
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
            this.grpEmpDetails.Controls.Add(this.txtLastName);
            this.grpEmpDetails.Controls.Add(this.label4);
            this.grpEmpDetails.Controls.Add(this.txtFirstName);
            this.grpEmpDetails.Controls.Add(this.label3);
            this.grpEmpDetails.Controls.Add(this.label2);
            this.grpEmpDetails.Location = new System.Drawing.Point(35, 84);
            this.grpEmpDetails.Name = "grpEmpDetails";
            this.grpEmpDetails.Size = new System.Drawing.Size(290, 149);
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
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 20);
            this.txtLastName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "First Name";
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
            this.label1.Location = new System.Drawing.Point(348, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Loan Request No";
            // 
            // rbtInHouseLoan
            // 
            this.rbtInHouseLoan.AutoSize = true;
            this.rbtInHouseLoan.Location = new System.Drawing.Point(162, 35);
            this.rbtInHouseLoan.Name = "rbtInHouseLoan";
            this.rbtInHouseLoan.Size = new System.Drawing.Size(95, 17);
            this.rbtInHouseLoan.TabIndex = 36;
            this.rbtInHouseLoan.TabStop = true;
            this.rbtInHouseLoan.Text = "In-House Loan";
            this.rbtInHouseLoan.UseVisualStyleBackColor = true;
            // 
            // rbtBankLoan
            // 
            this.rbtBankLoan.AutoSize = true;
            this.rbtBankLoan.Location = new System.Drawing.Point(42, 36);
            this.rbtBankLoan.Name = "rbtBankLoan";
            this.rbtBankLoan.Size = new System.Drawing.Size(77, 17);
            this.rbtBankLoan.TabIndex = 35;
            this.rbtBankLoan.TabStop = true;
            this.rbtBankLoan.Text = "Bank Loan";
            this.rbtBankLoan.UseVisualStyleBackColor = true;
            // 
            // cmbLoanReqNo
            // 
            this.cmbLoanReqNo.FormattingEnabled = true;
            this.cmbLoanReqNo.Location = new System.Drawing.Point(479, 34);
            this.cmbLoanReqNo.Name = "cmbLoanReqNo";
            this.cmbLoanReqNo.Size = new System.Drawing.Size(142, 21);
            this.cmbLoanReqNo.TabIndex = 34;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(774, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(774, 36);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 47;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(774, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(774, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(774, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(774, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(774, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvLoanDetails
            // 
            this.dgvLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanDetails.Location = new System.Drawing.Point(35, 257);
            this.dgvLoanDetails.Name = "dgvLoanDetails";
            this.dgvLoanDetails.Size = new System.Drawing.Size(697, 203);
            this.dgvLoanDetails.TabIndex = 49;
            this.dgvLoanDetails.SelectionChanged += new System.EventHandler(this.dgvLoanDetails_SelectionChanged);
            // 
            // frmLoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 485);
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
            this.Text = "frmLoanDetails";
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
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
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