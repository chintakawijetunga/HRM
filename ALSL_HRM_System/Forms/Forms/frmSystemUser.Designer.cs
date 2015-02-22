namespace ALSL_HRM_System.Forms
{
    partial class frmSystemUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSystemUsers = new System.Windows.Forms.DataGridView();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtAccessLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User ID";
            // 
            // dgvSystemUsers
            // 
            this.dgvSystemUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemUsers.Location = new System.Drawing.Point(84, 155);
            this.dgvSystemUsers.Name = "dgvSystemUsers";
            this.dgvSystemUsers.Size = new System.Drawing.Size(765, 228);
            this.dgvSystemUsers.TabIndex = 15;
            this.dgvSystemUsers.SelectionChanged += new System.EventHandler(this.dgvSystemUsers_SelectionChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 40;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 37;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 36;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Location = new System.Drawing.Point(12, 115);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(12, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Location = new System.Drawing.Point(568, 64);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(281, 20);
            this.txtEmployeeName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Employee Name";
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Enabled = false;
            this.dtpJoinDate.Location = new System.Drawing.Point(84, 116);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(209, 20);
            this.dtpJoinDate.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Join Date";
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPopulate.BackgroundImage")));
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 75);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 46;
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(84, 62);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(209, 20);
            this.txtUserID.TabIndex = 47;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(327, 62);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(209, 20);
            this.txtEmployeeID.TabIndex = 48;
            // 
            // txtAccessLevel
            // 
            this.txtAccessLevel.Enabled = false;
            this.txtAccessLevel.Location = new System.Drawing.Point(327, 116);
            this.txtAccessLevel.Name = "txtAccessLevel";
            this.txtAccessLevel.Size = new System.Drawing.Size(209, 20);
            this.txtAccessLevel.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Access Level";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(12, 315);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 51;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 416);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAccessLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSystemUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmSystemUser";
            this.Text = "System User Details";
            this.Load += new System.EventHandler(this.frmSystemUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSystemUsers;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtAccessLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
    }
}