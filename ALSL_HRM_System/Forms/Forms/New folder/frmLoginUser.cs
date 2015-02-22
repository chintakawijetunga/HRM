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
        #endregion

        #region Constructors

        public frmLoginUser()
        {
            InitializeComponent();
            DBConnectionMethod();
            btnLogin.Enabled = false;
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
                    MessageBox.Show("Welcome...");
                    
                    checkLogin = 1;
                }

            }

            if (checkLogin.Equals(0))
            {
                MessageBox.Show("Wrong...");
                txtPassword.Clear();
            }
            else 
            {
                AddToUserLoginData();
            }

            rs.Close();

        }

        private void AddToUserLoginData()
        {
            
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("hh:mm:ss"));
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








    }
}
