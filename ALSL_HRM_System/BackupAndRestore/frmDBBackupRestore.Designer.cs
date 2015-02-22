namespace HRM_DBInstallation
{
    partial class frmDBRnB
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewDBName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSQLAuth = new System.Windows.Forms.RadioButton();
            this.rbtWinAuth = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabaseBackup = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatabaseRestore = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowseRestore = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRestoreFrom = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtRestore = new System.Windows.Forms.RadioButton();
            this.rbtBackup = new System.Windows.Forms.RadioButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(198, 94);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(336, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source / Server Name:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(451, 173);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Database Name";
            this.label2.Visible = false;
            // 
            // txtNewDBName
            // 
            this.txtNewDBName.Location = new System.Drawing.Point(175, 641);
            this.txtNewDBName.Name = "txtNewDBName";
            this.txtNewDBName.Size = new System.Drawing.Size(179, 20);
            this.txtNewDBName.TabIndex = 3;
            this.txtNewDBName.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 641);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Restore Database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 202);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Specification";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(101, 140);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(179, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(355, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtSQLAuth);
            this.groupBox2.Controls.Add(this.rbtWinAuth);
            this.groupBox2.Location = new System.Drawing.Point(28, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 52);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentication";
            // 
            // rbtSQLAuth
            // 
            this.rbtSQLAuth.AutoSize = true;
            this.rbtSQLAuth.Location = new System.Drawing.Point(227, 22);
            this.rbtSQLAuth.Name = "rbtSQLAuth";
            this.rbtSQLAuth.Size = new System.Drawing.Size(151, 17);
            this.rbtSQLAuth.TabIndex = 8;
            this.rbtSQLAuth.Text = "SQL Server Authentication";
            this.rbtSQLAuth.UseVisualStyleBackColor = true;
            // 
            // rbtWinAuth
            // 
            this.rbtWinAuth.AutoSize = true;
            this.rbtWinAuth.Checked = true;
            this.rbtWinAuth.Location = new System.Drawing.Point(16, 22);
            this.rbtWinAuth.Name = "rbtWinAuth";
            this.rbtWinAuth.Size = new System.Drawing.Size(140, 17);
            this.rbtWinAuth.TabIndex = 8;
            this.rbtWinAuth.TabStop = true;
            this.rbtWinAuth.Text = "Windows Authentication";
            this.rbtWinAuth.UseVisualStyleBackColor = true;
            this.rbtWinAuth.CheckedChanged += new System.EventHandler(this.rbtWinAuth_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDatabaseBackup);
            this.groupBox3.Controls.Add(this.btnBackup);
            this.groupBox3.Controls.Add(this.btnBrowseBackup);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSaveTo);
            this.groupBox3.Location = new System.Drawing.Point(18, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 149);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Database:";
            // 
            // txtDatabaseBackup
            // 
            this.txtDatabaseBackup.Enabled = false;
            this.txtDatabaseBackup.Location = new System.Drawing.Point(101, 82);
            this.txtDatabaseBackup.Name = "txtDatabaseBackup";
            this.txtDatabaseBackup.ReadOnly = true;
            this.txtDatabaseBackup.Size = new System.Drawing.Size(330, 20);
            this.txtDatabaseBackup.TabIndex = 11;
            this.txtDatabaseBackup.Text = "ALSL_HRM_DB";
            // 
            // btnBackup
            // 
            this.btnBackup.Enabled = false;
            this.btnBackup.Location = new System.Drawing.Point(451, 80);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(83, 23);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Enabled = false;
            this.btnBrowseBackup.Location = new System.Drawing.Point(451, 30);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(83, 23);
            this.btnBrowseBackup.TabIndex = 10;
            this.btnBrowseBackup.Text = "Browse";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Save To:";
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Enabled = false;
            this.txtSaveTo.Location = new System.Drawing.Point(101, 32);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.ReadOnly = true;
            this.txtSaveTo.Size = new System.Drawing.Size(330, 20);
            this.txtSaveTo.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtDatabaseRestore);
            this.groupBox4.Controls.Add(this.btnRestore);
            this.groupBox4.Controls.Add(this.btnBrowseRestore);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtRestoreFrom);
            this.groupBox4.Location = new System.Drawing.Point(18, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 128);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Database:";
            // 
            // txtDatabaseRestore
            // 
            this.txtDatabaseRestore.Enabled = false;
            this.txtDatabaseRestore.Location = new System.Drawing.Point(101, 82);
            this.txtDatabaseRestore.Name = "txtDatabaseRestore";
            this.txtDatabaseRestore.Size = new System.Drawing.Size(330, 20);
            this.txtDatabaseRestore.TabIndex = 11;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(451, 80);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(83, 23);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Enabled = false;
            this.btnBrowseRestore.Location = new System.Drawing.Point(451, 30);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(83, 23);
            this.btnBrowseRestore.TabIndex = 10;
            this.btnBrowseRestore.Text = "Browse";
            this.btnBrowseRestore.UseVisualStyleBackColor = true;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Restore From:";
            // 
            // txtRestoreFrom
            // 
            this.txtRestoreFrom.Enabled = false;
            this.txtRestoreFrom.Location = new System.Drawing.Point(101, 32);
            this.txtRestoreFrom.Name = "txtRestoreFrom";
            this.txtRestoreFrom.Size = new System.Drawing.Size(330, 20);
            this.txtRestoreFrom.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtRestore);
            this.groupBox5.Controls.Add(this.rbtBackup);
            this.groupBox5.Location = new System.Drawing.Point(20, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(571, 52);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Backup or Restore";
            // 
            // rbtRestore
            // 
            this.rbtRestore.AutoSize = true;
            this.rbtRestore.Enabled = false;
            this.rbtRestore.Location = new System.Drawing.Point(226, 17);
            this.rbtRestore.Name = "rbtRestore";
            this.rbtRestore.Size = new System.Drawing.Size(111, 17);
            this.rbtRestore.TabIndex = 8;
            this.rbtRestore.Text = "Database Restore";
            this.rbtRestore.UseVisualStyleBackColor = true;
            // 
            // rbtBackup
            // 
            this.rbtBackup.AutoSize = true;
            this.rbtBackup.Checked = true;
            this.rbtBackup.Enabled = false;
            this.rbtBackup.Location = new System.Drawing.Point(15, 17);
            this.rbtBackup.Name = "rbtBackup";
            this.rbtBackup.Size = new System.Drawing.Size(111, 17);
            this.rbtBackup.TabIndex = 8;
            this.rbtBackup.TabStop = true;
            this.rbtBackup.Text = "Database Backup";
            this.rbtBackup.UseVisualStyleBackColor = true;
            this.rbtBackup.CheckedChanged += new System.EventHandler(this.rbtBackup_CheckedChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ALSL_HRM_System.Properties.Resources.HomeExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(586, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDBRnB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 622);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewDBName);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmDBRnB";
            this.Text = "Databse Restore and Backup";
            this.Load += new System.EventHandler(this.frmDBRnB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewDBName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtSQLAuth;
        private System.Windows.Forms.RadioButton rbtWinAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDatabaseBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatabaseRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowseRestore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRestoreFrom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtRestore;
        private System.Windows.Forms.RadioButton rbtBackup;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Button btnExit;
    }
}

