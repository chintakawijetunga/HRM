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
using ALSL_HRM_System.Forms.Forms;


namespace ALSL_HRM_System.Forms
{
    public partial class frmLoanDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        //String checkConfirm = null;
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

        public frmLoanDetails(frmMDIMain form)
        {
            MdiParent = form;
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

        private void frmLoanDetails_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
            rbtBankLoan.Enabled = true;
            rbtInHouseLoan.Enabled = true;

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
            dgvLoanDetails.Enabled = true;

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
            dgvLoanDetails.DataSource = dt;
            rs.Close();
        }

        #endregion

        #region RadioButton Enable Disable

        private void RadioButtonEnableDiable(bool value)
        {
            rbtBankLoan.Enabled = value;
            rbtInHouseLoan.Enabled = value;
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
                    FillComboBoxes();
                    DisableAllControls(this, true);
                    RadioButtonEnableDiable(false);


                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        FillComboBoxes();
                        DisableAllControls(this, true);
                        RadioButtonEnableDiable(false);
                    }
            }
        }

        
        
        #endregion

        #region Fill ComboBoxes

        private void FillComboBoxes()
        {
            cmbLoanReqNo.Items.Clear();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            if (rbtBankLoan.Checked)
                cmd.CommandText = "sp_Select_BankLoanData";
            else
                cmd.CommandText = "sp_Select_InHouseLoanRequestData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbLoanReqNo.Items.Add(rs[0].ToString());

            }

            rs.Close();

            
        }


        #endregion

        #region Save Data Methods

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
            String Condition = null;
            if (rbtBankLoan.Checked)
            {
                cmd.CommandText = "Update_BankLoanData2";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_Loan_Req_No", cmbLoanReqNo.Text.ToString());

                cmd.Parameters.AddWithValue("@Loan_No", txtBankLoanNo.Text.ToString());
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@End_Date", dtpEndDate.Value.ToString("yyyy-MM-dd"));

                if (chkConfirmed.Checked)
                    Condition = "Yes";
                else
                    Condition = "No";

                cmd.Parameters.AddWithValue("@Condition", Condition);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Bank Loan Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
               
                cmd.CommandText = "Update_InHouseLoanData2";
                

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Loan_Req_NO", cmbLoanReqNo.Text.ToString());
                cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.ToString("yyyy-MM-dd"));

                if (chkConfirmed.Checked)
                    Condition = "Yes";
                else
                    Condition = "No";

                cmd.Parameters.AddWithValue("@Condition", Condition);





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

        private void dgvLoanDetails_SelectionChanged(object sender, EventArgs e)
        {
            check = false;
            if (dgvLoanDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                cmbLoanReqNo.Text = dgvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeNo.Text = dgvLoanDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvLoanDetails.SelectedRows[0].Cells[2].Value.ToString();
                String condition;
                if (rbtBankLoan.Checked)
                {
                    txtBankLoanNo.Text = dgvLoanDetails.SelectedRows[0].Cells[11].Value.ToString();
                    dtpStartDate.Text = dgvLoanDetails.SelectedRows[0].Cells[12].Value.ToString();
                    dtpEndDate.Text = dgvLoanDetails.SelectedRows[0].Cells[13].Value.ToString();
                    condition = dgvLoanDetails.SelectedRows[0].Cells[14].Value.ToString();
                    if (condition == "Yes")
                        chkConfirmed.Checked = true;
                    else
                        chkConfirmed.Checked = false;
                }
                else
                {
                    txtBankLoanNo.Clear();
                    txtBankLoanNo.Enabled = false;
                    dtpStartDate.Text = dgvLoanDetails.SelectedRows[0].Cells[8].Value.ToString();
                    dtpEndDate.Text = dgvLoanDetails.SelectedRows[0].Cells[9].Value.ToString();
                }
            }
            btnDelete.Enabled = true;
            check = true;
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

            dgvLoanDetails.DataSource = null;
            btnDelete.Enabled = false;
            RadioButtonEnableDiable(true);
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

            if (rbtBankLoan.Checked)
                SP = "sp_Search_BankLoanData";
            else
                SP = "sp_Search_InHouseLoanRequestData";


            dlgSearch dlgBox = new dlgSearch("Search Loan Details", "Loan_Request_No", "Employee_ID", "Loan_Type", SP);

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvLoanDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvLoanDetails.DataSource = dt;
                    rs.Close();
                }
            }
        }

        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't delete an existing Loan Request Data. \nRefer the Loan Request Window for details to proceed.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error); 
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

        #region ComboBox  Value Chnaged

        private void cmbLoanReqNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            if (rbtBankLoan.Checked)
            {
                cmd.CommandText = "sp_Search_BankLoanData";
            }
            else
            {
                cmd.CommandText = "sp_Search_InHouseLoanRequestData";
            
            }
            cmd.Parameters.AddWithValue("@Loan_Request_No", (cmbLoanReqNo.Text).ToString());
            cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
            cmd.Parameters.AddWithValue("@Loan_Type", DBNull.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtEmployeeNo.Text = rs[1].ToString();
            }

            rs.Close();
            cmd = null;
            cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_PermanentEmployeeData";
            cmd.Parameters.AddWithValue("@Employee_No", (txtEmployeeNo.Text).ToString());
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
            bool x2 = false;
            bool x1 = String.IsNullOrEmpty(cmbLoanReqNo.Text.ToString());
            if (rbtBankLoan.Checked)
            {
                x2 = String.IsNullOrEmpty(txtBankLoanNo.Text.ToString());
            }
            bool x3 = String.IsNullOrEmpty(dtpStartDate.Value.ToString("yyyy-MM-dd"));
            bool x4 = String.IsNullOrEmpty(dtpEndDate.Value.ToString("yyyy-MM-dd"));
            

            
            if (!x1 && !x2 && !x3 && !x4)
            {

                if (Convert.ToDateTime(dtpStartDate.Value.ToString("yyyy-MM-dd")) > Convert.ToDateTime(dtpEndDate.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Start date should be less than End date.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                else
                {
                    return true;

                }

            }
            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }




        #endregion

        #region Radio Button Change

        private void rbtChange_CheckedChanged(object sender, EventArgs e)
        {
            


            if (!checkChange)
            {
                PopulateData();
                this.frmLoanDetails_Load(sender, e);
                cmbLoanReqNo.Text = "";


            }
            else

                if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PopulateData();
                    this.frmLoanDetails_Load(sender, e);
                    cmbLoanReqNo.Text = "";
                }


            checkChange = false;
        }

        #endregion

        #region Content Change Methods

        private void txtChanged_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }
        #endregion



    }
}
