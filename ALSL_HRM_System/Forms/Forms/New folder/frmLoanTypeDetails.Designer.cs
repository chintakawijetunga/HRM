namespace ALSL_HRM_System.Forms
{
    partial class frmLoanTypeDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoanTypeDescripton = new System.Windows.Forms.TextBox();
            this.txtLoanTypeNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvLoanTypeDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTypeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loan Type Description";
            // 
            // txtLoanTypeDescripton
            // 
            this.txtLoanTypeDescripton.Location = new System.Drawing.Point(173, 47);
            this.txtLoanTypeDescripton.Name = "txtLoanTypeDescripton";
            this.txtLoanTypeDescripton.Size = new System.Drawing.Size(133, 20);
            this.txtLoanTypeDescripton.TabIndex = 11;
            // 
            // txtLoanTypeNumber
            // 
            this.txtLoanTypeNumber.Location = new System.Drawing.Point(11, 47);
            this.txtLoanTypeNumber.Name = "txtLoanTypeNumber";
            this.txtLoanTypeNumber.Size = new System.Drawing.Size(132, 20);
            this.txtLoanTypeNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loan Type Number";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(386, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(386, 27);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 39;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(386, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(386, 56);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvLoanTypeDetails
            // 
            this.dgvLoanTypeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanTypeDetails.Location = new System.Drawing.Point(12, 94);
            this.dgvLoanTypeDetails.Name = "dgvLoanTypeDetails";
            this.dgvLoanTypeDetails.Size = new System.Drawing.Size(294, 150);
            this.dgvLoanTypeDetails.TabIndex = 41;
            this.dgvLoanTypeDetails.SelectionChanged += new System.EventHandler(this.dgvLoanTypeDetails_SelectionChanged);
            // 
            // frmLoanTypeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 279);
            this.Controls.Add(this.dgvLoanTypeDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoanTypeDescripton);
            this.Controls.Add(this.txtLoanTypeNumber);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLoanTypeDetails";
            this.Text = "frmLoanTypeDetails";
            this.Load += new System.EventHandler(this.frmLoanTypeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTypeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoanTypeDescripton;
        private System.Windows.Forms.TextBox txtLoanTypeNumber;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvLoanTypeDetails;
    }
}