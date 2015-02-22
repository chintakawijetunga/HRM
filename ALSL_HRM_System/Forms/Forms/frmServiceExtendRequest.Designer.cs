namespace ALSL_HRM_System.Forms
{
    partial class frmServiceExtendRequest
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
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceExtReqID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReqMonths = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvServiceExtendRequest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceExtendRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(325, 36);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(158, 21);
            this.cmbEmployeeID.TabIndex = 76;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            this.cmbEmployeeID.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(105, 92);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(271, 20);
            this.txtFullName.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Employee No";
            // 
            // txtServiceExtReqID
            // 
            this.txtServiceExtReqID.Location = new System.Drawing.Point(105, 36);
            this.txtServiceExtReqID.Name = "txtServiceExtReqID";
            this.txtServiceExtReqID.Size = new System.Drawing.Size(171, 20);
            this.txtServiceExtReqID.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Service Extend Requst ID";
            // 
            // txtReqMonths
            // 
            this.txtReqMonths.Location = new System.Drawing.Point(400, 92);
            this.txtReqMonths.Name = "txtReqMonths";
            this.txtReqMonths.Size = new System.Drawing.Size(181, 20);
            this.txtReqMonths.TabIndex = 73;
            this.txtReqMonths.TextChanged += new System.EventHandler(this.txtTextChange_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Extend Duration Requested";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Months";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Save1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Populate;
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 72);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 80;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.HomeExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.New;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 112);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 76;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 272);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvServiceExtendRequest
            // 
            this.dgvServiceExtendRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceExtendRequest.Location = new System.Drawing.Point(105, 143);
            this.dgvServiceExtendRequest.Name = "dgvServiceExtendRequest";
            this.dgvServiceExtendRequest.Size = new System.Drawing.Size(573, 217);
            this.dgvServiceExtendRequest.TabIndex = 82;
            this.dgvServiceExtendRequest.SelectionChanged += new System.EventHandler(this.dgvServiceExtendRequest_SelectionChanged);
            // 
            // frmServiceExtendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 393);
            this.Controls.Add(this.dgvServiceExtendRequest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbEmployeeID);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReqMonths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServiceExtReqID);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmServiceExtendRequest";
            this.Text = "Service Extend Request Details";
            this.Load += new System.EventHandler(this.frmServiceExtendRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceExtendRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServiceExtReqID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReqMonths;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvServiceExtendRequest;
    }
}