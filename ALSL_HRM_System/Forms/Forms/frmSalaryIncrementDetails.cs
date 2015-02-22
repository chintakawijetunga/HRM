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
    public partial class frmSalaryIncrementDetails : Office2007Form
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

        public frmSalaryIncrementDetails(frmMDIMain form)
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

        private void frmSalaryIncrementDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
            txtRequestAmount.Enabled = false;
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
            }
        }

        private void PopulateData()
        {
            dgvSalaryIncrementDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_SalaryIncrementData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvSalaryIncrementDetails.DataSource = dt;
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
                    FillComboBox();
                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillComboBox();
                    }
            }
        }

        


        private void AddNew()
        {
            DisableAllControls(this, true);
            txtSalaryIncrementID.Enabled = false;
            ClearAllFields(this);
            String newSalaryIncrementID = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtSalaryIncrementID.Text = newSalaryIncrementID;
            rbtYes.Checked = true;
           
            checkSave = 1;
        }

        #endregion

        #region FillCombo Boxes
        private void FillComboBox()
        {
            cmbSalIncrReqID.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_SalaryIncrementRequestData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbSalIncrReqID.Items.Add(rs[0]);
            }

            rs.Close();
        }
        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldSalIncId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_SalaryIncrementData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldSalIncId = rs[0].ToString();
            rs.Close();
            return OldSalIncId;
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
                    }
            }
        }

        private void SaveData()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                
                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_SalaryIncrementData";
                }
                else
                {
                    cmd.CommandText = "Update_SalaryIncrementData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

               
             
                cmd.Parameters.AddWithValue("@Sal_Inc_ID", txtSalaryIncrementID.Text.ToString());
                cmd.Parameters.AddWithValue("@Sal_Inc_Req_ID", cmbSalIncrReqID.Text.ToString());
                cmd.Parameters.AddWithValue("@Condition", (rbtYes.Checked ? "Yes" : "No"));
                cmd.Parameters.AddWithValue("@RecDate", dtpEffectingFrom.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(txtIncrementAmt.Text.ToString()));
                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Bank Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Bank Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvSalaryIncrementDetails_SelectionChanged(object sender, EventArgs e)
        {

            check = false;
            if (dgvSalaryIncrementDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtSalaryIncrementID.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbSalIncrReqID.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtRequestAmount.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[3].Value.ToString();
                
                dtpEffectingFrom.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[5].Value.ToString();
             
                if (dgvSalaryIncrementDetails.SelectedRows[0].Cells[6].Value.ToString() == "Yes")
                {
                    rbtYes.Checked = true;
                    rbtNo.Checked = false;
                    txtIncrementAmt.Enabled = true;
                }
                else
                {
                    rbtYes.Checked = false;
                    rbtNo.Checked = true;
                    txtIncrementAmt.Enabled = false;
                }
                txtIncrementAmt.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[4].Value.ToString();
                               
            }
            txtSalaryIncrementID.Enabled = false;
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
            dgvSalaryIncrementDetails.DataSource = null;
            btnDelete.Enabled = false;
            dtpEffectingFrom.Value = DateTime.Now;
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
            dlgSearch dlgBox = new dlgSearch("Search Salary Increment Details", "Salary_Increment_ID", "Salary_Increment_Request_ID", "Employee_ID", "sp_Search_SalaryIncrementData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvSalaryIncrementDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvSalaryIncrementDetails.DataSource = dt;
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
                cmd.CommandText = "sp_Delete_SalaryIncrementData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sal_Inc_ID", txtSalaryIncrementID.Text.ToString());

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
        
        #region RadioButton Changed

        private void rbtChanged_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtYes.Checked)
            {
                txtIncrementAmt.Enabled = true;
                dtpEffectingFrom.Enabled = true;
                txtIncrementAmt.Text = "";
            }
            else
            {
                txtIncrementAmt.Enabled = false;
                dtpEffectingFrom.Enabled = false;
                txtIncrementAmt.Text = "0";
            }
        }

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {
            int testConvert;
            bool x1 = String.IsNullOrEmpty(txtSalaryIncrementID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(cmbSalIncrReqID.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtEmployeeName.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtIncrementAmt.Text.ToString());

            if (!x1 && !x2 && !x3 && !x4)
            {
                if (int.TryParse(txtIncrementAmt.Text.ToString(), out testConvert))
                {
                    if (testConvert > 0)
                        return true;
                    else
                    {
                        MessageBox.Show("Amount should be greater than zero.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                else
                {
                    MessageBox.Show("Amount should be numeric.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion

        #region Content Change Methods

        private void txtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }
        #endregion

        private void cmbSalIncrReqID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Search_SalaryIncrementRequestData";
                cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary_Increment_Request_No", (cmbSalIncrReqID.Text).ToString());
                cmd.Parameters.AddWithValue("@Unused", DBNull.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    txtEmployeeName.Text = rs[2].ToString();
                    txtRequestAmount.Text = rs[3].ToString();
                }

                rs.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

    }
}
