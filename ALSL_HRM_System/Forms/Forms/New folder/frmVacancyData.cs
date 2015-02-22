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

namespace ALSL_HRM_System.Forms
{
    public partial class frmVacancyData : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        String check = "false";
        String newVacancyId;
        String VacancyId;
        #endregion

        #region Constructors

        public frmVacancyData()
        {
            InitializeComponent();
            DBConnectionMethod();
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
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
        }


        #endregion

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
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

        }


        #endregion
        
        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
            FillComboBox();
        }

        private void FillComboBox()
        {

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
            if (MessageBox.Show("Are You Sure You Want to Save?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ValidateMethod())
                {
                    SaveData();
                }
                else
                {
                    MessageBox.Show("Please Fill the Mandotory Fields", "Fill The Fields", MessageBoxButtons.OK);
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
                    cmd.CommandText = "sp_Insert_VacancyData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_VacancyData"; //haven't still deployed
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VacancyID", newVacancyId);
                cmd.Parameters.AddWithValue("@Department_No", cmbDepartment.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Designation_No", cmbDesignation.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@No_of_Vacn", Convert.ToInt32(txtAvailableVacancies.Text.ToString()));
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.ToString());

                


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Vacancy Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Vacancy Details Updated...");
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
            
            check = "false";
        }


        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmVacancyData_Load(sender, e);
            }
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

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Delete?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteData();
                PopulateData();
                ClearAllFields(this);
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
                MessageBox.Show("Vacancy Details Deleted...");
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
            OpenDialogBox();
        }


        private void OpenDialogBox()
        {



            DialogBox1 form2 = new DialogBox1("Search Vacancy Details", "Vacancy_ID", "Department_No", "Designation_No", "sp_Search_VacancyData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvVacancyDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs == null)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    dt.Load(rs);
                    dgvVacancyDetails.DataSource = dt;

                }
                rs.Close();
            }


        }

        #endregion
        
        #region Exit Method


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Exit?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExitForm();
            }
        }

        
        private void ExitForm()
        {
            if (check == "true")
            {
                if (MessageBox.Show("You have made changes. Press Yes to save/update", "Warning!!!", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    SaveData();
                    this.Close();
                }
                else
                {
                    
                    this.Close();
                }
            }
            else
            {
                
                this.Close();
            }



            //this.Close();
        }

        #endregion
        
        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(cmbDepartment.SelectedItem.ToString());
            bool x2 = String.IsNullOrEmpty(cmbDesignation.SelectedItem.ToString());
            //bool x3 = String.IsNullOrEmpty(txtDescription.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtAvailableVacancies.Text.ToString());
          

            if (!x1 && !x2  && !x4)

                return true;

            else

                return false;

        }
        #endregion

        #region Text in Controls Changes

        private void controlValue_TextChanged(object sender, EventArgs e)
        {
            check = "true";
        }

        
        #endregion

        
        


    }
}
