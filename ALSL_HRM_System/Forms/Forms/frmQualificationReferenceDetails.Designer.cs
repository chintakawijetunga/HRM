namespace ALSL_HRM_System.Forms
{
    partial class frmQualificationReferenceDetails
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
            this.txtQualificationDescription = new System.Windows.Forms.TextBox();
            this.txtQualificationRefNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.AdditionalDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dgvQualificationRefDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualificationRefDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Qualification Description";
            // 
            // txtQualificationDescription
            // 
            this.txtQualificationDescription.Location = new System.Drawing.Point(282, 59);
            this.txtQualificationDescription.Name = "txtQualificationDescription";
            this.txtQualificationDescription.Size = new System.Drawing.Size(218, 20);
            this.txtQualificationDescription.TabIndex = 21;
            this.txtQualificationDescription.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // txtQualificationRefNo
            // 
            this.txtQualificationRefNo.Location = new System.Drawing.Point(102, 59);
            this.txtQualificationRefNo.Name = "txtQualificationRefNo";
            this.txtQualificationRefNo.Size = new System.Drawing.Size(143, 20);
            this.txtQualificationRefNo.TabIndex = 20;
            this.txtQualificationRefNo.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Qualificaton No";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = " ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 81);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 39;
            this.btnPopulate.Text = " ";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = " ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 37;
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
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 121);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 35;
            this.btnAddNew.Text = " ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 281);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AdditionalDetails
            // 
            this.AdditionalDetails.AutoSize = true;
            this.AdditionalDetails.Location = new System.Drawing.Point(99, 101);
            this.AdditionalDetails.Name = "AdditionalDetails";
            this.AdditionalDetails.Size = new System.Drawing.Size(100, 13);
            this.AdditionalDetails.TabIndex = 42;
            this.AdditionalDetails.Text = "Qualification Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(102, 117);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(398, 66);
            this.txtDetails.TabIndex = 41;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtBoxes_TextChanged);
            // 
            // dgvQualificationRefDetails
            // 
            this.dgvQualificationRefDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualificationRefDetails.Location = new System.Drawing.Point(103, 218);
            this.dgvQualificationRefDetails.Name = "dgvQualificationRefDetails";
            this.dgvQualificationRefDetails.Size = new System.Drawing.Size(397, 165);
            this.dgvQualificationRefDetails.TabIndex = 43;
            this.dgvQualificationRefDetails.SelectionChanged += new System.EventHandler(this.dvgQualificationRefDetails_SelectionChanged);
            // 
            // frmQualificationReferenceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 437);
            this.Controls.Add(this.dgvQualificationRefDetails);
            this.Controls.Add(this.AdditionalDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQualificationDescription);
            this.Controls.Add(this.txtQualificationRefNo);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmQualificationReferenceDetails";
            this.Text = "Qualification Reference Details";
            this.Load += new System.EventHandler(this.frmQualificationReferenceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualificationRefDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQualificationDescription;
        private System.Windows.Forms.TextBox txtQualificationRefNo;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label AdditionalDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DataGridView dgvQualificationRefDetails;
    }
}