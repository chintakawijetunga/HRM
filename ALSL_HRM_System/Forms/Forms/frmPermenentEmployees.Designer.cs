namespace ALSL_HRM_System.Forms
{
    partial class frmPermenentEmployees
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.rbtMarried = new System.Windows.Forms.RadioButton();
            this.rbtSingle = new System.Windows.Forms.RadioButton();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabCommunication = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtAddressLine3 = new System.Windows.Forms.TextBox();
            this.tabQualification = new System.Windows.Forms.TabPage();
            this.txtSpecialNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpQualifications = new System.Windows.Forms.GroupBox();
            this.dgvQualifications = new System.Windows.Forms.DataGridView();
            this.colsQualificatrions = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colsQualificationDescriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtPreviousExperiances = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPreviousExperiances = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.tabBank = new System.Windows.Forms.TabPage();
            this.dtpProbationDate = new System.Windows.Forms.DateTimePicker();
            this.ProbationDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtNoExtend = new System.Windows.Forms.RadioButton();
            this.lblExtend = new System.Windows.Forms.Label();
            this.rbtYesExtend = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtNoProbation = new System.Windows.Forms.RadioButton();
            this.lblOnProbation = new System.Windows.Forms.Label();
            this.rbtYesProbation = new System.Windows.Forms.RadioButton();
            this.dtpRetirementDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeDate = new System.Windows.Forms.DateTimePicker();
            this.lblRetirementDate = new System.Windows.Forms.Label();
            this.lblEmployeeDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.rbtYesActive = new System.Windows.Forms.RadioButton();
            this.rbtNoActive = new System.Windows.Forms.RadioButton();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtETFNo = new System.Windows.Forms.TextBox();
            this.lblETFNo = new System.Windows.Forms.Label();
            this.txtBankAccountNo = new System.Windows.Forms.TextBox();
            this.txtEPFNo = new System.Windows.Forms.TextBox();
            this.lblBankAccountNo = new System.Windows.Forms.Label();
            this.lblEPFNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.lblApplicantNo = new System.Windows.Forms.Label();
            this.dgvPermenentEmployee = new System.Windows.Forms.DataGridView();
            this.cmbApplicantNo = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCommunication.SuspendLayout();
            this.tabQualification.SuspendLayout();
            this.grpQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).BeginInit();
            this.tabBank.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermenentEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabCommunication);
            this.tabControl1.Controls.Add(this.tabQualification);
            this.tabControl1.Controls.Add(this.tabBank);
            this.tabControl1.Location = new System.Drawing.Point(99, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabGeneral.Controls.Add(this.panel1);
            this.tabGeneral.Controls.Add(this.dtpEmpDOB);
            this.tabGeneral.Controls.Add(this.rbtMarried);
            this.tabGeneral.Controls.Add(this.rbtSingle);
            this.tabGeneral.Controls.Add(this.txtNICNo);
            this.tabGeneral.Controls.Add(this.label15);
            this.tabGeneral.Controls.Add(this.label11);
            this.tabGeneral.Controls.Add(this.label10);
            this.tabGeneral.Controls.Add(this.label9);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(622, 195);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Location = new System.Drawing.Point(2, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 57;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(119, 3);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 45;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(24, 3);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 42;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Location = new System.Drawing.Point(222, 35);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(203, 20);
            this.dtpEmpDOB.TabIndex = 56;
            // 
            // rbtMarried
            // 
            this.rbtMarried.AutoSize = true;
            this.rbtMarried.Location = new System.Drawing.Point(324, 97);
            this.rbtMarried.Name = "rbtMarried";
            this.rbtMarried.Size = new System.Drawing.Size(60, 17);
            this.rbtMarried.TabIndex = 55;
            this.rbtMarried.Text = "Married";
            this.rbtMarried.UseVisualStyleBackColor = true;
            // 
            // rbtSingle
            // 
            this.rbtSingle.AutoSize = true;
            this.rbtSingle.Checked = true;
            this.rbtSingle.Location = new System.Drawing.Point(229, 97);
            this.rbtSingle.Name = "rbtSingle";
            this.rbtSingle.Size = new System.Drawing.Size(54, 17);
            this.rbtSingle.TabIndex = 54;
            this.rbtSingle.TabStop = true;
            this.rbtSingle.Text = "Single";
            this.rbtSingle.UseVisualStyleBackColor = true;
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(25, 35);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(175, 20);
            this.txtNICNo.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Date of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Civil Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "NIC No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Gender";
            // 
            // tabCommunication
            // 
            this.tabCommunication.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabCommunication.Controls.Add(this.label18);
            this.tabCommunication.Controls.Add(this.txtEmailAddress);
            this.tabCommunication.Controls.Add(this.label17);
            this.tabCommunication.Controls.Add(this.txtMobileNo);
            this.tabCommunication.Controls.Add(this.txtAddressLine1);
            this.tabCommunication.Controls.Add(this.label5);
            this.tabCommunication.Controls.Add(this.label6);
            this.tabCommunication.Controls.Add(this.label7);
            this.tabCommunication.Controls.Add(this.label8);
            this.tabCommunication.Controls.Add(this.txtAddressLine2);
            this.tabCommunication.Controls.Add(this.txtTelephoneNo);
            this.tabCommunication.Controls.Add(this.txtAddressLine3);
            this.tabCommunication.Location = new System.Drawing.Point(4, 22);
            this.tabCommunication.Name = "tabCommunication";
            this.tabCommunication.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommunication.Size = new System.Drawing.Size(622, 195);
            this.tabCommunication.TabIndex = 1;
            this.tabCommunication.Text = "Communication";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(366, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(369, 120);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(234, 20);
            this.txtEmailAddress.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(171, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(174, 120);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(175, 20);
            this.txtMobileNo.TabIndex = 32;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(14, 24);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(197, 20);
            this.txtAddressLine1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address Line1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address Line2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Address Line3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Telephone No";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(243, 24);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(208, 20);
            this.txtAddressLine2.TabIndex = 28;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(14, 120);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(137, 20);
            this.txtTelephoneNo.TabIndex = 29;
            // 
            // txtAddressLine3
            // 
            this.txtAddressLine3.Location = new System.Drawing.Point(14, 69);
            this.txtAddressLine3.Name = "txtAddressLine3";
            this.txtAddressLine3.Size = new System.Drawing.Size(437, 20);
            this.txtAddressLine3.TabIndex = 30;
            // 
            // tabQualification
            // 
            this.tabQualification.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabQualification.Controls.Add(this.txtSpecialNotes);
            this.tabQualification.Controls.Add(this.label1);
            this.tabQualification.Controls.Add(this.grpQualifications);
            this.tabQualification.Controls.Add(this.cmbDepartment);
            this.tabQualification.Controls.Add(this.cmbDesignation);
            this.tabQualification.Controls.Add(this.txtPreviousExperiances);
            this.tabQualification.Controls.Add(this.lblDepartment);
            this.tabQualification.Controls.Add(this.lblPreviousExperiances);
            this.tabQualification.Controls.Add(this.lblDesignation);
            this.tabQualification.Location = new System.Drawing.Point(4, 22);
            this.tabQualification.Name = "tabQualification";
            this.tabQualification.Padding = new System.Windows.Forms.Padding(3);
            this.tabQualification.Size = new System.Drawing.Size(622, 195);
            this.tabQualification.TabIndex = 2;
            this.tabQualification.Text = "Qualification, Position and Experience";
            // 
            // txtSpecialNotes
            // 
            this.txtSpecialNotes.Location = new System.Drawing.Point(25, 169);
            this.txtSpecialNotes.Name = "txtSpecialNotes";
            this.txtSpecialNotes.Size = new System.Drawing.Size(287, 20);
            this.txtSpecialNotes.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Special Notes";
            // 
            // grpQualifications
            // 
            this.grpQualifications.Controls.Add(this.dgvQualifications);
            this.grpQualifications.Location = new System.Drawing.Point(333, 16);
            this.grpQualifications.Name = "grpQualifications";
            this.grpQualifications.Size = new System.Drawing.Size(271, 166);
            this.grpQualifications.TabIndex = 134;
            this.grpQualifications.TabStop = false;
            this.grpQualifications.Text = "Qualifications";
            // 
            // dgvQualifications
            // 
            this.dgvQualifications.AllowUserToOrderColumns = true;
            this.dgvQualifications.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colsQualificatrions,
            this.colsQualificationDescriptions});
            this.dgvQualifications.Location = new System.Drawing.Point(17, 25);
            this.dgvQualifications.Name = "dgvQualifications";
            this.dgvQualifications.Size = new System.Drawing.Size(248, 135);
            this.dgvQualifications.TabIndex = 69;
            // 
            // colsQualificatrions
            // 
            this.colsQualificatrions.DropDownHeight = 106;
            this.colsQualificatrions.DropDownWidth = 97;
            this.colsQualificatrions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colsQualificatrions.FormattingEnabled = true;
            this.colsQualificatrions.HeaderText = "Qualification";
            this.colsQualificatrions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colsQualificatrions.IntegralHeight = false;
            this.colsQualificatrions.ItemHeight = 13;
            this.colsQualificatrions.Name = "colsQualificatrions";
            this.colsQualificatrions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsQualificatrions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colsQualificationDescriptions
            // 
            this.colsQualificationDescriptions.HeaderText = "Qualification Description";
            this.colsQualificationDescriptions.Name = "colsQualificationDescriptions";
            this.colsQualificationDescriptions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(25, 25);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(163, 21);
            this.cmbDepartment.TabIndex = 131;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(25, 74);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(163, 21);
            this.cmbDesignation.TabIndex = 130;
            // 
            // txtPreviousExperiances
            // 
            this.txtPreviousExperiances.Location = new System.Drawing.Point(25, 122);
            this.txtPreviousExperiances.Name = "txtPreviousExperiances";
            this.txtPreviousExperiances.Size = new System.Drawing.Size(163, 20);
            this.txtPreviousExperiances.TabIndex = 128;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(22, 9);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 126;
            this.lblDepartment.Text = "Department";
            // 
            // lblPreviousExperiances
            // 
            this.lblPreviousExperiances.AutoSize = true;
            this.lblPreviousExperiances.Location = new System.Drawing.Point(22, 106);
            this.lblPreviousExperiances.Name = "lblPreviousExperiances";
            this.lblPreviousExperiances.Size = new System.Drawing.Size(109, 13);
            this.lblPreviousExperiances.TabIndex = 125;
            this.lblPreviousExperiances.Text = "Previous Experiances";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(22, 56);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 124;
            this.lblDesignation.Text = "Designation";
            // 
            // tabBank
            // 
            this.tabBank.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabBank.Controls.Add(this.dtpProbationDate);
            this.tabBank.Controls.Add(this.ProbationDate);
            this.tabBank.Controls.Add(this.panel3);
            this.tabBank.Controls.Add(this.panel2);
            this.tabBank.Controls.Add(this.dtpRetirementDate);
            this.tabBank.Controls.Add(this.dtpEmployeeDate);
            this.tabBank.Controls.Add(this.lblRetirementDate);
            this.tabBank.Controls.Add(this.lblEmployeeDate);
            this.tabBank.Controls.Add(this.label2);
            this.tabBank.Controls.Add(this.cmbBank);
            this.tabBank.Controls.Add(this.rbtYesActive);
            this.tabBank.Controls.Add(this.rbtNoActive);
            this.tabBank.Controls.Add(this.lblActive);
            this.tabBank.Controls.Add(this.txtETFNo);
            this.tabBank.Controls.Add(this.lblETFNo);
            this.tabBank.Controls.Add(this.txtBankAccountNo);
            this.tabBank.Controls.Add(this.txtEPFNo);
            this.tabBank.Controls.Add(this.lblBankAccountNo);
            this.tabBank.Controls.Add(this.lblEPFNo);
            this.tabBank.Location = new System.Drawing.Point(4, 22);
            this.tabBank.Name = "tabBank";
            this.tabBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabBank.Size = new System.Drawing.Size(622, 195);
            this.tabBank.TabIndex = 3;
            this.tabBank.Text = "Financial and Other Details";
            // 
            // dtpProbationDate
            // 
            this.dtpProbationDate.Location = new System.Drawing.Point(396, 114);
            this.dtpProbationDate.Name = "dtpProbationDate";
            this.dtpProbationDate.Size = new System.Drawing.Size(196, 20);
            this.dtpProbationDate.TabIndex = 148;
            // 
            // ProbationDate
            // 
            this.ProbationDate.AutoSize = true;
            this.ProbationDate.Location = new System.Drawing.Point(393, 98);
            this.ProbationDate.Name = "ProbationDate";
            this.ProbationDate.Size = new System.Drawing.Size(78, 13);
            this.ProbationDate.TabIndex = 147;
            this.ProbationDate.Text = "Probation Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtNoExtend);
            this.panel3.Controls.Add(this.lblExtend);
            this.panel3.Controls.Add(this.rbtYesExtend);
            this.panel3.Location = new System.Drawing.Point(173, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 52);
            this.panel3.TabIndex = 146;
            // 
            // rbtNoExtend
            // 
            this.rbtNoExtend.AutoSize = true;
            this.rbtNoExtend.Location = new System.Drawing.Point(74, 23);
            this.rbtNoExtend.Name = "rbtNoExtend";
            this.rbtNoExtend.Size = new System.Drawing.Size(39, 17);
            this.rbtNoExtend.TabIndex = 138;
            this.rbtNoExtend.Text = "No";
            this.rbtNoExtend.UseVisualStyleBackColor = true;
            // 
            // lblExtend
            // 
            this.lblExtend.AutoSize = true;
            this.lblExtend.Location = new System.Drawing.Point(10, 5);
            this.lblExtend.Name = "lblExtend";
            this.lblExtend.Size = new System.Drawing.Size(40, 13);
            this.lblExtend.TabIndex = 133;
            this.lblExtend.Text = "Extend";
            // 
            // rbtYesExtend
            // 
            this.rbtYesExtend.AutoSize = true;
            this.rbtYesExtend.Checked = true;
            this.rbtYesExtend.Location = new System.Drawing.Point(13, 23);
            this.rbtYesExtend.Name = "rbtYesExtend";
            this.rbtYesExtend.Size = new System.Drawing.Size(43, 17);
            this.rbtYesExtend.TabIndex = 137;
            this.rbtYesExtend.TabStop = true;
            this.rbtYesExtend.Text = "Yes";
            this.rbtYesExtend.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtNoProbation);
            this.panel2.Controls.Add(this.lblOnProbation);
            this.panel2.Controls.Add(this.rbtYesProbation);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 45);
            this.panel2.TabIndex = 145;
            // 
            // rbtNoProbation
            // 
            this.rbtNoProbation.AutoSize = true;
            this.rbtNoProbation.Location = new System.Drawing.Point(65, 20);
            this.rbtNoProbation.Name = "rbtNoProbation";
            this.rbtNoProbation.Size = new System.Drawing.Size(39, 17);
            this.rbtNoProbation.TabIndex = 130;
            this.rbtNoProbation.Text = "No";
            this.rbtNoProbation.UseVisualStyleBackColor = true;
            // 
            // lblOnProbation
            // 
            this.lblOnProbation.AutoSize = true;
            this.lblOnProbation.Location = new System.Drawing.Point(2, 4);
            this.lblOnProbation.Name = "lblOnProbation";
            this.lblOnProbation.Size = new System.Drawing.Size(69, 13);
            this.lblOnProbation.TabIndex = 125;
            this.lblOnProbation.Text = "On Probation";
            // 
            // rbtYesProbation
            // 
            this.rbtYesProbation.AutoSize = true;
            this.rbtYesProbation.Checked = true;
            this.rbtYesProbation.Location = new System.Drawing.Point(5, 20);
            this.rbtYesProbation.Name = "rbtYesProbation";
            this.rbtYesProbation.Size = new System.Drawing.Size(43, 17);
            this.rbtYesProbation.TabIndex = 129;
            this.rbtYesProbation.TabStop = true;
            this.rbtYesProbation.Text = "Yes";
            this.rbtYesProbation.UseVisualStyleBackColor = true;
            // 
            // dtpRetirementDate
            // 
            this.dtpRetirementDate.Location = new System.Drawing.Point(396, 68);
            this.dtpRetirementDate.Name = "dtpRetirementDate";
            this.dtpRetirementDate.Size = new System.Drawing.Size(196, 20);
            this.dtpRetirementDate.TabIndex = 144;
            // 
            // dtpEmployeeDate
            // 
            this.dtpEmployeeDate.Location = new System.Drawing.Point(396, 23);
            this.dtpEmployeeDate.Name = "dtpEmployeeDate";
            this.dtpEmployeeDate.Size = new System.Drawing.Size(196, 20);
            this.dtpEmployeeDate.TabIndex = 141;
            // 
            // lblRetirementDate
            // 
            this.lblRetirementDate.AutoSize = true;
            this.lblRetirementDate.Location = new System.Drawing.Point(393, 52);
            this.lblRetirementDate.Name = "lblRetirementDate";
            this.lblRetirementDate.Size = new System.Drawing.Size(84, 13);
            this.lblRetirementDate.TabIndex = 143;
            this.lblRetirementDate.Text = "Retirement Date";
            // 
            // lblEmployeeDate
            // 
            this.lblEmployeeDate.AutoSize = true;
            this.lblEmployeeDate.Location = new System.Drawing.Point(393, 7);
            this.lblEmployeeDate.Name = "lblEmployeeDate";
            this.lblEmployeeDate.Size = new System.Drawing.Size(79, 13);
            this.lblEmployeeDate.TabIndex = 142;
            this.lblEmployeeDate.Text = "Employee Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Bank";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(15, 67);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(148, 21);
            this.cmbBank.TabIndex = 139;
            // 
            // rbtYesActive
            // 
            this.rbtYesActive.AutoSize = true;
            this.rbtYesActive.Checked = true;
            this.rbtYesActive.Location = new System.Drawing.Point(17, 157);
            this.rbtYesActive.Name = "rbtYesActive";
            this.rbtYesActive.Size = new System.Drawing.Size(43, 17);
            this.rbtYesActive.TabIndex = 136;
            this.rbtYesActive.TabStop = true;
            this.rbtYesActive.Text = "Yes";
            this.rbtYesActive.UseVisualStyleBackColor = true;
            // 
            // rbtNoActive
            // 
            this.rbtNoActive.AutoSize = true;
            this.rbtNoActive.Location = new System.Drawing.Point(77, 157);
            this.rbtNoActive.Name = "rbtNoActive";
            this.rbtNoActive.Size = new System.Drawing.Size(39, 17);
            this.rbtNoActive.TabIndex = 135;
            this.rbtNoActive.Text = "No";
            this.rbtNoActive.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(14, 141);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 134;
            this.lblActive.Text = "Active";
            // 
            // txtETFNo
            // 
            this.txtETFNo.Location = new System.Drawing.Point(187, 23);
            this.txtETFNo.Name = "txtETFNo";
            this.txtETFNo.Size = new System.Drawing.Size(174, 20);
            this.txtETFNo.TabIndex = 132;
            // 
            // lblETFNo
            // 
            this.lblETFNo.AutoSize = true;
            this.lblETFNo.Location = new System.Drawing.Point(184, 7);
            this.lblETFNo.Name = "lblETFNo";
            this.lblETFNo.Size = new System.Drawing.Size(44, 13);
            this.lblETFNo.TabIndex = 131;
            this.lblETFNo.Text = "ETF No";
            // 
            // txtBankAccountNo
            // 
            this.txtBankAccountNo.Location = new System.Drawing.Point(187, 67);
            this.txtBankAccountNo.Name = "txtBankAccountNo";
            this.txtBankAccountNo.Size = new System.Drawing.Size(174, 20);
            this.txtBankAccountNo.TabIndex = 128;
            // 
            // txtEPFNo
            // 
            this.txtEPFNo.Location = new System.Drawing.Point(15, 23);
            this.txtEPFNo.Name = "txtEPFNo";
            this.txtEPFNo.Size = new System.Drawing.Size(148, 20);
            this.txtEPFNo.TabIndex = 126;
            // 
            // lblBankAccountNo
            // 
            this.lblBankAccountNo.AutoSize = true;
            this.lblBankAccountNo.Location = new System.Drawing.Point(184, 51);
            this.lblBankAccountNo.Name = "lblBankAccountNo";
            this.lblBankAccountNo.Size = new System.Drawing.Size(92, 13);
            this.lblBankAccountNo.TabIndex = 123;
            this.lblBankAccountNo.Text = "Bank Account No";
            // 
            // lblEPFNo
            // 
            this.lblEPFNo.AutoSize = true;
            this.lblEPFNo.Location = new System.Drawing.Point(12, 10);
            this.lblEPFNo.Name = "lblEPFNo";
            this.lblEPFNo.Size = new System.Drawing.Size(44, 13);
            this.lblEPFNo.TabIndex = 122;
            this.lblEPFNo.Text = "EPF No";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(12, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 47;
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
            this.btnPopulate.TabIndex = 46;
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
            this.btnDelete.TabIndex = 45;
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
            this.btnClear.TabIndex = 44;
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
            this.btnExit.TabIndex = 43;
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
            this.btnAddNew.TabIndex = 42;
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
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = " ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(511, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 20);
            this.txtLastName.TabIndex = 110;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(306, 101);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(173, 20);
            this.txtMiddleName.TabIndex = 109;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 20);
            this.txtFirstName.TabIndex = 108;
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.Location = new System.Drawing.Point(306, 56);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(173, 20);
            this.txtEmployeeNo.TabIndex = 107;
            this.txtEmployeeNo.TextChanged += new System.EventHandler(this.txtEmployeeNo_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(508, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 105;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(304, 86);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 104;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(100, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 103;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Location = new System.Drawing.Point(303, 40);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeNo.TabIndex = 102;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // lblApplicantNo
            // 
            this.lblApplicantNo.AutoSize = true;
            this.lblApplicantNo.Location = new System.Drawing.Point(100, 39);
            this.lblApplicantNo.Name = "lblApplicantNo";
            this.lblApplicantNo.Size = new System.Drawing.Size(68, 13);
            this.lblApplicantNo.TabIndex = 101;
            this.lblApplicantNo.Text = "Applicant No";
            // 
            // dgvPermenentEmployee
            // 
            this.dgvPermenentEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermenentEmployee.Location = new System.Drawing.Point(99, 381);
            this.dgvPermenentEmployee.Name = "dgvPermenentEmployee";
            this.dgvPermenentEmployee.Size = new System.Drawing.Size(932, 154);
            this.dgvPermenentEmployee.TabIndex = 111;
            this.dgvPermenentEmployee.SelectionChanged += new System.EventHandler(this.dgvPermenentEmployee_SelectionChanged);
            // 
            // cmbApplicantNo
            // 
            this.cmbApplicantNo.FormattingEnabled = true;
            this.cmbApplicantNo.Location = new System.Drawing.Point(103, 55);
            this.cmbApplicantNo.Name = "cmbApplicantNo";
            this.cmbApplicantNo.Size = new System.Drawing.Size(167, 21);
            this.cmbApplicantNo.TabIndex = 112;
            this.cmbApplicantNo.SelectedIndexChanged += new System.EventHandler(this.cmbApplicantNo_SelectedIndexChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // frmPermenentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 547);
            this.Controls.Add(this.cmbApplicantNo);
            this.Controls.Add(this.dgvPermenentEmployee);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmployeeNo);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeNo);
            this.Controls.Add(this.lblApplicantNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmPermenentEmployees";
            this.Text = "Permenent Employee Details";
            this.Load += new System.EventHandler(this.frmPermenentEmployees_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCommunication.ResumeLayout(false);
            this.tabCommunication.PerformLayout();
            this.tabQualification.ResumeLayout(false);
            this.tabQualification.PerformLayout();
            this.grpQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).EndInit();
            this.tabBank.ResumeLayout(false);
            this.tabBank.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermenentEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCommunication;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmployeeNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Label lblApplicantNo;
        private System.Windows.Forms.TabPage tabQualification;
        private System.Windows.Forms.TabPage tabBank;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtPreviousExperiances;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPreviousExperiances;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.GroupBox grpQualifications;
        private System.Windows.Forms.DataGridView dgvQualifications;
        private System.Windows.Forms.RadioButton rbtNoProbation;
        private System.Windows.Forms.RadioButton rbtYesProbation;
        private System.Windows.Forms.TextBox txtBankAccountNo;
        private System.Windows.Forms.TextBox txtEPFNo;
        private System.Windows.Forms.Label lblOnProbation;
        private System.Windows.Forms.Label lblBankAccountNo;
        private System.Windows.Forms.Label lblEPFNo;
        private System.Windows.Forms.RadioButton rbtNoExtend;
        private System.Windows.Forms.RadioButton rbtYesExtend;
        private System.Windows.Forms.RadioButton rbtYesActive;
        private System.Windows.Forms.RadioButton rbtNoActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblExtend;
        private System.Windows.Forms.TextBox txtETFNo;
        private System.Windows.Forms.Label lblETFNo;
        private System.Windows.Forms.DataGridView dgvPermenentEmployee;
        private System.Windows.Forms.ComboBox cmbApplicantNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.RadioButton rbtMarried;
        private System.Windows.Forms.RadioButton rbtSingle;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtAddressLine3;
        private System.Windows.Forms.TextBox txtSpecialNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRetirementDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeDate;
        private System.Windows.Forms.Label lblRetirementDate;
        private System.Windows.Forms.Label lblEmployeeDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBank;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpProbationDate;
        private System.Windows.Forms.Label ProbationDate;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colsQualificatrions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsQualificationDescriptions;
    }
}