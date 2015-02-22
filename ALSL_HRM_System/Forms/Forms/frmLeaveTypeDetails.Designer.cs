namespace ALSL_HRM_System.Forms
{
    partial class frmLeaveTypeDetails
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeaveTypeDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeaveTypeNo = new System.Windows.Forms.TextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dgvLeaveTypeDetails = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Leave Type Code";
            // 
            // txtLeaveTypeDescription
            // 
            this.txtLeaveTypeDescription.Location = new System.Drawing.Point(249, 53);
            this.txtLeaveTypeDescription.Name = "txtLeaveTypeDescription";
            this.txtLeaveTypeDescription.Size = new System.Drawing.Size(246, 20);
            this.txtLeaveTypeDescription.TabIndex = 78;
            this.txtLeaveTypeDescription.TextChanged += new System.EventHandler(this.txtLeaveTypeDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Leave Type Description";
            // 
            // txtLeaveTypeNo
            // 
            this.txtLeaveTypeNo.Location = new System.Drawing.Point(82, 52);
            this.txtLeaveTypeNo.Name = "txtLeaveTypeNo";
            this.txtLeaveTypeNo.Size = new System.Drawing.Size(143, 20);
            this.txtLeaveTypeNo.TabIndex = 80;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // dgvLeaveTypeDetails
            // 
            this.dgvLeaveTypeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveTypeDetails.Location = new System.Drawing.Point(82, 107);
            this.dgvLeaveTypeDetails.Name = "dgvLeaveTypeDetails";
            this.dgvLeaveTypeDetails.Size = new System.Drawing.Size(413, 215);
            this.dgvLeaveTypeDetails.TabIndex = 90;
            this.dgvLeaveTypeDetails.SelectionChanged += new System.EventHandler(this.dgvLeaveTypeDetails_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 82);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 96;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 95;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 94;
            this.btnClear.Text = " ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 93;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 122);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 92;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 282);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmLeaveTypeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 368);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvLeaveTypeDetails);
            this.Controls.Add(this.txtLeaveTypeNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLeaveTypeDescription);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLeaveTypeDetails";
            this.Text = "Leave Type Details";
            this.Load += new System.EventHandler(this.frmLeaveTypeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeaveTypeDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeaveTypeNo;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.DataGridView dgvLeaveTypeDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
    }
}