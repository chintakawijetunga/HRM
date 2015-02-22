using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Text.RegularExpressions;
using ALSL_HRM_System.DialogBoxes;

namespace ALSL_HRM_System.Forms
{
    public partial class frmLoanTypeDetails : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmLoanTypeDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {
            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();
        }

        #endregion

        #region Form Load

        private void frmLoanTypeDetails_Load(object sender, EventArgs e)
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

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData(1);
        }

        private String PopulateData(int check)
        {
            dgvLoanTypeDetails.Enabled = true;
            String OldLoanTypeNo = null;
            SqlCommand command = new SqlCommand("sp_Select_LoanTypeData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldLoanTypeNo = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvLoanTypeDetails.DataSource = dt;
            }
            rs.Close();
            return OldLoanTypeNo;
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
            txtLoanTypeNumber.Enabled = false;
            //btnUpdate.Enabled = false;
            ClearAllFields(this);
            String newLoanTypeNo = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtLoanTypeNumber.Text = newLoanTypeNo;
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

        #region Save Data Methods

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveData();

        }

        private void SaveData()
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_LoanTypeData";
                }
                else
                {
                     cmd.CommandText = "Update_LoanTypeData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Loan_Type_No", txtLoanTypeNumber.Text.ToString());
                cmd.Parameters.AddWithValue("@Loan_Des", txtLoanTypeDescripton.Text.ToString());


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Loan Type Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Loan Type Details Updated...");
                }

                PopulateData(1);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvLoanTypeDetails_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvLoanTypeDetails.SelectedRows.Count == 1)
            {

                DisableAllControls(this, true);
                txtLoanTypeNumber.Text = dgvLoanTypeDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtLoanTypeDescripton.Text = dgvLoanTypeDetails.SelectedRows[0].Cells[1].Value.ToString();
            
            }

            txtLoanTypeNumber.Enabled = false;

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
                cmd.CommandText = "sp_Delete_LoanTypeData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Loan_Type_No", txtLoanTypeNumber.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Loan Type Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion
    }
}
