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
    public partial class frmLoanDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        int checkConfirm = 0;

        #endregion

        #region Constructors

        public frmLoanDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region Form Load

        private void frmLoanDetails_Load(object sender, EventArgs e)
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
            dgvLoanDetails.Enabled = true;
            String OldBankLoanNo = null;
            SqlCommand command = new SqlCommand("sp_Select_BankLoanData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldBankLoanNo = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvLoanDetails.DataSource = dt;
            }
            rs.Close();
            return OldBankLoanNo;
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
            txtBankLoanNo.Enabled = false;
            ClearAllFields(this);

            String newBankLoanNo = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtBankLoanNo.Text = newBankLoanNo;


            checkSave = 1;
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
                    cmd.CommandText = "sp_Insert_BankData";
                }
                else
                {
                    cmd.CommandText = "Update_BankData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                if (chkConfirmed.Checked == true)
                {
                    checkConfirm = 1;
                }

                cmd.Parameters.AddWithValue("@Bank_Loan_Req_No", cmbLoanReqNo.Text.ToString());         //Bank_Loan_No?? nt in db
                cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Bank_Loan_No",txtBankLoanNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Start_Date", dtpStartDate.Value.Date);
                cmd.Parameters.AddWithValue("@End_Date", dtpEndDate.Value.Date);
                cmd.Parameters.AddWithValue("@Condition", checkConfirm);
                cmd.Parameters.AddWithValue("@Active", Convert.ToInt32(1));
               
                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Bank Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Bank Details Updated...");
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

        private void dgvLoanDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoanDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                cmbLoanReqNo.Text = dgvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtBankLoanNo.Text = dgvLoanDetails.SelectedRows[0].Cells[1].Value.ToString();
                dtpStartDate.Text = dgvLoanDetails.SelectedRows[0].Cells[2].Value.ToString();
                dtpEndDate.Text = dgvLoanDetails.SelectedRows[0].Cells[3].Value.ToString();
                chkConfirmed.Text = dgvLoanDetails.SelectedRows[0].Cells[4].Value.ToString();
                txtEmployeeNo.Text = dgvLoanDetails.SelectedRows[0].Cells[5].Value.ToString();
                txtFirstName.Text = dgvLoanDetails.SelectedRows[0].Cells[6].Value.ToString();
                txtLastName.Text = dgvLoanDetails.SelectedRows[0].Cells[7].Value.ToString();
                
             
            }
            txtBankLoanNo.Enabled = false;
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
                cmd.CommandText = "sp_Delete_LoanData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Loan_Req_No", cmbLoanReqNo.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Loan Details Deleted...");
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
