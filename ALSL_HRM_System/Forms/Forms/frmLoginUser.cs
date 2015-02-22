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
using System.Text.RegularExpressions;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class frmLoginUser : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        String userId;
        String password;
        String newLoginID;
        int check = 1;
        int count = 0;
        public static String UserType=null;
        public static String EmployeeIDLoggedIn = null;
        public static String currentUserName = null;
        #endregion

        #region Constructors

        public frmLoginUser()
        {
            InitializeComponent();
            DBConnectionMethod();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
        }

        #endregion

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        #region Cancel Method

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelMethod();
        }

        private void CancelMethod()
        {
            this.Close();
        }

        #endregion

        #region Login Method

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void LoginMethod()
        {
            userId = txtUserID.Text;
            password = txtPassword.Text;
            int checkLogin = 0;
            
            SqlCommand command = new SqlCommand("sp_Select_SystemUsersData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            rs = command.ExecuteReader();

            while (rs.Read())
            {
                 

                if (userId.Equals(rs[0].ToString()) && password.Equals(rs[2].ToString()))
                {
                    frmMDIMain mainForm = new frmMDIMain();
                    this.Visible = false;
                    UserType = rs[4].ToString();
                    EmployeeIDLoggedIn = rs[1].ToString();
                    AddToUserLoginData();
                    GetLoggedUserName();
                    mainForm.ShowDialog();
                    this.Visible = true;
                    txtPassword.Text = "";
                    checkLogin = 1;
                    break;
                }

            }

            if (checkLogin.Equals(0))
            {
                MessageBox.Show("Incorrect Username or Password.", Properties.Resources.CompanyName,MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Clear();
                count++;
            }
            
            if (count == 3)
            {
                MessageBox.Show("Access denied. \nPlease verify your credentials with the system admin.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                rs.Close();
            }
            rs.Close();

        }

        private void GetLoggedUserName()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Get_Currently_Logged_User";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                currentUserName = rs[0].ToString();
            }
            
            rs.Close();
        }

        private void AddToUserLoginData()
        {
            
            SqlCommand cmd = new SqlCommand("sp_Insert_UserLoginData", obj.sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            GenerateNewLoginID();

            cmd.Parameters.AddWithValue("@Login_ID", newLoginID);
            cmd.Parameters.AddWithValue("@User_ID", txtUserID.Text.ToString());
            cmd.Parameters.AddWithValue("@Login_Date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Login_Time", DateTime.Now.ToString("hh:mm:ss"));
            cmd.Parameters.AddWithValue("@Logout_Date", DBNull.Value);
            cmd.Parameters.AddWithValue("@Logout_Time", DBNull.Value);
            cmd.ExecuteNonQuery();

            


        }

        private void GenerateNewLoginID()
        {
            
            String oldLoginID=null;
            rs.Close();
            SqlCommand command = new SqlCommand("sp_Select_UserLoginData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            rs=command.ExecuteReader();

            while (rs.Read())
            {
                oldLoginID = rs[0].ToString();
            }

            newLoginID = Regex.Replace(oldLoginID, "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

        }
        #endregion

        #region Enable Login Button

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            CheckLoginEnable();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckLoginEnable();
        }

        private void CheckLoginEnable()
        {
            if (!txtUserID.Text.Equals("") && !txtPassword.Text.Equals(""))
            {

                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            
            }

        }

        #endregion

        #region Change Pasword Extention

        private void btnOptions_Click(object sender, EventArgs e)
        {

            if (check == 1)
            {
                this.Height = 610;
                check = 0;
                btnOptions.Text = "Change Password <<";
                

            }
            else
            {
                this.Height = 360;
                check = 1;
                btnOptions.Text = "Change Password >>";
            }
        }

        #endregion

        #region Form Load

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            
            btnLogin.Enabled = false;
            this.Height = 362;
            
        }

        #endregion

        #region Change Password

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
            txtUserName.Text = "";
            txtCurrentPassword.Text="";
            txtNewPassword.Text = "";
            txtReEnterPassword.Text = "";
        }


        private void ChangePassword()
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1 = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd1.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_SystemUsersData";
            cmd.Parameters.AddWithValue("@Employee_No", DBNull.Value);
            cmd.Parameters.AddWithValue("@User_ID", txtUserName.Text);

            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            if (rs.HasRows)
            {
                rs.Close();
                if (ValidateMethod())
                {
                    cmd1.CommandText = "Update_SystemUsersData";
                    cmd1.Parameters.AddWithValue("@UserID", txtUserName.Text);
                    cmd1.Parameters.AddWithValue("@Password", txtNewPassword.Text);
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

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {
             

            bool x1 = String.IsNullOrEmpty(txtNewPassword.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtReEnterPassword.Text.ToString());

            
            bool x3 = String.IsNullOrEmpty(txtCurrentPassword.Text.ToString());
            

            bool x5 = String.IsNullOrEmpty(txtUserName.Text.ToString());

            if (!x1 && !x2 && !x3 && !x5)
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
        
    }
}
