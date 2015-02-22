namespace ALSL_HRM_System.Forms
{
    partial class frmBankDetails
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
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtBankBranchNo = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtBankBranch = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBankDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBankID
            // 
            this.txtBankID.Location = new System.Drawing.Point(20, 44);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(110, 20);
            this.txtBankID.TabIndex = 1;
            this.txtBankID.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bank Branch No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bank Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telephone No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fax No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Email Address";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(863, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(156, 44);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(165, 20);
            this.txtBank.TabIndex = 17;
            this.txtBank.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtBankBranchNo
            // 
            this.txtBankBranchNo.Location = new System.Drawing.Point(338, 44);
            this.txtBankBranchNo.Name = "txtBankBranchNo";
            this.txtBankBranchNo.Size = new System.Drawing.Size(83, 20);
            this.txtBankBranchNo.TabIndex = 18;
            this.txtBankBranchNo.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(20, 91);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(110, 20);
            this.txtAddress1.TabIndex = 19;
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.Location = new System.Drawing.Point(443, 44);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Size = new System.Drawing.Size(117, 20);
            this.txtBankBranch.TabIndex = 20;
            this.txtBankBranch.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(582, 91);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(231, 20);
            this.txtEmailAddress.TabIndex = 21;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(156, 91);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(165, 20);
            this.txtAddress2.TabIndex = 22;
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtAddress3
            // 
            this.txtAddress3.Location = new System.Drawing.Point(338, 91);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(222, 20);
            this.txtAddress3.TabIndex = 23;
            this.txtAddress3.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(582, 44);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(116, 20);
            this.txtTelephoneNo.TabIndex = 24;
            this.txtTelephoneNo.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.Location = new System.Drawing.Point(716, 44);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(97, 20);
            this.txtFaxNo.TabIndex = 25;
            this.txtFaxNo.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(863, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(863, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(863, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(863, 44);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 26;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(863, 15);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 32;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(863, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBankDetails
            // 
            this.dgvBankDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankDetails.Location = new System.Drawing.Point(20, 132);
            this.dgvBankDetails.Name = "dgvBankDetails";
            this.dgvBankDetails.Size = new System.Drawing.Size(793, 169);
            this.dgvBankDetails.TabIndex = 34;
            this.dgvBankDetails.SelectionChanged += new System.EventHandler(this.dgvBankDetails_SelectionChanged);
            // 
            // frmBankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 363);
            this.Controls.Add(this.dgvBankDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBankBranchNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBankBranch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFaxNo);
            this.Controls.Add(this.txtBankID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelephoneNo);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmBankDetails";
            this.Load += new System.EventHandler(this.frmBankDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtBankBranchNo;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtBankBranch;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvBankDetails;
    }
}