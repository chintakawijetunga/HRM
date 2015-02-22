namespace ALSL_HRM_System.Forms.Forms
{
    partial class frmChangeProfile
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccessLevel = new System.Windows.Forms.ComboBox();
            this.btnChangeCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtCreateProfile = new System.Windows.Forms.RadioButton();
            this.rbtChangePassword = new System.Windows.Forms.RadioButton();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re Enter New Pasword";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(197, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(197, 175);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(148, 20);
            this.txtNewPassword.TabIndex = 5;
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(197, 210);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(148, 20);
            this.txtReEnterPassword.TabIndex = 6;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(197, 138);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(148, 20);
            this.txtCurrentPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Access Level";
            // 
            // cmbAccessLevel
            // 
            this.cmbAccessLevel.Enabled = false;
            this.cmbAccessLevel.FormattingEnabled = true;
            this.cmbAccessLevel.Items.AddRange(new object[] {
            "Adiminstrator",
            "Manager Level",
            "Employee Level"});
            this.cmbAccessLevel.Location = new System.Drawing.Point(197, 249);
            this.cmbAccessLevel.Name = "cmbAccessLevel";
            this.cmbAccessLevel.Size = new System.Drawing.Size(148, 21);
            this.cmbAccessLevel.TabIndex = 9;
            // 
            // btnChangeCreate
            // 
            this.btnChangeCreate.Location = new System.Drawing.Point(220, 293);
            this.btnChangeCreate.Name = "btnChangeCreate";
            this.btnChangeCreate.Size = new System.Drawing.Size(92, 23);
            this.btnChangeCreate.TabIndex = 10;
            this.btnChangeCreate.Text = "Change/Create";
            this.btnChangeCreate.UseVisualStyleBackColor = true;
            this.btnChangeCreate.Click += new System.EventHandler(this.btnChangeCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbtCreateProfile
            // 
            this.rbtCreateProfile.AutoSize = true;
            this.rbtCreateProfile.Enabled = false;
            this.rbtCreateProfile.Location = new System.Drawing.Point(58, 27);
            this.rbtCreateProfile.Name = "rbtCreateProfile";
            this.rbtCreateProfile.Size = new System.Drawing.Size(88, 17);
            this.rbtCreateProfile.TabIndex = 12;
            this.rbtCreateProfile.Text = "Create Profile";
            this.rbtCreateProfile.UseVisualStyleBackColor = true;
            this.rbtCreateProfile.CheckedChanged += new System.EventHandler(this.rbtCreateProfile_CheckedChanged);
            // 
            // rbtChangePassword
            // 
            this.rbtChangePassword.AutoSize = true;
            this.rbtChangePassword.Checked = true;
            this.rbtChangePassword.Location = new System.Drawing.Point(170, 27);
            this.rbtChangePassword.Name = "rbtChangePassword";
            this.rbtChangePassword.Size = new System.Drawing.Size(111, 17);
            this.rbtChangePassword.TabIndex = 13;
            this.rbtChangePassword.TabStop = true;
            this.rbtChangePassword.Text = "Change Password";
            this.rbtChangePassword.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(197, 63);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(148, 20);
            this.txtEmployeeID.TabIndex = 15;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee ID";
            // 
            // frmChangeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 337);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtChangePassword);
            this.Controls.Add(this.rbtCreateProfile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeCreate);
            this.Controls.Add(this.cmbAccessLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtReEnterPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmChangeProfile";
            this.Text = "New Profile and Change Password";
            this.Load += new System.EventHandler(this.frmChangeProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccessLevel;
        private System.Windows.Forms.Button btnChangeCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtCreateProfile;
        private System.Windows.Forms.RadioButton rbtChangePassword;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label6;
    }
}