namespace ALSL_HRM_System.Forms
{
    partial class frmDesignationDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignationID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtDesignationDescription = new System.Windows.Forms.TextBox();
            this.txtOTRate = new System.Windows.Forms.TextBox();
            this.txtMaxLoanValue = new System.Windows.Forms.TextBox();
            this.dgvDesignationDetails = new System.Windows.Forms.DataGridView();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(650, 66);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designation ID";
            // 
            // txtDesignationID
            // 
            this.txtDesignationID.Location = new System.Drawing.Point(15, 40);
            this.txtDesignationID.Name = "txtDesignationID";
            this.txtDesignationID.Size = new System.Drawing.Size(175, 20);
            this.txtDesignationID.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(650, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(650, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(650, 37);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 5;
            this.btnPopulate.Text = "Populate ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(650, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max Loan Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "OT Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Designation Description";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Location = new System.Drawing.Point(14, 98);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(176, 20);
            this.txtBasicSalary.TabIndex = 11;
            // 
            // txtDesignationDescription
            // 
            this.txtDesignationDescription.Location = new System.Drawing.Point(210, 40);
            this.txtDesignationDescription.Name = "txtDesignationDescription";
            this.txtDesignationDescription.Size = new System.Drawing.Size(376, 20);
            this.txtDesignationDescription.TabIndex = 12;
            // 
            // txtOTRate
            // 
            this.txtOTRate.Location = new System.Drawing.Point(210, 98);
            this.txtOTRate.Name = "txtOTRate";
            this.txtOTRate.Size = new System.Drawing.Size(174, 20);
            this.txtOTRate.TabIndex = 13;
            // 
            // txtMaxLoanValue
            // 
            this.txtMaxLoanValue.Location = new System.Drawing.Point(405, 99);
            this.txtMaxLoanValue.Name = "txtMaxLoanValue";
            this.txtMaxLoanValue.Size = new System.Drawing.Size(181, 20);
            this.txtMaxLoanValue.TabIndex = 14;
            // 
            // dgvDesignationDetails
            // 
            this.dgvDesignationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignationDetails.Location = new System.Drawing.Point(14, 146);
            this.dgvDesignationDetails.Name = "dgvDesignationDetails";
            this.dgvDesignationDetails.Size = new System.Drawing.Size(572, 214);
            this.dgvDesignationDetails.TabIndex = 16;
            this.dgvDesignationDetails.SelectionChanged += new System.EventHandler(this.dgvDesignationDetails_SelectionChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(650, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDesignationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 382);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvDesignationDetails);
            this.Controls.Add(this.txtMaxLoanValue);
            this.Controls.Add(this.txtOTRate);
            this.Controls.Add(this.txtDesignationDescription);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDesignationID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmDesignationDetails";
            this.Text = "Designation Details";
            this.Load += new System.EventHandler(this.frmDesignationDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignationDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void dgvDesignationDetails_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesignationID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtDesignationDescription;
        private System.Windows.Forms.TextBox txtOTRate;
        private System.Windows.Forms.TextBox txtMaxLoanValue;
        private System.Windows.Forms.DataGridView dgvDesignationDetails;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
    }
}

