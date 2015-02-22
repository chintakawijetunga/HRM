namespace ALSL_HRM_System.Forms
{
    partial class frmServiceExtendDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExtendTo = new System.Windows.Forms.DateTimePicker();
            this.dtpExtendFrom = new System.Windows.Forms.DateTimePicker();
            this.rbtNoExtend = new System.Windows.Forms.RadioButton();
            this.rbtYesExtend = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbExtendReqID = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txtServiceExtendID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvServiceExtendDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceExtendDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtpExtendTo);
            this.groupBox1.Controls.Add(this.dtpExtendFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 162);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extend Details";
            // 
            // dtpExtendTo
            // 
            this.dtpExtendTo.Location = new System.Drawing.Point(22, 122);
            this.dtpExtendTo.Name = "dtpExtendTo";
            this.dtpExtendTo.Size = new System.Drawing.Size(200, 20);
            this.dtpExtendTo.TabIndex = 82;
            // 
            // dtpExtendFrom
            // 
            this.dtpExtendFrom.Location = new System.Drawing.Point(22, 75);
            this.dtpExtendFrom.Name = "dtpExtendFrom";
            this.dtpExtendFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpExtendFrom.TabIndex = 81;
            // 
            // rbtNoExtend
            // 
            this.rbtNoExtend.AutoSize = true;
            this.rbtNoExtend.Location = new System.Drawing.Point(109, 10);
            this.rbtNoExtend.Name = "rbtNoExtend";
            this.rbtNoExtend.Size = new System.Drawing.Size(39, 17);
            this.rbtNoExtend.TabIndex = 80;
            this.rbtNoExtend.TabStop = true;
            this.rbtNoExtend.Text = "No";
            this.rbtNoExtend.UseVisualStyleBackColor = true;
            // 
            // rbtYesExtend
            // 
            this.rbtYesExtend.AutoSize = true;
            this.rbtYesExtend.Location = new System.Drawing.Point(10, 10);
            this.rbtYesExtend.Name = "rbtYesExtend";
            this.rbtYesExtend.Size = new System.Drawing.Size(43, 17);
            this.rbtYesExtend.TabIndex = 79;
            this.rbtYesExtend.TabStop = true;
            this.rbtYesExtend.Text = "Yes";
            this.rbtYesExtend.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Extend To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Extend From";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(24, 92);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(140, 20);
            this.txtEmployeeID.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Employee ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Extend Request ID";
            // 
            // cmbExtendReqID
            // 
            this.cmbExtendReqID.FormattingEnabled = true;
            this.cmbExtendReqID.Location = new System.Drawing.Point(199, 35);
            this.cmbExtendReqID.Name = "cmbExtendReqID";
            this.cmbExtendReqID.Size = new System.Drawing.Size(154, 21);
            this.cmbExtendReqID.TabIndex = 76;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // txtServiceExtendID
            // 
            this.txtServiceExtendID.Location = new System.Drawing.Point(24, 35);
            this.txtServiceExtendID.Name = "txtServiceExtendID";
            this.txtServiceExtendID.Size = new System.Drawing.Size(140, 20);
            this.txtServiceExtendID.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Service Extend ID";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(199, 92);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(258, 20);
            this.txtEmployeeName.TabIndex = 80;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Employee Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(549, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(549, 34);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 86;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(549, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(549, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 84;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(549, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(549, 63);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 82;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(549, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvServiceExtendDetails
            // 
            this.dgvServiceExtendDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceExtendDetails.Location = new System.Drawing.Point(24, 325);
            this.dgvServiceExtendDetails.Name = "dgvServiceExtendDetails";
            this.dgvServiceExtendDetails.Size = new System.Drawing.Size(520, 169);
            this.dgvServiceExtendDetails.TabIndex = 88;
            this.dgvServiceExtendDetails.SelectionChanged += new System.EventHandler(this.dgvServiceExtendDetails_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtNoExtend);
            this.panel1.Controls.Add(this.rbtYesExtend);
            this.panel1.Location = new System.Drawing.Point(11, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 36);
            this.panel1.TabIndex = 83;
            // 
            // frmServiceExtendDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 532);
            this.Controls.Add(this.dgvServiceExtendDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServiceExtendID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbExtendReqID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmServiceExtendDetails";
            this.Text = "frmServiceExtendDetails";
            this.Load += new System.EventHandler(this.frmServiceExtendDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceExtendDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbExtendReqID;
        private System.Windows.Forms.RadioButton rbtNoExtend;
        private System.Windows.Forms.RadioButton rbtYesExtend;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DateTimePicker dtpExtendTo;
        private System.Windows.Forms.DateTimePicker dtpExtendFrom;
        private System.Windows.Forms.TextBox txtServiceExtendID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvServiceExtendDetails;
        private System.Windows.Forms.Panel panel1;
    }
}