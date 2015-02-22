namespace ALSL_HRM_System.Forms
{
    partial class frmLoginUser
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.picBoxAnalaLab = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnalaLab)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(69, 265);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(130, 149);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(179, 20);
            this.txtUserID.TabIndex = 8;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name:";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // picBoxAnalaLab
            // 
            this.picBoxAnalaLab.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.HRM_bg;
            this.picBoxAnalaLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxAnalaLab.Location = new System.Drawing.Point(0, -2);
            this.picBoxAnalaLab.Name = "picBoxAnalaLab";
            this.picBoxAnalaLab.Size = new System.Drawing.Size(371, 126);
            this.picBoxAnalaLab.TabIndex = 13;
            this.picBoxAnalaLab.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(241, 265);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(117, 23);
            this.btnOptions.TabIndex = 14;
            this.btnOptions.Text = "Change Password>>";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(182, 74);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(148, 20);
            this.txtCurrentPassword.TabIndex = 22;
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(182, 146);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(148, 20);
            this.txtReEnterPassword.TabIndex = 21;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(182, 111);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(148, 20);
            this.txtNewPassword.TabIndex = 20;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(182, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 20);
            this.txtUserName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Re Enter New Pasword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "User Name";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(213, 193);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(117, 23);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtReEnterPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 240);
            this.panel1.TabIndex = 24;
            // 
            // frmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.picBoxAnalaLab);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmLoginUser";
            this.Text = "Login User";
            this.Load += new System.EventHandler(this.frmLoginUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAnalaLab)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.PictureBox picBoxAnalaLab;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel1;
    }
}