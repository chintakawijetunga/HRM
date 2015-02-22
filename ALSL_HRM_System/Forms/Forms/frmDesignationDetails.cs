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
    public partial class frmDesignationDetails : Office2007Form
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

        public frmDesignationDetails(frmMDIMain form)
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

        private void frmDesignationDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
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

        #region Populate Method

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
            dgvDesignationDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_DesignationData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvDesignationDetails.DataSource = dt;
            rs.Close();

        }
        #endregion

        #region Add New

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
                    AddNew();
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        AddNew();
            }
        }
        private void AddNew()
        {
            DisableAllControls(this, true);
            txtDesignationID.Enabled = false;
            ClearAllFields(this);
            String newDesignationID = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtDesignationID.Text = newDesignationID;
            checkSave = 1;
            btnDelete.Enabled = false;
        }

        #endregion

        
        #region Get Methods

        private string GetNextID()
        {
            String OldDesignationId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_DesignationData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldDesignationId = rs[0].ToString();
            rs.Close();
            return OldDesignationId;
        }


        #endregion
        #region Save Method
        private void btnSave_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "sp_Insert_DesignationData";
                }
                else
                {
                    cmd.CommandText = "Update_DesignationData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Designation_No", txtDesignationID.Text.ToString());
                cmd.Parameters.AddWithValue("@Desg_Description", txtDesignationDescription.Text.ToString());
                cmd.Parameters.AddWithValue("@Basic_Salary", Convert.ToInt32(txtBasicSalary.Text.ToString()));
                cmd.Parameters.AddWithValue("@OT_Rate", Convert.ToInt32(txtOTRate.Text.ToString()));
                cmd.Parameters.AddWithValue("@Max_Loan_Value", Convert.ToInt32(txtMaxLoanValue.Text.ToString()));

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Designation Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Designation Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvDesignationDetails_SelectionChanged(object sender, EventArgs e)
        {

            check = false;
            if (dgvDesignationDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtDesignationID.Text = dgvDesignationDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtDesignationDescription.Text = dgvDesignationDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtBasicSalary.Text = dgvDesignationDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtOTRate.Text = dgvDesignationDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtMaxLoanValue.Text = dgvDesignationDetails.SelectedRows[0].Cells[4].Value.ToString();

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
            dlgSearch dlgBox = new dlgSearch("Search Designation Details", "Designation_ID", "Designation_Name", "Unused", "sp_Search_DesignationData");


            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvDesignationDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvDesignationDetails.DataSource = dt;
                    rs.Close();
                }
            }
        }

        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
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
                cmd.CommandText = "sp_Delete_DesignationData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Designation_No", txtDesignationID.Text.ToString());

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

        #region Content Change Method
        private void txtBoxChange_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }
        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {
            int testConvert=0;
            bool x1 = String.IsNullOrEmpty(txtDesignationID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtDesignationDescription.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtBasicSalary.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtOTRate.Text.ToString());
            bool x5 = String.IsNullOrEmpty(txtMaxLoanValue.Text.ToString());


            if (!x1 && !x2 && !x3 && !x4 && !x5)
            {
                if (int.TryParse(txtBasicSalary.Text.ToString(), out testConvert) && int.TryParse(txtOTRate.Text.ToString(), out testConvert) && int.TryParse(txtMaxLoanValue.Text.ToString(), out testConvert))
                {
                    if (testConvert > 0)
                        return true;
                    else
                    {
                        MessageBox.Show("Amounts should be greater than zero.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }
                }

                else
                {

                    MessageBox.Show("Can't specify character values.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }

}
