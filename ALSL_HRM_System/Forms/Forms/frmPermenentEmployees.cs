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
    public partial class frmPermenentEmployees : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        bool deleteApplicant = false; 
        frmMDIMain form;
        #endregion

        #region Constructors

        public frmPermenentEmployees(frmMDIMain form)
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

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {
            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();
            MdiParent = form;
        }

        #endregion

        #region Form Load

        private void frmPermenentEmployees_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
            EnableButtons(btnExit);
            FillAppicantNo();
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
                FillComboBox();
            }
        }

        private void PopulateData()
        {
            dgvPermenentEmployee.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_PermanentEmployeeData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvPermenentEmployee.DataSource = dt;
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
                    deleteApplicant = false;
                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillComboBox();
                        deleteApplicant = false;
                    }
            }
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtEmployeeNo.Enabled = false;
            cmbApplicantNo.Enabled = false;
            ClearAllFields(this);
            String newEmployeeId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtEmployeeNo.Text = newEmployeeId;
            checkSave = 1;
            btnDelete.Enabled = false;
        }

        

        #endregion

        #region FillCombo Boxes

        private void FillComboBox()
        {
            cmbDepartment.Items.Clear();
            cmbDesignation.Items.Clear();
            cmbBank.Items.Clear();
            colsQualificatrions.Items.Clear();
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

            cmd.CommandText = "sp_Select_BankData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                cmbBank.Items.Add(rs[1]);
            }

            rs.Close();

           

            cmd.CommandText = "sp_Select_QualificationRefrenceDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                
                colsQualificatrions.Items.Add(rs[1]);
            }

            rs.Close();

            cmd.CommandText = "sp_Select_DesignationData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                cmbDesignation.Items.Add(rs[1]);
            }

            rs.Close();

        }

        private void FillAppicantNo()
        {
            cmbApplicantNo.Items.Clear();
            cmbApplicantNo.Enabled = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_SelectedApplicantData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbApplicantNo.Items.Add(rs[0]);
            }

            rs.Close();
        }


        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldEmployeeId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_PermanentEmployeeData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldEmployeeId = rs[0].ToString();
            rs.Close();
            return OldEmployeeId;
        }


        #endregion

        #region ApplicantNo ComboBox Changed

        private void cmbApplicantNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            check = true;
            if (!checkChange)
            {
                AddNew();
                FillComboBox();
                btnAddNew.Enabled = false;
                GetApplicantDeatilsToTextBoxes();
            }
            else
                if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    AddNew();
                    FillComboBox();
                    btnAddNew.Enabled = false;
                    GetApplicantDeatilsToTextBoxes();
                }
        }

        #endregion

        #region Get Applicant Deatils to the TextBoxes

        private void GetApplicantDeatilsToTextBoxes()
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_SelectedApplicantData";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Applicant_No", cmbApplicantNo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@First_Name", DBNull.Value);
            cmd.Parameters.AddWithValue("@Department_Name", DBNull.Value);
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtFirstName.Text = rs[1].ToString();
                txtMiddleName.Text = rs[2].ToString();
                txtLastName.Text = rs[3].ToString();
                txtAddressLine1.Text = rs[4].ToString();
                txtAddressLine2.Text = rs[5].ToString();
                txtAddressLine3.Text = rs[6].ToString();
                txtTelephoneNo.Text = rs[7].ToString();
                dtpEmpDOB.Text = rs[8].ToString();
                txtNICNo.Text = rs[9].ToString();

                if (rs[10].ToString() == "Male")
                    rbtMale.Checked = true;
                else
                    rbtFemale.Checked = true;

                if (rs[11].ToString() == "Married")
                    rbtMarried.Checked = true;
                else
                    rbtSingle.Checked = true;

                cmbDesignation.Text = rs[12].ToString();
                txtPreviousExperiances.Text = rs[13].ToString();
                cmbDepartment.Text = rs[14].ToString();
                txtEmailAddress.Text = rs[16].ToString();
                txtMobileNo.Text = rs[17].ToString();
                txtSpecialNotes.Text = rs[18].ToString();

            }
            deleteApplicant = true;

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
            dgvPermenentEmployee.DataSource = null;
            btnDelete.Enabled = false;
            cmbApplicantNo.Text = "";
            btnAddNew.Enabled = true;
            cmbApplicantNo.Enabled = true;
            
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
                        btnAddNew.Enabled = true;
                        cmbApplicantNo.Enabled = true;
                        cmbApplicantNo.Text = "";
                        FillAppicantNo();

                    }
            }
        }

        private void SaveQualificationData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;

           
            cmd.CommandText = "sp_Insert_EmployeeQualificationData";
            

            cmd.CommandType = CommandType.StoredProcedure;

            String Qualifications = null;
            String QualificationDescription = null;
            for (int i = 0; i < dgvQualifications.Rows.Count - 1; i++)
            {
                Qualifications = dgvQualifications.Rows[i].Cells["colsQualificatrions"].Value.ToString();
                QualificationDescription = dgvQualifications.Rows[i].Cells["colsQualificationDescriptions"].Value.ToString();
                cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Qualification_No", Qualifications);
                cmd.Parameters.AddWithValue("@Qualification_Details", QualificationDescription);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
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
                cmd.CommandText = "sp_Insert_PermanentEmployeeData";
                
            }
            else
            {
                cmd.CommandText = "Update_PermanentEmployeeData";
            }

            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeNo.Text.ToString());
            cmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text.ToString());
            cmd.Parameters.AddWithValue("@Middle_Name", txtMiddleName.Text.ToString());
            cmd.Parameters.AddWithValue("@Last_Name", txtLastName.Text.ToString());
            cmd.Parameters.AddWithValue("@Address1", txtAddressLine1.Text.ToString());
            cmd.Parameters.AddWithValue("@Address2", txtAddressLine2.Text.ToString());
            cmd.Parameters.AddWithValue("@Address3", txtAddressLine3.Text.ToString());
            cmd.Parameters.AddWithValue("@Telephone_No", txtTelephoneNo.Text.ToString());
            cmd.Parameters.AddWithValue("@DOB", dtpEmpDOB.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@NIC_No", txtNICNo.Text.ToString());
            cmd.Parameters.AddWithValue("@Gender", rbtMale.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@CivilStatus", rbtSingle.Checked ? "Single" : "Married");
            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);
            cmd.Parameters.AddWithValue("@Designation_No", cmbDesignation.Text.ToString());       
            cmd.Parameters.AddWithValue("@Experiences", txtPreviousExperiances.Text.ToString());
            cmd.Parameters.AddWithValue("@Department_No", cmbDepartment.Text.ToString());
            cmd.Parameters.AddWithValue("@SpecialNotes", txtSpecialNotes.Text); 
            cmd.Parameters.AddWithValue("@Is_Active", rbtYesActive.Checked ? 1 : 0);
            cmd.Parameters.AddWithValue("@Is_On_Prob", rbtYesProbation.Checked ? "Yes" : "No");
            cmd.Parameters.AddWithValue("@Is_Extended", rbtYesExtend.Checked ? "Yes" : "No");
            cmd.Parameters.AddWithValue("@Emp_Date", dtpEmployeeDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Retire_Date", dtpRetirementDate.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@EPF_No", txtEPFNo.Text.ToString());
            cmd.Parameters.AddWithValue("@ETF_No", txtETFNo.Text.ToString());
            cmd.Parameters.AddWithValue("@Bank_Acc_No", txtBankAccountNo.Text.ToString());
            cmd.Parameters.AddWithValue("@BankName", cmbBank.Text.ToString());
            cmd.Parameters.AddWithValue("@Prob_Date", dtpProbationDate.Value.ToString("yyyy-MM-dd"));
             cmd.ExecuteNonQuery();
             //SaveQualificationData();

             if (checkSave == 1)
             {
                 SaveQualificationData();
                 if (deleteApplicant)
                 {
                     DeleteApplicantData();
                 }
                 deleteApplicant = false;
                 MessageBox.Show("Permanent Employee Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                 checkSave = 0;
             }
             else
             {
                 MessageBox.Show("Permanent Employee Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

             PopulateData();

            }

            catch (Exception e)
            {
                //MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        private void DeleteApplicantData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Delete_SelectedApplicantData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Applicant_No", cmbApplicantNo.Text.ToString());

                cmd.ExecuteNonQuery();
               // MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvPermenentEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPermenentEmployee.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtEmployeeNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvPermenentEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtMiddleName.Text = dgvPermenentEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvPermenentEmployee.SelectedRows[0].Cells[3].Value.ToString();
                txtAddressLine1.Text = dgvPermenentEmployee.SelectedRows[0].Cells[4].Value.ToString();
                txtAddressLine2.Text = dgvPermenentEmployee.SelectedRows[0].Cells[5].Value.ToString();
                txtAddressLine3.Text = dgvPermenentEmployee.SelectedRows[0].Cells[6].Value.ToString();
                txtTelephoneNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[7].Value.ToString();
                txtPreviousExperiances.Text = dgvPermenentEmployee.SelectedRows[0].Cells[8].Value.ToString();
                
                if (dgvPermenentEmployee.SelectedRows[0].Cells[9].Value.ToString() == "Male")
                {
                    rbtMale.Checked = true;
                }
                else 
                {
                    rbtFemale.Checked = true;
                }

                dtpEmpDOB.Text = dgvPermenentEmployee.SelectedRows[0].Cells[10].Value.ToString();
                txtNICNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[11].Value.ToString();
                cmbDesignation.Text = dgvPermenentEmployee.SelectedRows[0].Cells[12].Value.ToString();
                cmbDepartment.Text = dgvPermenentEmployee.SelectedRows[0].Cells[13].Value.ToString();
                dtpEmployeeDate.Text = dgvPermenentEmployee.SelectedRows[0].Cells[14].Value.ToString();
                dtpRetirementDate.Text = dgvPermenentEmployee.SelectedRows[0].Cells[15].Value.ToString();
                txtEPFNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[16].Value.ToString();
                txtETFNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[17].Value.ToString();
                txtBankAccountNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[18].Value.ToString();

                if (dgvPermenentEmployee.SelectedRows[0].Cells[19].Value.ToString() == "Yes")
                {
                    rbtYesProbation.Checked = true;
                }
                else
                {
                    rbtNoProbation.Checked = true;
                }

                if (dgvPermenentEmployee.SelectedRows[0].Cells[20].Value.ToString() == "1")
                {
                    rbtYesActive.Checked = true;
                }
                else
                {
                    rbtNoExtend.Checked = true;
                }

                if (dgvPermenentEmployee.SelectedRows[0].Cells[21].Value.ToString() == "Yes")
                {
                    rbtYesExtend.Checked = true;
                }
                else
                {
                    rbtNoExtend.Checked = true;
                }

                dtpProbationDate.Text = dgvPermenentEmployee.SelectedRows[0].Cells[25].Value.ToString();

                txtEmailAddress.Text = dgvPermenentEmployee.SelectedRows[0].Cells[29].Value.ToString();
                cmbBank.Text = dgvPermenentEmployee.SelectedRows[0].Cells[30].Value.ToString();
                txtMobileNo.Text = dgvPermenentEmployee.SelectedRows[0].Cells[31].Value.ToString();
                txtSpecialNotes.Text = dgvPermenentEmployee.SelectedRows[0].Cells[32].Value.ToString();

                if (dgvPermenentEmployee.SelectedRows[0].Cells[33].Value.ToString() == "Single")
                {
                    rbtSingle.Checked = true;
                }
                else 
                {
                    rbtMarried.Checked = true;
                }

               
            }
            txtEmployeeNo.Enabled = false;
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
                cmd.CommandText = "sp_Delete_PermanentEmployeeData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employee_No", txtEmployeeNo.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
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
            dlgSearch dlgBox = new dlgSearch("Search Employee Details", "Employee_No", "First_Name", "Department_Name", "sp_Search_PermanentEmployeeData2");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvPermenentEmployee.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvPermenentEmployee.DataSource = dt;
                    rs.Close();
                }
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

        #region Employee Number to Text change

        private void txtEmployeeNo_TextChanged(object sender, EventArgs e)
        {
            GetQualificationDetails();
        }

        private void GetQualificationDetails()
        {
            String Qualification = null;
            String QualificationDescription = null;
            colsQualificatrions.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_EmployeeQualificationData";
            cmd.Parameters.AddWithValue("@Employee_No", (txtEmployeeNo.Text).ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            int i = 0;
            while (rs.Read())
            {
                dgvQualifications.Rows.Add();
                Qualification=rs[1].ToString(); 
                QualificationDescription= rs[2].ToString();


                dgvQualifications.Rows[i].Cells["colsQualificationDescriptions"].Value = QualificationDescription;
                colsQualificatrions.Text = rs[1].ToString(); 
                i++;


            }

            rs.Close();
        }

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(txtEmployeeNo.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtFirstName.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtNICNo.Text.ToString());
            bool x4 = String.IsNullOrEmpty(dtpEmpDOB.Text.ToString());
            bool x5 = String.IsNullOrEmpty(txtAddressLine1.Text.ToString());
            bool x6 = String.IsNullOrEmpty(txtTelephoneNo.Text.ToString());
            bool x7 = String.IsNullOrEmpty(cmbDepartment.Text.ToString());
            bool x8 = String.IsNullOrEmpty(txtPreviousExperiances.Text.ToString());
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
    }
}
