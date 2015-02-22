namespace ALSL_HRM_System.Forms
{
    partial class frmVacancyData
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
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVacancyDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAvailableVacancies = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancyDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Designation";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(79, 54);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(211, 21);
            this.cmbDepartment.TabIndex = 25;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSelectionChanged_SelectedIndexChanged);
            this.cmbDepartment.TextChanged += new System.EventHandler(this.controlValue_TextChanged);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(330, 54);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(211, 21);
            this.cmbDesignation.TabIndex = 26;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbSelectionChanged_SelectedIndexChanged);
            this.cmbDesignation.TextChanged += new System.EventHandler(this.controlValue_TextChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Save1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 104;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Populate;
            this.btnPopulate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopulate.Location = new System.Drawing.Point(12, 79);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(40, 40);
            this.btnPopulate.TabIndex = 103;
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(12, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(12, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 101;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.HomeExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 100;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.New;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.Location = new System.Drawing.Point(12, 119);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 40);
            this.btnAddNew.TabIndex = 99;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(12, 279);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 98;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvVacancyDetails
            // 
            this.dgvVacancyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancyDetails.Location = new System.Drawing.Point(80, 182);
            this.dgvVacancyDetails.Name = "dgvVacancyDetails";
            this.dgvVacancyDetails.Size = new System.Drawing.Size(461, 187);
            this.dgvVacancyDetails.TabIndex = 97;
            this.dgvVacancyDetails.SelectionChanged += new System.EventHandler(this.dgvVacancyDetails_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Vacancies Available";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(79, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(211, 52);
            this.txtDescription.TabIndex = 29;
            this.txtDescription.TextChanged += new System.EventHandler(this.controlValue_TextChanged);
            // 
            // txtAvailableVacancies
            // 
            this.txtAvailableVacancies.Location = new System.Drawing.Point(331, 110);
            this.txtAvailableVacancies.Name = "txtAvailableVacancies";
            this.txtAvailableVacancies.Size = new System.Drawing.Size(161, 20);
            this.txtAvailableVacancies.TabIndex = 30;
            this.txtAvailableVacancies.TextChanged += new System.EventHandler(this.controlValue_TextChanged);
            // 
            // frmVacancyData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 384);
            this.Controls.Add(this.txtAvailableVacancies);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvVacancyDetails);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmVacancyData";
            this.Text = "Vacancy Details";
            this.Load += new System.EventHandler(this.frmVacancyData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancyDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVacancyDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAvailableVacancies;
    }
}