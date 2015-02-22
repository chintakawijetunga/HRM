namespace ALSL_HRM_System.Forms
{
    partial class frmSalaryIncrementRequest
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
            this.txtSalaryIncReqNo = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtReqValue = new System.Windows.Forms.TextBox();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dgvSalaryIncReq = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpRequestedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryIncReq)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Request Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Employee Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Increment Requested";
            // 
            // txtSalaryIncReqNo
            // 
            this.txtSalaryIncReqNo.Location = new System.Drawing.Point(93, 53);
            this.txtSalaryIncReqNo.Name = "txtSalaryIncReqNo";
            this.txtSalaryIncReqNo.Size = new System.Drawing.Size(149, 20);
            this.txtSalaryIncReqNo.TabIndex = 45;
            this.txtSalaryIncReqNo.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(93, 99);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(309, 20);
            this.txtEmployeeName.TabIndex = 46;
            // 
            // txtReqValue
            // 
            this.txtReqValue.Location = new System.Drawing.Point(428, 54);
            this.txtReqValue.Name = "txtReqValue";
            this.txtReqValue.Size = new System.Drawing.Size(191, 20);
            this.txtReqValue.TabIndex = 47;
            this.txtReqValue.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(267, 53);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(135, 21);
            this.cmbEmployeeID.TabIndex = 48;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeId_SelectedIndexChanged);
            this.cmbEmployeeID.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // dgvSalaryIncReq
            // 
            this.dgvSalaryIncReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryIncReq.Location = new System.Drawing.Point(93, 150);
            this.dgvSalaryIncReq.Name = "dgvSalaryIncReq";
            this.dgvSalaryIncReq.Size = new System.Drawing.Size(526, 236);
            this.dgvSalaryIncReq.TabIndex = 50;
            this.dgvSalaryIncReq.SelectionChanged += new System.EventHandler(this.dgvSalaryIncReq_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Save1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Populate;
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 70);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 56;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.HomeExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.New;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 110);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 52;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 270);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpRequestedDate
            // 
            this.dtpRequestedDate.Location = new System.Drawing.Point(428, 98);
            this.dtpRequestedDate.Name = "dtpRequestedDate";
            this.dtpRequestedDate.Size = new System.Drawing.Size(182, 20);
            this.dtpRequestedDate.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Requested Date";
            // 
            // frmSalaryIncrementRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpRequestedDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSalaryIncReq);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.txtReqValue);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtSalaryIncReqNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmSalaryIncrementRequest";
            this.Text = "Salary Increment Request Details";
            this.Load += new System.EventHandler(this.frmSalaryIncrementRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryIncReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalaryIncReqNo;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtReqValue;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DataGridView dgvSalaryIncReq;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpRequestedDate;
        private System.Windows.Forms.Label label5;
    }
}