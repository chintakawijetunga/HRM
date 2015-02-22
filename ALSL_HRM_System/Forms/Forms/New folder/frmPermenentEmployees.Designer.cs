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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.rbtMarried = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtSingle = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.lblNICNo = new System.Windows.Forms.Label();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.tabCommunication = new System.Windows.Forms.TabPage();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtAddressLine3 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblTelephoneNo = new System.Windows.Forms.Label();
            this.lblAddressLine3 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.tabQualification = new System.Windows.Forms.TabPage();
            this.dtpRetirementDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeDate = new System.Windows.Forms.DateTimePicker();
            this.grpQualifications = new System.Windows.Forms.GroupBox();
            this.dgvQualifications = new System.Windows.Forms.DataGridView();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.lblRetirementDate = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtPreviousExperiances = new System.Windows.Forms.TextBox();
            this.lblEmployeeDate = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPreviousExperiances = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.tabBank = new System.Windows.Forms.TabPage();
            this.rbtNo2 = new System.Windows.Forms.RadioButton();
            this.rbtYes2 = new System.Windows.Forms.RadioButton();
            this.rbtyes1 = new System.Windows.Forms.RadioButton();
            this.rbtNo1 = new System.Windows.Forms.RadioButton();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblExtend = new System.Windows.Forms.Label();
            this.txtETFNo = new System.Windows.Forms.TextBox();
            this.lblETFNo = new System.Windows.Forms.Label();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.txtBankAccountNo = new System.Windows.Forms.TextBox();
            this.txtIncrements = new System.Windows.Forms.TextBox();
            this.txtEPFNo = new System.Windows.Forms.TextBox();
            this.lblOnProbation = new System.Windows.Forms.Label();
            this.lblIncrements = new System.Windows.Forms.Label();
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
            this.txtEmplyeeNo = new System.Windows.Forms.TextBox();
            this.txtApplicantNo = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.lblApplicantNo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabCommunication.SuspendLayout();
            this.tabQualification.SuspendLayout();
            this.grpQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).BeginInit();
            this.tabBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabCommunication);
            this.tabControl1.Controls.Add(this.tabQualification);
            this.tabControl1.Controls.Add(this.tabBank);
            this.tabControl1.Location = new System.Drawing.Point(30, 155);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.dtpEmpDOB);
            this.tabGeneral.Controls.Add(this.rbtMarried);
            this.tabGeneral.Controls.Add(this.rbtMale);
            this.tabGeneral.Controls.Add(this.rbtSingle);
            this.tabGeneral.Controls.Add(this.lblGender);
            this.tabGeneral.Controls.Add(this.rbtFemale);
            this.tabGeneral.Controls.Add(this.lblCivilStatus);
            this.tabGeneral.Controls.Add(this.lblNICNo);
            this.tabGeneral.Controls.Add(this.txtNICNo);
            this.tabGeneral.Controls.Add(this.lblDateOfBirth);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(622, 194);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.Location = new System.Drawing.Point(123, 118);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(179, 20);
            this.dtpEmpDOB.TabIndex = 130;
            // 
            // rbtMarried
            // 
            this.rbtMarried.AutoSize = true;
            this.rbtMarried.Location = new System.Drawing.Point(184, 57);
            this.rbtMarried.Name = "rbtMarried";
            this.rbtMarried.Size = new System.Drawing.Size(60, 17);
            this.rbtMarried.TabIndex = 129;
            this.rbtMarried.TabStop = true;
            this.rbtMarried.Text = "Married";
            this.rbtMarried.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(123, 27);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 126;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtSingle
            // 
            this.rbtSingle.AutoSize = true;
            this.rbtSingle.Location = new System.Drawing.Point(123, 57);
            this.rbtSingle.Name = "rbtSingle";
            this.rbtSingle.Size = new System.Drawing.Size(54, 17);
            this.rbtSingle.TabIndex = 128;
            this.rbtSingle.TabStop = true;
            this.rbtSingle.Text = "Single";
            this.rbtSingle.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 29);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 120;
            this.lblGender.Text = "Gender";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(185, 27);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 127;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Location = new System.Drawing.Point(15, 59);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(59, 13);
            this.lblCivilStatus.TabIndex = 121;
            this.lblCivilStatus.Text = "Civil Status";
            // 
            // lblNICNo
            // 
            this.lblNICNo.AutoSize = true;
            this.lblNICNo.Location = new System.Drawing.Point(15, 88);
            this.lblNICNo.Name = "lblNICNo";
            this.lblNICNo.Size = new System.Drawing.Size(42, 13);
            this.lblNICNo.TabIndex = 122;
            this.lblNICNo.Text = "NIC No";
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(123, 85);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(121, 20);
            this.txtNICNo.TabIndex = 125;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(15, 118);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 123;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // tabCommunication
            // 
            this.tabCommunication.Controls.Add(this.txtTelephoneNo);
            this.tabCommunication.Controls.Add(this.txtAddressLine3);
            this.tabCommunication.Controls.Add(this.txtAddressLine2);
            this.tabCommunication.Controls.Add(this.txtAddressLine1);
            this.tabCommunication.Controls.Add(this.lblTelephoneNo);
            this.tabCommunication.Controls.Add(this.lblAddressLine3);
            this.tabCommunication.Controls.Add(this.lblAddressLine2);
            this.tabCommunication.Controls.Add(this.lblAddressLine1);
            this.tabCommunication.Location = new System.Drawing.Point(4, 22);
            this.tabCommunication.Name = "tabCommunication";
            this.tabCommunication.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommunication.Size = new System.Drawing.Size(622, 194);
            this.tabCommunication.TabIndex = 1;
            this.tabCommunication.Text = "Communication";
            this.tabCommunication.UseVisualStyleBackColor = true;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(129, 116);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(163, 20);
            this.txtTelephoneNo.TabIndex = 112;
            // 
            // txtAddressLine3
            // 
            this.txtAddressLine3.Location = new System.Drawing.Point(129, 86);
            this.txtAddressLine3.Name = "txtAddressLine3";
            this.txtAddressLine3.Size = new System.Drawing.Size(163, 20);
            this.txtAddressLine3.TabIndex = 111;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(129, 54);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(163, 20);
            this.txtAddressLine2.TabIndex = 110;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(129, 22);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(163, 20);
            this.txtAddressLine1.TabIndex = 109;
            // 
            // lblTelephoneNo
            // 
            this.lblTelephoneNo.AutoSize = true;
            this.lblTelephoneNo.Location = new System.Drawing.Point(21, 119);
            this.lblTelephoneNo.Name = "lblTelephoneNo";
            this.lblTelephoneNo.Size = new System.Drawing.Size(75, 13);
            this.lblTelephoneNo.TabIndex = 108;
            this.lblTelephoneNo.Text = "Telephone No";
            // 
            // lblAddressLine3
            // 
            this.lblAddressLine3.AutoSize = true;
            this.lblAddressLine3.Location = new System.Drawing.Point(21, 89);
            this.lblAddressLine3.Name = "lblAddressLine3";
            this.lblAddressLine3.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine3.TabIndex = 107;
            this.lblAddressLine3.Text = "Address Line 3";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(21, 57);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 106;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(21, 24);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 105;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // tabQualification
            // 
            this.tabQualification.Controls.Add(this.dtpRetirementDate);
            this.tabQualification.Controls.Add(this.dtpEmployeeDate);
            this.tabQualification.Controls.Add(this.grpQualifications);
            this.tabQualification.Controls.Add(this.lblRetirementDate);
            this.tabQualification.Controls.Add(this.cmbDepartment);
            this.tabQualification.Controls.Add(this.cmbDesignation);
            this.tabQualification.Controls.Add(this.txtPreviousExperiances);
            this.tabQualification.Controls.Add(this.lblEmployeeDate);
            this.tabQualification.Controls.Add(this.lblDepartment);
            this.tabQualification.Controls.Add(this.lblPreviousExperiances);
            this.tabQualification.Controls.Add(this.lblDesignation);
            this.tabQualification.Location = new System.Drawing.Point(4, 22);
            this.tabQualification.Name = "tabQualification";
            this.tabQualification.Padding = new System.Windows.Forms.Padding(3);
            this.tabQualification.Size = new System.Drawing.Size(622, 194);
            this.tabQualification.TabIndex = 2;
            this.tabQualification.Text = "Qualification";
            this.tabQualification.UseVisualStyleBackColor = true;
            // 
            // dtpRetirementDate
            // 
            this.dtpRetirementDate.Location = new System.Drawing.Point(130, 141);
            this.dtpRetirementDate.Name = "dtpRetirementDate";
            this.dtpRetirementDate.Size = new System.Drawing.Size(166, 20);
            this.dtpRetirementDate.TabIndex = 135;
            // 
            // dtpEmployeeDate
            // 
            this.dtpEmployeeDate.Location = new System.Drawing.Point(130, 108);
            this.dtpEmployeeDate.Name = "dtpEmployeeDate";
            this.dtpEmployeeDate.Size = new System.Drawing.Size(163, 20);
            this.dtpEmployeeDate.TabIndex = 70;
            // 
            // grpQualifications
            // 
            this.grpQualifications.Controls.Add(this.dgvQualifications);
            this.grpQualifications.Controls.Add(this.combobox1);
            this.grpQualifications.Location = new System.Drawing.Point(333, 16);
            this.grpQualifications.Name = "grpQualifications";
            this.grpQualifications.Size = new System.Drawing.Size(271, 166);
            this.grpQualifications.TabIndex = 134;
            this.grpQualifications.TabStop = false;
            this.grpQualifications.Text = "Qualifications";
            // 
            // dgvQualifications
            // 
            this.dgvQualifications.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQualifications.Location = new System.Drawing.Point(6, 51);
            this.dgvQualifications.Name = "dgvQualifications";
            this.dgvQualifications.Size = new System.Drawing.Size(259, 109);
            this.dgvQualifications.TabIndex = 69;
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(6, 19);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(181, 21);
            this.combobox1.TabIndex = 68;
            // 
            // lblRetirementDate
            // 
            this.lblRetirementDate.AutoSize = true;
            this.lblRetirementDate.Location = new System.Drawing.Point(22, 141);
            this.lblRetirementDate.Name = "lblRetirementDate";
            this.lblRetirementDate.Size = new System.Drawing.Size(84, 13);
            this.lblRetirementDate.TabIndex = 132;
            this.lblRetirementDate.Text = "Retirement Date";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(130, 76);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(163, 21);
            this.cmbDepartment.TabIndex = 131;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(130, 21);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(163, 21);
            this.cmbDesignation.TabIndex = 130;
            // 
            // txtPreviousExperiances
            // 
            this.txtPreviousExperiances.Location = new System.Drawing.Point(130, 49);
            this.txtPreviousExperiances.Name = "txtPreviousExperiances";
            this.txtPreviousExperiances.Size = new System.Drawing.Size(163, 20);
            this.txtPreviousExperiances.TabIndex = 128;
            // 
            // lblEmployeeDate
            // 
            this.lblEmployeeDate.AutoSize = true;
            this.lblEmployeeDate.Location = new System.Drawing.Point(22, 109);
            this.lblEmployeeDate.Name = "lblEmployeeDate";
            this.lblEmployeeDate.Size = new System.Drawing.Size(79, 13);
            this.lblEmployeeDate.TabIndex = 127;
            this.lblEmployeeDate.Text = "Employee Date";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(22, 79);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 126;
            this.lblDepartment.Text = "Department";
            // 
            // lblPreviousExperiances
            // 
            this.lblPreviousExperiances.AutoSize = true;
            this.lblPreviousExperiances.Location = new System.Drawing.Point(22, 52);
            this.lblPreviousExperiances.Name = "lblPreviousExperiances";
            this.lblPreviousExperiances.Size = new System.Drawing.Size(109, 13);
            this.lblPreviousExperiances.TabIndex = 125;
            this.lblPreviousExperiances.Text = "Previous Experiances";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(22, 24);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 124;
            this.lblDesignation.Text = "Designation";
            // 
            // tabBank
            // 
            this.tabBank.Controls.Add(this.rbtNo2);
            this.tabBank.Controls.Add(this.rbtYes2);
            this.tabBank.Controls.Add(this.rbtyes1);
            this.tabBank.Controls.Add(this.rbtNo1);
            this.tabBank.Controls.Add(this.lblActive);
            this.tabBank.Controls.Add(this.lblExtend);
            this.tabBank.Controls.Add(this.txtETFNo);
            this.tabBank.Controls.Add(this.lblETFNo);
            this.tabBank.Controls.Add(this.rbtNo);
            this.tabBank.Controls.Add(this.rbtYes);
            this.tabBank.Controls.Add(this.txtBankAccountNo);
            this.tabBank.Controls.Add(this.txtIncrements);
            this.tabBank.Controls.Add(this.txtEPFNo);
            this.tabBank.Controls.Add(this.lblOnProbation);
            this.tabBank.Controls.Add(this.lblIncrements);
            this.tabBank.Controls.Add(this.lblBankAccountNo);
            this.tabBank.Controls.Add(this.lblEPFNo);
            this.tabBank.Location = new System.Drawing.Point(4, 22);
            this.tabBank.Name = "tabBank";
            this.tabBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabBank.Size = new System.Drawing.Size(622, 194);
            this.tabBank.TabIndex = 3;
            this.tabBank.Text = "Banking";
            this.tabBank.UseVisualStyleBackColor = true;
            // 
            // rbtNo2
            // 
            this.rbtNo2.AutoSize = true;
            this.rbtNo2.Location = new System.Drawing.Point(473, 87);
            this.rbtNo2.Name = "rbtNo2";
            this.rbtNo2.Size = new System.Drawing.Size(39, 17);
            this.rbtNo2.TabIndex = 138;
            this.rbtNo2.TabStop = true;
            this.rbtNo2.Text = "No";
            this.rbtNo2.UseVisualStyleBackColor = true;
            // 
            // rbtYes2
            // 
            this.rbtYes2.AutoSize = true;
            this.rbtYes2.Location = new System.Drawing.Point(407, 87);
            this.rbtYes2.Name = "rbtYes2";
            this.rbtYes2.Size = new System.Drawing.Size(43, 17);
            this.rbtYes2.TabIndex = 137;
            this.rbtYes2.TabStop = true;
            this.rbtYes2.Text = "Yes";
            this.rbtYes2.UseVisualStyleBackColor = true;
            // 
            // rbtyes1
            // 
            this.rbtyes1.AutoSize = true;
            this.rbtyes1.Location = new System.Drawing.Point(407, 56);
            this.rbtyes1.Name = "rbtyes1";
            this.rbtyes1.Size = new System.Drawing.Size(43, 17);
            this.rbtyes1.TabIndex = 136;
            this.rbtyes1.TabStop = true;
            this.rbtyes1.Text = "Yes";
            this.rbtyes1.UseVisualStyleBackColor = true;
            // 
            // rbtNo1
            // 
            this.rbtNo1.AutoSize = true;
            this.rbtNo1.Location = new System.Drawing.Point(473, 56);
            this.rbtNo1.Name = "rbtNo1";
            this.rbtNo1.Size = new System.Drawing.Size(39, 17);
            this.rbtNo1.TabIndex = 135;
            this.rbtNo1.TabStop = true;
            this.rbtNo1.Text = "No";
            this.rbtNo1.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(324, 58);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 134;
            this.lblActive.Text = "Active";
            // 
            // lblExtend
            // 
            this.lblExtend.AutoSize = true;
            this.lblExtend.Location = new System.Drawing.Point(324, 89);
            this.lblExtend.Name = "lblExtend";
            this.lblExtend.Size = new System.Drawing.Size(40, 13);
            this.lblExtend.TabIndex = 133;
            this.lblExtend.Text = "Extend";
            // 
            // txtETFNo
            // 
            this.txtETFNo.Location = new System.Drawing.Point(407, 23);
            this.txtETFNo.Name = "txtETFNo";
            this.txtETFNo.Size = new System.Drawing.Size(126, 20);
            this.txtETFNo.TabIndex = 132;
            // 
            // lblETFNo
            // 
            this.lblETFNo.AutoSize = true;
            this.lblETFNo.Location = new System.Drawing.Point(322, 27);
            this.lblETFNo.Name = "lblETFNo";
            this.lblETFNo.Size = new System.Drawing.Size(44, 13);
            this.lblETFNo.TabIndex = 131;
            this.lblETFNo.Text = "ETF No";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(166, 121);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 130;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(120, 121);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 129;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            // 
            // txtBankAccountNo
            // 
            this.txtBankAccountNo.Location = new System.Drawing.Point(120, 57);
            this.txtBankAccountNo.Name = "txtBankAccountNo";
            this.txtBankAccountNo.Size = new System.Drawing.Size(121, 20);
            this.txtBankAccountNo.TabIndex = 128;
            // 
            // txtIncrements
            // 
            this.txtIncrements.Location = new System.Drawing.Point(120, 88);
            this.txtIncrements.Name = "txtIncrements";
            this.txtIncrements.Size = new System.Drawing.Size(121, 20);
            this.txtIncrements.TabIndex = 127;
            // 
            // txtEPFNo
            // 
            this.txtEPFNo.Location = new System.Drawing.Point(120, 25);
            this.txtEPFNo.Name = "txtEPFNo";
            this.txtEPFNo.Size = new System.Drawing.Size(121, 20);
            this.txtEPFNo.TabIndex = 126;
            // 
            // lblOnProbation
            // 
            this.lblOnProbation.AutoSize = true;
            this.lblOnProbation.Location = new System.Drawing.Point(12, 120);
            this.lblOnProbation.Name = "lblOnProbation";
            this.lblOnProbation.Size = new System.Drawing.Size(69, 13);
            this.lblOnProbation.TabIndex = 125;
            this.lblOnProbation.Text = "On Probation";
            // 
            // lblIncrements
            // 
            this.lblIncrements.AutoSize = true;
            this.lblIncrements.Location = new System.Drawing.Point(12, 91);
            this.lblIncrements.Name = "lblIncrements";
            this.lblIncrements.Size = new System.Drawing.Size(59, 13);
            this.lblIncrements.TabIndex = 124;
            this.lblIncrements.Text = "Increments";
            // 
            // lblBankAccountNo
            // 
            this.lblBankAccountNo.AutoSize = true;
            this.lblBankAccountNo.Location = new System.Drawing.Point(12, 60);
            this.lblBankAccountNo.Name = "lblBankAccountNo";
            this.lblBankAccountNo.Size = new System.Drawing.Size(92, 13);
            this.lblBankAccountNo.TabIndex = 123;
            this.lblBankAccountNo.Text = "Bank Account No";
            // 
            // lblEPFNo
            // 
            this.lblEPFNo.AutoSize = true;
            this.lblEPFNo.Location = new System.Drawing.Point(12, 28);
            this.lblEPFNo.Name = "lblEPFNo";
            this.lblEPFNo.Size = new System.Drawing.Size(44, 13);
            this.lblEPFNo.TabIndex = 122;
            this.lblEPFNo.Text = "EPF No";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(677, 22);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 46;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(677, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(677, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(677, 196);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(677, 51);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 42;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(677, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Search...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(140, 20);
            this.txtLastName.TabIndex = 110;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(486, 63);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(140, 20);
            this.txtMiddleName.TabIndex = 109;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtFirstName.TabIndex = 108;
            // 
            // txtEmplyeeNo
            // 
            this.txtEmplyeeNo.Location = new System.Drawing.Point(486, 25);
            this.txtEmplyeeNo.Name = "txtEmplyeeNo";
            this.txtEmplyeeNo.Size = new System.Drawing.Size(140, 20);
            this.txtEmplyeeNo.TabIndex = 107;
            // 
            // txtApplicantNo
            // 
            this.txtApplicantNo.Location = new System.Drawing.Point(135, 25);
            this.txtApplicantNo.Name = "txtApplicantNo";
            this.txtApplicantNo.Size = new System.Drawing.Size(140, 20);
            this.txtApplicantNo.TabIndex = 106;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(27, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 105;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(378, 66);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 104;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(27, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 103;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Location = new System.Drawing.Point(378, 28);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeNo.TabIndex = 102;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // lblApplicantNo
            // 
            this.lblApplicantNo.AutoSize = true;
            this.lblApplicantNo.Location = new System.Drawing.Point(26, 28);
            this.lblApplicantNo.Name = "lblApplicantNo";
            this.lblApplicantNo.Size = new System.Drawing.Size(68, 13);
            this.lblApplicantNo.TabIndex = 101;
            this.lblApplicantNo.Text = "Applicant No";
            // 
            // frmPermenentEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 404);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmplyeeNo);
            this.Controls.Add(this.txtApplicantNo);
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
            this.Name = "frmPermenentEmployees";
            this.Text = "PermenentEmployees";
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabCommunication.ResumeLayout(false);
            this.tabCommunication.PerformLayout();
            this.tabQualification.ResumeLayout(false);
            this.tabQualification.PerformLayout();
            this.grpQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQualifications)).EndInit();
            this.tabBank.ResumeLayout(false);
            this.tabBank.PerformLayout();
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
        private System.Windows.Forms.TextBox txtEmplyeeNo;
        private System.Windows.Forms.TextBox txtApplicantNo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Label lblApplicantNo;
        private System.Windows.Forms.TabPage tabQualification;
        private System.Windows.Forms.TabPage tabBank;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.RadioButton rbtMarried;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtSingle;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.Label lblNICNo;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtAddressLine3;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblTelephoneNo;
        private System.Windows.Forms.Label lblAddressLine3;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtPreviousExperiances;
        private System.Windows.Forms.Label lblEmployeeDate;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPreviousExperiances;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblRetirementDate;
        private System.Windows.Forms.DateTimePicker dtpRetirementDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeDate;
        private System.Windows.Forms.GroupBox grpQualifications;
        private System.Windows.Forms.DataGridView dgvQualifications;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.TextBox txtBankAccountNo;
        private System.Windows.Forms.TextBox txtIncrements;
        private System.Windows.Forms.TextBox txtEPFNo;
        private System.Windows.Forms.Label lblOnProbation;
        private System.Windows.Forms.Label lblIncrements;
        private System.Windows.Forms.Label lblBankAccountNo;
        private System.Windows.Forms.Label lblEPFNo;
        private System.Windows.Forms.RadioButton rbtNo2;
        private System.Windows.Forms.RadioButton rbtYes2;
        private System.Windows.Forms.RadioButton rbtyes1;
        private System.Windows.Forms.RadioButton rbtNo1;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblExtend;
        private System.Windows.Forms.TextBox txtETFNo;
        private System.Windows.Forms.Label lblETFNo;
    }
}