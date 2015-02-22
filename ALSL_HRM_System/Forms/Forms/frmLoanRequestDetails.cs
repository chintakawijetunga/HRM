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
using ALSL_HRM_System.DialogBoxes;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class frmLoanRequestDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        frmMDIMain form;
        #endregion

        #region Shortcut Keys

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F2))
            {
                if (btnPopulate.Enabled)
                    btnPopulate.PerformClick();
                return true;
            }

            if (keyData == (Keys.F3))
            {
                if (btnAddNew.Enabled)
                    btnAddNew.PerformClick();
                return true;
            }

            if (keyData == (Keys.F4) || (keyData == (Keys.Control | Keys.S)))
            {
                if (btnSave.Enabled)
                    btnSave.PerformClick();
                return true;
            }

            if (keyData == (Keys.F5))
            {
                if (btnDelete.Enabled)
                    btnDelete.PerformClick();
                return true;
            }

            if (keyData == (Keys.F6))
            {
                if (btnClear.Enabled)
                    btnClear.PerformClick();
                return true;
            }

            if (keyData == (Keys.F7))
            {
                if (btnSave.Enabled)
                    btnSearch.PerformClick();
                return true;
            }

            if (keyData == (Keys.F8))
            {
                if (btnExit.Enabled)
                    btnExit.PerformClick();
                return true;
            }

            if (keyData == (Keys.F1))
            {
                if (btnPopulate.Enabled)
                    btnAddNew.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Constructors

        public frmLoanRequestDetails(frmMDIMain form)
        {
            this.form = form;
            InitializeComponent();
            DBConnectionMethod();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            btnAddNew.BackgroundImage = Properties.Resources.New;
            btnPopulate.BackgroundImage = Properties.Resources.Populate;
            btnSave.BackgroundImage = Properties.Resources.Save1;
            btnDelete.BackgroundImage = Properties.Resources.Delete1;
            btnClear.BackgroundImage = Properties.Resources.Clear;
            btnSearch.BackgroundImage = Properties.Resources.Search;
            btnExit.BackgroundImage = Properties.Resources.HomeExit;
        }

        #endregion

        #region Form Load

        private void frmLoanRequestDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
            rbtBankLoan.Enabled = true;
            rbtInHouseLoan.Enabled = true;
            //rbtBankLoan.Checked = true;
            EnableButtons(btnExit);
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
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PopulateData();
                check = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = true;
                RadioButtonEnableDiable(true);
            }
        }

        private void PopulateData()
        {
            dgvLoanRequestDetails.Enabled = true;

            SqlCommand command;
            if (rbtBankLoan.Checked)
            {
                command = new SqlCommand("sp_Select_BankLoanData", obj.sqlConnection);
            }
            else
            {
                command = new SqlCommand("sp_Select_InHouseLoanRequestData", obj.sqlConnection);
            }
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvLoanRequestDetails.DataSource = dt;
            rs.Close();
            
        }

        #endregion

        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(frmLoginUser.UserType == "Manager Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                check = true;
                if (!checkChange)
                {
                    AddNew();
                    FillComboBoxes();
                    RadioButtonEnableDiable(false);

                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillComboBoxes();
                        RadioButtonEnableDiable(false);
                    }

            }

        }



        private void RadioButtonEnableDiable(bool value)
        {
            rbtBankLoan.Enabled = value;
            rbtInHouseLoan.Enabled = value;
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtLoanRequestNumber.Enabled = false;
            ClearAllFields(this);

            String newLoanReqNumber = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtLoanRequestNumber.Text = newLoanReqNumber;


            checkSave = 1;
            if (rbtBankLoan.Checked)
            {
                cmbBank.Enabled = true;
                cmbBranch.Enabled = true;
            }
            else
            {
                cmbBank.Enabled = false;
                cmbBranch.Enabled = false;
            }
        }

        #endregion

        #region Fill ComboBoxes

        private void FillComboBoxes()
        {
            cmbBank.Items.Clear();
            cmbBranch.Items.Clear();
            cmbEmployeeNumber.Items.Clear();
            cmbLoanType.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_PermanentEmployeeData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbEmployeeNumber.Items.Add(rs[0].ToString());
                               
            }

            rs.Close();

            cmd.CommandText = "sp_Select_LoanTypeData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbLoanType.Items.Add(rs[1].ToString());

            }

            rs.Close();

            cmd.CommandText = "sp_Select_BankData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbBank.Items.Add(rs[1].ToString());

            }

            rs.Close();
        }


        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldLoanId = null;
            SqlCommand command;
            if (rbtBankLoan.Checked)
            {
                command = new SqlCommand("sp_SelectAll_BankLoanData", obj.sqlConnection);
            }
            else {
                command = new SqlCommand("sp_SelectAll_InHouseLoanRequestData", obj.sqlConnection);
            }
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldLoanId = rs[0].ToString();
            rs.Close();
            return OldLoanId;
        }


        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!checkChange)
                ClearAllFields(this);
            else
                if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    ClearAllFields(this);
            checkChange = false;
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
            dgvLoanRequestDetails.DataSource = null;
            btnDelete.Enabled = false;
            RadioButtonEnableDiable(true);
        }

        #endregion

        #region Save Data Method
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (ValidateMethod())

                    if (MessageBox.Show(Properties.Resources.Save, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SaveData();
                        checkChange = false;
                        btnDelete.Enabled = true;
                        RadioButtonEnableDiable(true);
                    }
            }
        }

        private void SaveData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;

            if (rbtBankLoan.Checked)
            {
                

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_BankLoanData";
                }
                else
                {
                    cmd.CommandText = "Update_BankLoanData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Bank_Loan_Req_No", txtLoanRequestNumber.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_No", cmbEmployeeNumber.Text.ToString());
                cmd.Parameters.AddWithValue("@Loan_Type_No", cmbLoanType.Text.ToString());
                cmd.Parameters.AddWithValue("@Loan_Amount", Convert.ToInt32(txtLoanAmount.Text.ToString()));
                cmd.Parameters.AddWithValue("@Bank_ID", cmbBank.Text.ToString());
                cmd.Parameters.AddWithValue("@Branch_ID", cmbBranch.Text.ToString());
                cmd.Parameters.AddWithValue("@Instalment_Amt", Convert.ToInt32(txtInstallmentAmount.Text.ToString()));
                cmd.Parameters.AddWithValue("@Request_Date", dtpRequestDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Loan_Duration", txtDuration.Text.ToString());
                cmd.Parameters.AddWithValue("@RecDate", (DateTime.Now).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Loan_No", DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@End_Date", DBNull.Value);
                cmd.Parameters.AddWithValue("@Condition", DBNull.Value);
                



                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Bank Loan Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Bank Loan Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            
            
            }

            else
            {
                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_InHouseLoanData";
                }
                else
                {
                    cmd.CommandText = "Update_InHouseLoanData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Loan_Req_NO", txtLoanRequestNumber.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_ID", cmbEmployeeNumber.Text.ToString());
                cmd.Parameters.AddWithValue("@Loan_Type_NO", cmbLoanType.Text.ToString());
                cmd.Parameters.AddWithValue("@Loan_Amount", Convert.ToInt32(txtLoanAmount.Text.ToString()));
                cmd.Parameters.AddWithValue("@Instalment_Amt", Convert.ToInt32(txtInstallmentAmount.Text.ToString()));
                cmd.Parameters.AddWithValue("@Request_Date", dtpRequestDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Loan_Duration", txtDuration.Text.ToString());
                cmd.Parameters.AddWithValue("@RecDate", (DateTime.Now).ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@Condition", DBNull.Value);

                



                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("In House Loan Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("In House Loan Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            
            
            }
            PopulateData();

        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvLoanRequestDetails_SelectionChanged(object sender, EventArgs e)
        {
            check = false;
            if (dgvLoanRequestDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtLoanRequestNumber.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeNumber.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[2].Value.ToString();
                cmbLoanType.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtLoanAmount.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[4].Value.ToString();
                if (rbtBankLoan.Checked)
                {
                    cmbBank.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[5].Value.ToString();
                    cmbBranch.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[6].Value.ToString();
                    txtInstallmentAmount.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[7].Value.ToString();
                    dtpRequestDate.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[8].Value.ToString();
                    txtDuration.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[9].Value.ToString();
                }
                else
                {
                    txtInstallmentAmount.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[5].Value.ToString();
                    dtpRequestDate.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[6].Value.ToString();
                    txtDuration.Text = dgvLoanRequestDetails.SelectedRows[0].Cells[7].Value.ToString();
                }
            }
            btnDelete.Enabled = true;
            check = true;
        }

        #endregion

        #region DialogBox and Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!checkChange)
                    OpenDialogBox();
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        OpenDialogBox();



                btnExit.Enabled = true;
            }
        }

        private void OpenDialogBox()
        {
            String SP = null;

            if(rbtBankLoan.Checked)
                SP = "sp_Search_BankLoanData";
            else
                SP = "sp_Search_InHouseLoanRequestData";


            dlgSearch dlgBox = new dlgSearch("Search Loan Details", "Loan_Request_No", "Employee_ID", "Loan_Type", SP);

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvLoanRequestDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvLoanRequestDetails.DataSource = dt;
                    rs.Close();
                }
            }
        }

        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(frmLoginUser.UserType == "Manager Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show(Properties.Resources.Delete, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteData();
                    ClearAllFields(this);
                    PopulateData();
                }
            }
        }

        private void DeleteData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                if (rbtBankLoan.Checked)
                {
                    cmd.CommandText = "sp_Delete_EmployeeBankLoanData";
                    cmd.Parameters.AddWithValue("@Bank_Loan_Req_No", txtLoanRequestNumber.Text.ToString());
                }
                else 
                {
                    cmd.CommandText = "sp_Delete_EmployeeInHouseLoanData";
                    cmd.Parameters.AddWithValue("Loan_Req_No", txtLoanRequestNumber.Text.ToString());
                }

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
            if (!checkChange)
                if (MessageBox.Show(Properties.Resources.Exit, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ExitForm();
                }
                else { }
            else
            {
                if (MessageBox.Show(Properties.Resources.ContentChangedExit, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    ExitForm();
            }
        }

        private void ExitForm()
        {
            this.Close();
        }

        #endregion
        
        #region Radio Button Change
        private void rbtChange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBankLoan.Checked)
            {
                cmbBank.Enabled = true;
                cmbBranch.Enabled = true;
                
            }
            else 
            {
                cmbBank.Enabled = false;
                cmbBranch.Enabled = false;
            }
            
            
            if (!checkChange)
            {
                PopulateData();
                this.frmLoanRequestDetails_Load(sender, e);
                txtLoanRequestNumber.Text = "";
                    
                
            }
            else
                
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        PopulateData();
                        this.frmLoanRequestDetails_Load(sender, e);
                        txtLoanRequestNumber.Text = "";
                    }
                    
                
            checkChange = false;

        }

        private void RecoverID()
        {
            String newLoanReqNumber = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtLoanRequestNumber.Text = newLoanReqNumber;
            
        }
        #endregion

        #region Content Change Methods

        private void txtTextChange_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }
        #endregion

        #region ComboBox Selection Change

        private void cmbEmployeeNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_PermanentEmployeeData";
            cmd.Parameters.AddWithValue("@Employee_No", (cmbEmployeeNumber.SelectedItem).ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtEmployeeName.Text = rs[1].ToString() + " " + rs[2].ToString() + " " + rs[3].ToString();
            }

            rs.Close();
        }

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {
            bool x5, x6;
            int duration, lAmount, iAmount;
            bool x1 = String.IsNullOrEmpty(txtLoanRequestNumber.Text.ToString());
            bool x2 = String.IsNullOrEmpty(cmbEmployeeNumber.Text.ToString());
            bool x4 = String.IsNullOrEmpty((cmbLoanType.Text).ToString());
            if (rbtBankLoan.Checked)
            {
                x5 = String.IsNullOrEmpty((cmbBank.Text).ToString());
                x6 = String.IsNullOrEmpty((cmbBranch.Text).ToString());            
            
            }
            else
            {
                x5 = false;
                x6 = false;
            }
            
           bool x7 = String.IsNullOrEmpty(txtDuration.Text.ToString());
            bool x8 = String.IsNullOrEmpty(txtLoanAmount.Text.ToString());
            bool x9 = String.IsNullOrEmpty(txtInstallmentAmount.Text.ToString());

            if (!x1 && !x2 && !x4 && !x5 && !x6 && !x7)


                if (int.TryParse(txtDuration.Text.ToString(), out duration) && int.TryParse(txtLoanAmount.Text.ToString(), out lAmount) && int.TryParse(txtInstallmentAmount.Text.ToString(), out iAmount))
                {
                    if ((lAmount< iAmount*duration)) 
                    {
                        return true;
                    
                    }

                    else
                    {
                        MessageBox.Show("The Monthly instalments won't cover the loan amount in time. \nSpecify a higher monthly instalment value.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Amounts should be numberic. \nCan not contain other characters", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion
    }
}