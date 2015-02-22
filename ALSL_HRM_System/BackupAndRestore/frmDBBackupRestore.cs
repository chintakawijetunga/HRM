using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.IO;

namespace HRM_DBInstallation
{
    public partial class frmDBRnB : Office2007Form
    {

        public SqlConnection sqlConnectionfrmSystemUser = null;
        HRM_DBInstallation.DBConnectionBackup obj1 = null;
        String newDBName = null;
        

        public frmDBRnB()
        {
            InitializeComponent();
            this.TopMost = true;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;

        }


        private void DBConnectionMethod()
        {
            String serverName = txtServerName.Text;

            obj1 = new HRM_DBInstallation.DBConnectionBackup();
            obj1.DBConnectionMethod(serverName);
                   
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnectionMethod();
                MessageBox.Show("Connection Successful.", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtBackup.Enabled = true;
                rbtRestore.Enabled = true;
                rbtBackup.Checked = false;
                rbtBackup.Checked = true;
            
            }
            catch(Exception ex)
            {

                MessageBox.Show("Connection Error. Please check the Server Name and Authentication details.", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateNewDatabase();
        }

        private void CreateNewDatabase()
        {
            newDBName=txtNewDBName.Text;

            
            String cmdConnect = "CREATE DATABASE " + newDBName + ";";
            SqlCommand sqlSelectCommand = new SqlCommand(cmdConnect);
            sqlSelectCommand.Connection = obj1.sqlConnectionfrmSystemUser;



            sqlSelectCommand.ExecuteNonQuery();
        
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestoreDatabase();
        }


        private void RestoreDatabase()
        {
            try
            {
            
                newDBName = txtDatabaseRestore.Text;
                String cmdConnect = "use master; RESTORE DATABASE " + newDBName + @" FROM DISK = '" + @txtRestoreFrom.Text + "' WITH REPLACE;";
                SqlCommand sqlSelectCommand = new SqlCommand(cmdConnect);
                sqlSelectCommand.Connection = obj1.sqlConnectionfrmSystemUser;
                sqlSelectCommand.ExecuteNonQuery();
                MessageBox.Show("Database successfully restored.", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            catch (Exception ex)
            {
               MessageBox.Show("Error occured while restoring the database.\nPlease verify the path and the database name.", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }

        private void frmDBRnB_Load(object sender, EventArgs e)
        {

            DisableAllControls();


        }

        private void DisableAllControls()
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtWinAuth.Checked == true)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void rbtBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBackup.Checked == true)
            {
                txtRestoreFrom.Enabled = false;
                txtDatabaseRestore.Enabled = false;
                btnBrowseRestore.Enabled=false;
                btnRestore.Enabled=false;

                txtSaveTo.Enabled = true;
                txtDatabaseBackup.Enabled = true;
                btnBackup.Enabled = true;
                btnBrowseBackup.Enabled = true;
            }

            else 
            {

                txtRestoreFrom.Enabled = true;
                txtDatabaseRestore.Enabled = true;
                btnBrowseRestore.Enabled = true;
                btnRestore.Enabled = true;

                txtSaveTo.Enabled = false;
                txtDatabaseBackup.Enabled = false;
                btnBackup.Enabled = false;
                btnBrowseBackup.Enabled = false;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            try
            {
                String BackupDestination = @"C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\ALSL_HRM_DB.bak";
                newDBName = "ALSL_HRM_DB";
                String cmdConnect = "use master; BACKUP DATABASE " + newDBName + @" TO DISK = '" + BackupDestination + "';";
                SqlCommand sqlSelectCommand = new SqlCommand(cmdConnect);
                sqlSelectCommand.Connection = obj1.sqlConnectionfrmSystemUser;
                sqlSelectCommand.ExecuteNonQuery();
                File.Move(BackupDestination, txtSaveTo.Text);
                MessageBox.Show("Database successfully backup.", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                //MessageBox.Show("Error occured while backup the database..", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }



        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restore the ALSL_HRM_DB? ", ALSL_HRM_System.Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestoreDatabase();
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseRestoreDB = new OpenFileDialog();
            if (browseRestoreDB.ShowDialog() == DialogResult.OK)
            {
                txtRestoreFrom.Text = browseRestoreDB.FileName;
            }
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSaveTo.Text = saveFileDialog1.FileName;
            } 
        }


        



    }
}
