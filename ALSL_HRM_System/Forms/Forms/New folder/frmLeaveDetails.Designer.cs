namespace ALSL_HRM_System.Forms
{
    partial class frmLeaveDetails
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
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtLeaveID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberofLeaves = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvLeaveDetails = new System.Windows.Forms.DataGridView();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLeaveConfirmed = new System.Windows.Forms.CheckBox();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(431, 48);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(199, 20);
            this.txtEmployeeName.TabIndex = 68;
            // 
            // txtLeaveID
            // 
            this.txtLeaveID.Location = new System.Drawing.Point(27, 48);
            this.txtLeaveID.Name = "txtLeaveID";
            this.txtLeaveID.Size = new System.Drawing.Size(143, 20);
            this.txtLeaveID.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Leave ID";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(27, 91);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(143, 21);
            this.cmbLeaveType.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Leave Type";
            // 
            // txtNumberofLeaves
            // 
            this.txtNumberofLeaves.Location = new System.Drawing.Point(27, 139);
            this.txtNumberofLeaves.Name = "txtNumberofLeaves";
            this.txtNumberofLeaves.Size = new System.Drawing.Size(143, 20);
            this.txtNumberofLeaves.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Number of Leaves";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Start Date";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(722, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(722, 52);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 86;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(722, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(722, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 84;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(722, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(722, 81);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 82;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(722, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(206, 92);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(199, 20);
            this.dtpStartDate.TabIndex = 88;
            // 
            // dgvLeaveDetails
            // 
            this.dgvLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveDetails.Location = new System.Drawing.Point(27, 173);
            this.dgvLeaveDetails.Name = "dgvLeaveDetails";
            this.dgvLeaveDetails.Size = new System.Drawing.Size(603, 216);
            this.dgvLeaveDetails.TabIndex = 89;
            this.dgvLeaveDetails.SelectionChanged += new System.EventHandler(this.dgvLeaveDetails_SelectionChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(431, 92);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(199, 20);
            this.dtpEndDate.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "End Date";
            // 
            // cbLeaveConfirmed
            // 
            this.cbLeaveConfirmed.AutoSize = true;
            this.cbLeaveConfirmed.Location = new System.Drawing.Point(206, 139);
            this.cbLeaveConfirmed.Name = "cbLeaveConfirmed";
            this.cbLeaveConfirmed.Size = new System.Drawing.Size(106, 17);
            this.cbLeaveConfirmed.TabIndex = 92;
            this.cbLeaveConfirmed.Text = "Leave Confirmed";
            this.cbLeaveConfirmed.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(206, 48);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(199, 21);
            this.cmbEmployeeID.TabIndex = 93;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // frmLeaveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 401);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.cbLeaveConfirmed);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLeaveDetails);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumberofLeaves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtLeaveID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLeaveDetails";
            this.Text = "frmLeaveDetails";
            this.Load += new System.EventHandler(this.frmLeaveDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtLeaveID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberofLeaves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvLeaveDetails;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbLeaveConfirmed;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
    }
}