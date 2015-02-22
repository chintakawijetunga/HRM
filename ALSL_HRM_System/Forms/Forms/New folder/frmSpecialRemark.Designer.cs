namespace ALSL_HRM_System.Forms
{
    partial class frmSpecialRemark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.cmbEmployeeNumber = new System.Windows.Forms.ComboBox();
            this.dgvSpecialRemark = new System.Windows.Forms.DataGridView();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpRemarkDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarkId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialRemark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remark Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(19, 97);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(607, 95);
            this.txtRemark.TabIndex = 9;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(308, 36);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(117, 20);
            this.txtEmployeeName.TabIndex = 14;
            // 
            // cmbEmployeeNumber
            // 
            this.cmbEmployeeNumber.FormattingEnabled = true;
            this.cmbEmployeeNumber.Location = new System.Drawing.Point(157, 36);
            this.cmbEmployeeNumber.Name = "cmbEmployeeNumber";
            this.cmbEmployeeNumber.Size = new System.Drawing.Size(132, 21);
            this.cmbEmployeeNumber.TabIndex = 15;
            // 
            // dgvSpecialRemark
            // 
            this.dgvSpecialRemark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialRemark.Location = new System.Drawing.Point(19, 214);
            this.dgvSpecialRemark.Name = "dgvSpecialRemark";
            this.dgvSpecialRemark.Size = new System.Drawing.Size(607, 173);
            this.dgvSpecialRemark.TabIndex = 17;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(683, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(683, 39);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 39;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(683, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(683, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(683, 68);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(683, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtpRemarkDate
            // 
            this.dtpRemarkDate.Location = new System.Drawing.Point(442, 36);
            this.dtpRemarkDate.Name = "dtpRemarkDate";
            this.dtpRemarkDate.Size = new System.Drawing.Size(184, 20);
            this.dtpRemarkDate.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Remark Id";
            // 
            // txtRemarkId
            // 
            this.txtRemarkId.Location = new System.Drawing.Point(18, 37);
            this.txtRemarkId.Name = "txtRemarkId";
            this.txtRemarkId.Size = new System.Drawing.Size(121, 20);
            this.txtRemarkId.TabIndex = 43;
            // 
            // frmSpecialRemark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 404);
            this.Controls.Add(this.txtRemarkId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpRemarkDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSpecialRemark);
            this.Controls.Add(this.cmbEmployeeNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmSpecialRemark";
            this.Text = "Special Remark";
            this.Load += new System.EventHandler(this.frmSpecialRemark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialRemark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.ComboBox cmbEmployeeNumber;
        private System.Windows.Forms.DataGridView dgvSpecialRemark;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpRemarkDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarkId;
    }
}