namespace ALSL_HRM_System.Forms
{
    partial class frmDepartmentDetails
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDepartmentDetails = new System.Windows.Forms.DataGridView();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(857, 53);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(15, 41);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(160, 20);
            this.txtDepartmentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fax No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(394, 41);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(184, 20);
            this.txtTelephoneNo.TabIndex = 8;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(602, 41);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(190, 20);
            this.txtFaxNo.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(394, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(398, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(195, 41);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(170, 20);
            this.txtDepartment.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(857, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(857, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(857, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(857, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvDepartmentDetails
            // 
            this.dgvDepartmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentDetails.Location = new System.Drawing.Point(12, 139);
            this.dgvDepartmentDetails.Name = "dgvDepartmentDetails";
            this.dgvDepartmentDetails.Size = new System.Drawing.Size(780, 215);
            this.dgvDepartmentDetails.TabIndex = 18;
            this.dgvDepartmentDetails.SelectionChanged += new System.EventHandler(this.dgvDepartmentDetails_SelectionChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(857, 24);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 33;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(857, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 373);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.dgvDepartmentDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.txtTelephoneNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.btnAddNew);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmDepartmentDetails";
            this.Text = "Department_Details";
            this.Load += new System.EventHandler(this.frmDepartmentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDepartmentDetails;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnSave;
    }
}