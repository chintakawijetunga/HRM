﻿namespace ALSL_HRM_System.Forms
{
    partial class frmSalaryIncrementDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalaryIncrementID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalIncrReqID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequestAmount = new System.Windows.Forms.TextBox();
            this.grpIncrementDetails = new System.Windows.Forms.GroupBox();
            this.txtIncrementAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.dgvSalaryIncrementDetails = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpIncrementDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryIncrementDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Increment ID";
            // 
            // txtSalaryIncrementID
            // 
            this.txtSalaryIncrementID.Location = new System.Drawing.Point(15, 42);
            this.txtSalaryIncrementID.Name = "txtSalaryIncrementID";
            this.txtSalaryIncrementID.Size = new System.Drawing.Size(144, 20);
            this.txtSalaryIncrementID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary Increment Request ID";
            // 
            // cmbSalIncrReqID
            // 
            this.cmbSalIncrReqID.FormattingEnabled = true;
            this.cmbSalIncrReqID.Location = new System.Drawing.Point(202, 43);
            this.cmbSalIncrReqID.Name = "cmbSalIncrReqID";
            this.cmbSalIncrReqID.Size = new System.Drawing.Size(144, 21);
            this.cmbSalIncrReqID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(386, 42);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(261, 20);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Request Amount";
            // 
            // txtRequestAmount
            // 
            this.txtRequestAmount.Location = new System.Drawing.Point(7, 75);
            this.txtRequestAmount.Name = "txtRequestAmount";
            this.txtRequestAmount.Size = new System.Drawing.Size(141, 20);
            this.txtRequestAmount.TabIndex = 7;
            // 
            // grpIncrementDetails
            // 
            this.grpIncrementDetails.Controls.Add(this.txtIncrementAmt);
            this.grpIncrementDetails.Controls.Add(this.label5);
            this.grpIncrementDetails.Controls.Add(this.rbtNo);
            this.grpIncrementDetails.Controls.Add(this.rbtYes);
            this.grpIncrementDetails.Controls.Add(this.txtRequestAmount);
            this.grpIncrementDetails.Controls.Add(this.label4);
            this.grpIncrementDetails.Location = new System.Drawing.Point(15, 92);
            this.grpIncrementDetails.Name = "grpIncrementDetails";
            this.grpIncrementDetails.Size = new System.Drawing.Size(351, 122);
            this.grpIncrementDetails.TabIndex = 8;
            this.grpIncrementDetails.TabStop = false;
            this.grpIncrementDetails.Text = "Increment Details";
            // 
            // txtIncrementAmt
            // 
            this.txtIncrementAmt.Location = new System.Drawing.Point(190, 75);
            this.txtIncrementAmt.Name = "txtIncrementAmt";
            this.txtIncrementAmt.Size = new System.Drawing.Size(141, 20);
            this.txtIncrementAmt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Increment Amount";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(105, 28);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(23, 28);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            // 
            // dgvSalaryIncrementDetails
            // 
            this.dgvSalaryIncrementDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryIncrementDetails.Location = new System.Drawing.Point(15, 267);
            this.dgvSalaryIncrementDetails.Name = "dgvSalaryIncrementDetails";
            this.dgvSalaryIncrementDetails.Size = new System.Drawing.Size(632, 180);
            this.dgvSalaryIncrementDetails.TabIndex = 9;
            this.dgvSalaryIncrementDetails.SelectionChanged += new System.EventHandler(this.dgvSalaryIncrementDetails_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(927, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(927, 151);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 39;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(927, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(927, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(927, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(927, 180);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(927, 296);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSalaryIncrementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 520);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSalaryIncrementDetails);
            this.Controls.Add(this.grpIncrementDetails);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSalIncrReqID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalaryIncrementID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmSalaryIncrementDetails";
            this.Text = "frmSalaryIncrementDetails";
            this.Load += new System.EventHandler(this.frmSalaryIncrementDetails_Load);
            this.grpIncrementDetails.ResumeLayout(false);
            this.grpIncrementDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryIncrementDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalaryIncrementID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSalIncrReqID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRequestAmount;
        private System.Windows.Forms.GroupBox grpIncrementDetails;
        private System.Windows.Forms.TextBox txtIncrementAmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.DataGridView dgvSalaryIncrementDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
    }
}