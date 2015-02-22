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
    public partial class frmLoanRequestDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmLoanRequestDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region Form Load

        private void frmLoanRequestDetails_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
        }

        #endregion

        #region Control Enable and Disable Methods

        private void EnableButtons(Control button)
        {
            if (button != null)
            {
                button.Enabled = true;
                EnableButtons(button.Parent);
            }
        }

        private void DisableAllControls(Control con, bool value)
        {
            foreach (Control c in con.Controls)
            {
                DisableAllControls(c, value);
            }
            con.Enabled = value;
        }

        #endregion

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {
            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();
        }

        #endregion

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData(1);
        }

        private String PopulateData(int check)
        {
            dgvLoanTypeRequestDetails.Enabled = true;
            String OldLoanReqNo = null;
            SqlCommand command = new SqlCommand("sp_Select_LoanRequestData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldLoanReqNo = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvLoanTypeRequestDetails.DataSource = dt;
            }
            rs.Close();
            return OldLoanReqNo;
        }

        #endregion

        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtLoanRequestNumber.Enabled = false;
            ClearAllFields(this);

            String newLoanReqNumber = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtLoanRequestNumber.Text = newLoanReqNumber;


            checkSave = 1;
        }

        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields(this);
        }

        private void ClearAllFields(Control con)
        {

            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllFields(c);
            }
        }

        #endregion

        #region Save Data Method
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvLoanTypeRequestDetails_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region DialogBox and Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }

        private void OpenDialogBox()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            PopulateData(1);
            ClearAllFields(this);
        }

        private void DeleteData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Delete_LoanRequestData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_Loan_Req_No", txtLoanRequestNumber.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Loan Request Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }
        }

        #endregion

        #region Exit Method

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            this.Close();
        }

        #endregion
    }
}