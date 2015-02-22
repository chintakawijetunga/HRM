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
using ALSL_HRM_System.Forms.Letters;
using System.Data.SqlClient;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class dlgLetterGenerator : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        String employeeFullName=null;
        String employeeFirstName = null;
        String AddressLine1=null;
        String AddressLine2=null;
        String AddressLine3=null;
        String Email = null;
        String EmailSubject = null;
        String EmailBody = null;
        String storedProcedureLetters = null;
        String filePath=null; 
        String comboBoxName=null; 
        String comboBoxSP=null;
        String SearchID = null;
        frmMDIMain form;
        #endregion

        #region Constructor

        public dlgLetterGenerator(String storedProcedureLetters, String filePath, String comboBoxName, String comboBoxSP, String EmailSubject, frmMDIMain form)
        {
            InitializeComponent();
            this.TopMost = true;
            this.Text = EmailSubject+" Generation";
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            this.EmailSubject = EmailSubject;
            btnGenerate.Enabled = false;
            this.storedProcedureLetters = storedProcedureLetters;
            this.filePath = filePath;
            this.comboBoxName = comboBoxName;
            this.comboBoxSP = comboBoxSP;
            label2.Text = this.comboBoxName;
            this.form = form;
        }

        #endregion

        #region Exit Method

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void ExitMethod()
        {
            this.Close();
        }

        #endregion

        #region Generate Letter Method

        private void btnPrint_Click(object sender, EventArgs e)
        {
            GenerateLetterMethod();
        }

        private void GenerateLetterMethod()
        {
            
            String employeeDetails = employeeFullName + ", \n" + AddressLine1 + ",\n" + AddressLine2 + "\n" + AddressLine3 + "\nDear " + employeeFirstName + ",";
            this.EmailBody = "Dear " + employeeFirstName + ",\n\n\t\t" + "Please find the attachment for details\n\nRegards, \nManagement - Anala Laboratory Services (Pvt) Ltd.";
            frmLetterWindow letterObj = new frmLetterWindow(employeeDetails, filePath, txtEmail.Text, EmailSubject, EmailBody, SearchID, form);
            letterObj.WindowState = FormWindowState.Maximized;
            letterObj.Show();
            this.Close();
        }
        #endregion

        #region Form Load

        private void frmServiceExtendRejectionLetter_Load(object sender, EventArgs e)
        {
            DBConnectionMethod();
            FillComboBox();
        }

        #endregion

        #region DBConnection Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        #region FillComboBox

        private void FillComboBox()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = comboBoxSP;
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            #region Service Extend Rejection Letter

            if (EmailSubject.Equals("Service Extend Rejection Letter"))
            {
                while (rs.Read())
                {
                    if(rs[5].Equals("0"))
                    cmbComboBox.Items.Add(rs[1]);
                }
            }

            #endregion
            
            #region Service Extend Confirmation Letter

            if (EmailSubject.Equals("Service Extend Confirmation Letter"))
            {
                while (rs.Read())
                {
                    if (rs[5].Equals("1"))
                        cmbComboBox.Items.Add(rs[1]);
                }
            }

            #endregion
            
            #region Salary Increment Rejection Letter

            if (EmailSubject.Equals("Salary Increment Rejection Letter"))
            {
                while (rs.Read())
                {
                    
                    if (rs[6].Equals("No"))
                        cmbComboBox.Items.Add(rs[1]);
                }
            }

            #endregion

            #region Salary Increment Rejection Letter

            if (EmailSubject.Equals("Salary Increment Confirmation Letter"))
            {
                while (rs.Read())
                {

                    if (rs[6].Equals("Yes"))
                        cmbComboBox.Items.Add(rs[1]);
                }
            }

            #endregion

            #region Leave Confirmation Letter

            if (EmailSubject.Equals("Leave Confirmation Letter"))
            {
                while (rs.Read())
                {

                    if (rs[5].Equals("Confirmed"))
                        cmbComboBox.Items.Add(rs[0]);
                }
            }

            #endregion
            
            #region In House Loan Rejection Letter

            if (EmailSubject.Equals("In House Loan Rejection Letter"))
            {
                while (rs.Read())
                {

                    if (rs[10].Equals("No") || rs[10].Equals(null))
                        cmbComboBox.Items.Add(rs[0]);
                }
            }

            #endregion
            
            #region In House Loan Confirmation Letter

            if (EmailSubject.Equals("In House Loan Confirmation Letter"))
            {
                while (rs.Read())
                {

                    if (rs[10].Equals("Yes"))
                        cmbComboBox.Items.Add(rs[0]);
                }
            }

            #endregion

            #region Retirement Reminding Letter

            if (EmailSubject.Equals("Retirement Reminding Letter"))
            {
                while (rs.Read())
                {
                    if (Convert.ToInt16(rs[1].ToString())<90)
                        cmbComboBox.Items.Add(rs[0]);
                }
            }

            #endregion

            #region Retirement Letter

            if (EmailSubject.Equals("Retirement Letter"))
            {
                while (rs.Read())
                {

                    if (Convert.ToInt16(rs[1].ToString()) < 10)
                        cmbComboBox.Items.Add(rs[0]);
                }
            }

            #endregion

            rs.Close();

            
        }

        #endregion

        #region Combobox Selection Change Method

        private void cmbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchID = cmbComboBox.SelectedItem.ToString();

            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = storedProcedureLetters;
            cmd.Parameters.AddWithValue("@Search_ID", SearchID);
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtFullName.Text = rs[1].ToString() + " " + rs[2].ToString() + " " + rs[3].ToString();
                employeeFirstName = rs[1].ToString();
                employeeFullName = txtFullName.Text;
                AddressLine1=rs[4].ToString();
                AddressLine2=rs[5].ToString();
                AddressLine3=rs[6].ToString();
                Email = rs[7].ToString();
            }

            txtAddress.Text = AddressLine1 + ", " + AddressLine2 + ", " + AddressLine3;
            txtEmail.Text = Email;
            
            rs.Close();
            btnGenerate.Enabled = true;


        }

        #endregion

    }
}
