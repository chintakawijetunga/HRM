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
    public partial class frmVacancyData : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool check = false;
        String newVacancyId;
        String VacancyId;
        bool checkChange = false;
        frmMDIMain form;
        #endregion

        #region Constructors

        public frmVacancyData(frmMDIMain form)
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

        #region Form Load

        
        private void frmVacancyData_Load(object sender, EventArgs e)
        {
           // DisableAllControls(this, false);
            MdiParent = form;
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
            dgvVacancyDetails.Enabled = true;
        }


        #endregion

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {

            PopulateData();
            check = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            
        }


        private void PopulateData()
        {
            dgvVacancyDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_VacancyData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvVacancyDetails.DataSource = dt;
            rs.Close();
            btnClear.Enabled = true;


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

        private void FillComboBox()
        {
            cmbDepartment.Items.Clear();
            cmbDesignation.Items.Clear();
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
                cmbDesignation.Items.Add(rs[1]);
            }

            rs.Close();



        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            

            ClearAllFields(this);
            newVacancyId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            checkSave = 1;
            btnDelete.Enabled = false;
        }


        #endregion
        
        #region Get Methods

        private string GetNextID()
        {
            String OldVacancyId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_VacancyData", obj.sqlConnection);  
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldVacancyId = rs[0].ToString();
            rs.Close();
            return OldVacancyId;
        }


        #endregion

        #region Save Data Methods

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateMethod())

                if (MessageBox.Show(Properties.Resources.Save, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveData();
                    checkChange = false;
                    btnDelete.Enabled = true;
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
                    cmd.CommandText = "sp_Insert_VacancyData";
                    cmd.Parameters.AddWithValue("@VacancyID", newVacancyId);
                }
                else
                {
                    cmd.CommandText = "Update_VacancyData";
                    cmd.Parameters.AddWithValue("@VacancyID", VacancyId);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Department_No", cmbDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Designation_No", cmbDesignation.Text.ToString());
                cmd.Parameters.AddWithValue("@No_of_Vacn", Convert.ToInt32(txtAvailableVacancies.Text.ToString()));
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.ToString());

                


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Vacancy Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Vacancy Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

        private void dgvVacancyDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVacancyDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                VacancyId = dgvVacancyDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbDepartment.Text = dgvVacancyDetails.SelectedRows[0].Cells[1].Value.ToString();
                cmbDesignation.Text = dgvVacancyDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtDescription.Text = dgvVacancyDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtAvailableVacancies.Text = dgvVacancyDetails.SelectedRows[0].Cells[4].Value.ToString();
                
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
            dgvVacancyDetails.DataSource = null;
            btnDelete.Enabled = false;
        }



        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Manager Level")
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
                cmd.CommandText = "sp_Delete_VacancyData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Vacancy_ID", VacancyId);

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

             if (!checkChange)
                 OpenDialogBox();
             else
                 if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                     OpenDialogBox();



             btnExit.Enabled = true;
             checkSave = 0;
             
        }


        private void OpenDialogBox()
        {



            dlgSearch dlgBox = new dlgSearch("Search Vacancy Details", "Department_Name", "Designation_Name", "Unused" ,"sp_Search_VacancyData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvVacancyDetails.Enabled = true;
                rs = dlgBox.rs;
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt.Load(rs);
                    dgvVacancyDetails.DataSource = dt;
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
        
        #region Validate Methods

        private Boolean ValidateMethod()
        {

            int testConvert;
            bool x1 = String.IsNullOrEmpty(cmbDepartment.Text.ToString());
            bool x2 = String.IsNullOrEmpty(cmbDesignation.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtAvailableVacancies.Text.ToString());


            if (!x1 && !x2)
            {
                if (int.TryParse(txtAvailableVacancies.Text.ToString(), out testConvert))
                {
                    return true;
                }

                else
                {
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

        #region Text in Controls Changes

        private void controlValue_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }

        
        #endregion

        #region Selection Change

        private void cmbSelectionChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbDepartment.Text.Equals("") && !cmbDesignation.Text.Equals(""))
            {
                

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Get_Available_Vacancies";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Designation", cmbDesignation.Text.ToString());
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text .ToString());


                rs = cmd.ExecuteReader();

                while (rs.Read())
                    txtAvailableVacancies.Text = rs[0].ToString();
                rs.Close();


            }
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
