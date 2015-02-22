using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using System.Text.RegularExpressions;

namespace ALSL_HRM_System.Forms.Forms
{
    public partial class frmChangeProfile : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        //int checkSave = 0;
        //bool checkChange = false;
        //bool check = false;
        
        #endregion

        #region Constructors
        public frmChangeProfile()
        {
            
            InitializeComponent();
            this.TopMost = true;
            DBConnectionMethod();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;

            if(frmLoginUser.UserType == "Manager Level")
            {
            }
            else if (frmLoginUser.UserType == "Employee Level")
            {
            }
            else
            {
                cmbAccessLevel.Enabled=true;
                rbtCreateProfile.Enabled = true;

            }

        }
        #endregion

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        #region Radio Button Change Event

        private void rbtCreateProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCreateProfile.Checked)
            {
                txtCurrentPassword.Enabled = false;
                txtEmployeeID.Enabled = true;
                SetNextID();
            }
            else 
            {
                txtCurrentPassword.Enabled = true;
                txtEmployeeID.Enabled = false;
                txtUserName.Enabled = true;
                txtUserName.Text = "";
            }
        }

        private void SetNextID()
        {
            
            txtUserName.Enabled = false;

            String newUserId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtUserName.Text = newUserId;
            
        }


        private String GetNextID()
        {
            String OldUserId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_SystemUsersData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldUserId = rs[0].ToString();
            rs.Close();
            return OldUserId;
        }

        #endregion
        
        #region Exit Method

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void ExitMethod()
        {
            this.Close();
        }

        #endregion

        #region Save Method

        private void btnChangeCreate_Click(object sender, EventArgs e)
        {
            SaveMethod();
        }

        private void SaveMethod()
        {
            if (rbtCreateProfile.Checked)
            {
                CreateProfile();
            }

            else if (rbtChangePassword.Checked)
            {
                ChangePassword();
            
            }
        }

        private void ChangePassword()
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd1.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_SystemUsersData2";
            cmd.Parameters.AddWithValue("@Password", txtCurrentPassword.Text);
            cmd.Parameters.AddWithValue("@User_ID", txtUserName.Text);

            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            if (rs.HasRows)
            {
                rs.Close();
                if (ValidateMethod())
                {
                    cmd1.CommandText = "Update_SystemUsersData2";
                    cmd1.Parameters.AddWithValue("@UserID", txtUserName.Text);
                    cmd1.Parameters.AddWithValue("@Password", txtNewPassword.Text);
                    cmd1.Parameters.AddWithValue("@AccessLevel", cmbAccessLevel.Text.ToString());
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Password is changed.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {

                MessageBox.Show("User Name or Password is Incorrect", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            rs.Close();
        }

        private void CreateProfile()
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd1.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_SystemUsersData";
            cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeID.Text);
            cmd.Parameters.AddWithValue("@User_ID", DBNull.Value);

            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            if (!rs.HasRows)
            {
                rs.Close();
                if (ValidateMethod())
                {
                    cmd1.CommandText = "sp_Insert_SystemUsersData";
                    cmd1.Parameters.AddWithValue("@User_ID", txtUserName.Text);
                    cmd1.Parameters.AddWithValue("@Employee_No", txtEmployeeID.Text);
                    cmd1.Parameters.AddWithValue("@Password", txtNewPassword.Text);
                    cmd1.Parameters.AddWithValue("@AccessLevel", cmbAccessLevel.Text.ToString());
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("New Account Created.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {

                MessageBox.Show("User account already exits for the Employee ID specified.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            rs.Close();
        }

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {
            bool x3=false;
            bool x4 = false;
            bool x1 = String.IsNullOrEmpty(txtNewPassword.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtReEnterPassword.Text.ToString());

            if (rbtChangePassword.Checked)
            {
                x3 = String.IsNullOrEmpty(txtCurrentPassword.Text.ToString());
            }
            else
            {
                x4 = String.IsNullOrEmpty(txtEmployeeID.Text.ToString());
            }
            bool x5 = String.IsNullOrEmpty(txtUserName.Text.ToString());
            bool x6 = String.IsNullOrEmpty(cmbAccessLevel.Text.ToString());

            if (!x1 && !x2 && !x3 && !x4 && !x5 && !x6)
            {
                if (txtNewPassword.Text.ToString().Equals(txtReEnterPassword.Text.ToString()))
                {
                    return true;
                }

                else
                {

                    MessageBox.Show("Passwords field are not identical.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else 
            {
                MessageBox.Show("Password is required.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                return false;
            }

        }

        


        #endregion

        #region EmployeeID Text Change

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (rbtChangePassword.Checked)
            {
                if (txtEmployeeID.Text.Length == 7)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = obj.sqlConnection;
                    cmd.CommandText = "sp_Search_SystemUsersData";
                    cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@User_ID", DBNull.Value);

                    cmd.CommandType = CommandType.StoredProcedure;
                    rs = cmd.ExecuteReader();

                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            cmbAccessLevel.Text = "";//AccessLevel from DB

                        }
                    }

                    else 
                    {
                        if (MessageBox.Show("User account doesn't exits for the Employee ID specified. Create Account?", Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            rbtCreateProfile.Checked = true;
                        
                        }

                    }
                
                }
            
            }
        }

        #endregion

        #region Username Change event

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 7)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = obj.sqlConnection;
                    cmd.CommandText = "sp_Search_SystemUsersData2";
                    cmd.Parameters.AddWithValue("@User_ID", txtUserName.Text.ToString());
                    cmd.Parameters.AddWithValue("@Password", DBNull.Value);
                    cmd.CommandType = CommandType.StoredProcedure;
                    rs = cmd.ExecuteReader();

                    while (rs.Read())
                    {
                        cmbAccessLevel.Text = rs[4].ToString();
                    }

                    rs.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }

            }
            else
            {

                cmbAccessLevel.Text = "";
            }
        }

        #endregion

        private void frmChangeProfile_Load(object sender, EventArgs e)
        {
            rbtChangePassword.Checked = true;
            txtEmployeeID.Enabled = false;
        }

        
    }
}
