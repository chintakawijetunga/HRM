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
    public partial class frmSelectedApplicantInformation : Office2007Form
    {
        


        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        frmMDIMain form;
        #endregion

        #region Constructors

        public frmSelectedApplicantInformation(frmMDIMain form)
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

        #region Form Load

        private void frmSelectedApplicantInformation_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
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

        private void DisableAllControls(Control con,bool value)
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
            dgvSelectedApplicantData.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_SelectedApplicantData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvSelectedApplicantData.DataSource = dt;
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
            txtApplicantNo.Enabled = false;

            ClearAllFields(this);
            String newBankId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtApplicantNo.Text = newBankId;
            checkSave = 1;
            btnDelete.Enabled = false;
        }

         #endregion

        #region Fill ComboBox

        private void FillComboBox()
        {
            cmbDepartment.Items.Clear();
            cmbAppliedDesignation.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_DepartmentData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbDepartment.Items.Add(rs[1]);
            }

            rs.Close();

            cmd.CommandText = "sp_Select_DesignationData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                cmbAppliedDesignation.Items.Add(rs[1]);
            }

            rs.Close();



        }


        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldApplicantId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_SelectedApplicantData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldApplicantId = rs[0].ToString();
            rs.Close();
            return OldApplicantId;
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
            dgvSelectedApplicantData.DataSource = null;
            btnDelete.Enabled = false;
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
                    cmd.CommandText = "sp_Insert_SelectedApplicantData";
                }
                else
                {
                    cmd.CommandText = "Update_SelectedApplicantData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                
                String Gender = rbtMale.Checked ? "Male" : "Female";
                String CivilStatus = rbtSingle.Checked ? "Single" : "Married";
                            

                cmd.Parameters.AddWithValue("@Applicant_No", txtApplicantNo.Text.ToString());
                cmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text.ToString());
                cmd.Parameters.AddWithValue("@Middle_Name", txtMiddleName.Text.ToString());
                cmd.Parameters.AddWithValue("@Last_Name", txtLastName.Text.ToString());
                cmd.Parameters.AddWithValue("@Address1", txtAddressLine1.Text.ToString());
                cmd.Parameters.AddWithValue("@Address2", txtAddressLine2.Text.ToString());
                cmd.Parameters.AddWithValue("@Address3", txtAddressLine3.Text.ToString());
                cmd.Parameters.AddWithValue("@Telephone_No", Convert.ToInt32(txtTelephoneNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Date_Of_Birth", dtpDOB.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@NIC_No", txtNICNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Civil_Status", CivilStatus);
                cmd.Parameters.AddWithValue("@Designation_Name", cmbAppliedDesignation.Text.ToString());     
                cmd.Parameters.AddWithValue("@Experiences", txtExperiance.Text.ToString());
                cmd.Parameters.AddWithValue("@Department_Name", cmbDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text.ToString());
                cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text.ToString());
                cmd.Parameters.AddWithValue("@SpecialNotes", textBox1.Text.ToString());
                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Selected Employee Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Selected Employee Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
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
                cmd.CommandText = "sp_Delete_SelectedApplicantData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Applicant_No", txtApplicantNo.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvSelectedApplicantData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSelectedApplicantData.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtApplicantNo.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[1].Value.ToString();
                txtMiddleName.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[3].Value.ToString();
                txtNICNo.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[9].Value.ToString();
                dtpDOB.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[8].Value.ToString();

                if (dgvSelectedApplicantData.SelectedRows[0].Cells[10].Value.ToString() == "Male")
                {
                    rbtMale.Checked = true;
                }
                else
                {
                    rbtFemale.Checked = true;
                }

                if (dgvSelectedApplicantData.SelectedRows[0].Cells[11].Value.ToString() == "Single")
                {
                    rbtSingle.Checked = true;
                }
                else
                {
                    rbtMarried.Checked = true;
                }

                txtAddressLine1.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[4].Value.ToString();
                txtAddressLine2.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[5].Value.ToString();
                txtAddressLine3.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[6].Value.ToString();
                txtTelephoneNo.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[7].Value.ToString();
                cmbAppliedDesignation.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[12].Value.ToString();
                txtExperiance.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[13].Value.ToString();
                cmbDepartment.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[14].Value.ToString();
                txtEmailAddress.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[16].Value.ToString();
                txtMobileNo.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[17].Value.ToString();
                textBox1.Text = dgvSelectedApplicantData.SelectedRows[0].Cells[18].Value.ToString();
            }
            txtApplicantNo.Enabled = false;
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
            dlgSearch dlgBox = new dlgSearch("Search Selected Applicant Details", "Applicant_No", "First_Name", "Department_Name", "sp_Search_SelectedApplicantData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvSelectedApplicantData.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvSelectedApplicantData.DataSource = dt;
                    rs.Close();
                }
            }
        }
        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(txtApplicantNo.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtFirstName.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtNICNo.Text.ToString());
            bool x4 = String.IsNullOrEmpty(dtpDOB.Text.ToString());
            bool x5 = String.IsNullOrEmpty(txtAddressLine1.Text.ToString());
            bool x6 = String.IsNullOrEmpty(txtTelephoneNo.Text.ToString());
            bool x7 = String.IsNullOrEmpty(cmbAppliedDesignation.Text.ToString());
            bool x8 = String.IsNullOrEmpty(txtExperiance.Text.ToString());
            bool x9 = String.IsNullOrEmpty(txtEmailAddress.Text.ToString());
            
            if (!x1 && !x2 && !x3 && !x4 && !x5 && !x6 && !x7 && !x8)
                if (x9 || EmailValidate())
                {
                    if (PhoneValidate(txtTelephoneNo.Text))

                        return true;
                    else
                    {
                        MessageBox.Show("Contact Numbers are not in the correct format.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                else
                {
                    MessageBox.Show("Email Address is not in the correct format.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }




            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool PhoneValidate(String Number)
        {
            if (Number.Length < 7 || Number.Length > 12)
                return false;
            else
                return Regex.IsMatch(Number, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", RegexOptions.IgnoreCase);
        }

        private bool EmailValidate()
        {
            return Regex.IsMatch(txtEmailAddress.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
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
