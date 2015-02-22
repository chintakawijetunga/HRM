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
    public partial class frmDepartmentDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmDepartmentDetails()
        {
            InitializeComponent();
            DBConnectionMethod();

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
            txtDepartmentID.Enabled = false;
            btnSearch.Enabled = false;
            ClearAllFields(this);
            String newDepartmentID = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtDepartmentID.Text = newDepartmentID;
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
                cmd.CommandText = "sp_Delete_DepartmentData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Department_no", txtDepartmentID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Department Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion

        #region DBConnection Class Calling Method

         private void DBConnectionMethod()
         {

             obj = new ALSL_HRM_System.PublicClasses.DBConnection();
             obj.DBConnectionMethod();

         }

         #endregion

        #region DialogBox and Search
         
        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }

        private void OpenDialogBox()
        {



            //DialogBox1 form2 = new DialogBox1("Search Department Details", "Department_ID", "Department", "Telephone_No", "sp_Search_DepartmentData");
            
            //    if (form2.ShowDialog() == DialogResult.OK)
            //    {

            //        dgvDepartmentDetails.Enabled = true;
            //        rs = form2.rs;
            //        DataTable dt = new DataTable();
            //        dt.Load(rs);
            //        dgvDepartmentDetails.DataSource = dt;
            //        rs.Close();
            //    }
            

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

        #region Form Load

        private void frmDepartmentDetails_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);

            
        }

        #endregion

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData(1);
        }
          private String PopulateData(int check)
        {
            dgvDepartmentDetails.Enabled = true;
            String OldDepartmentId = null;
            SqlCommand command = new SqlCommand("sp_Select_DepartmentData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs=command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldDepartmentId = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvDepartmentDetails.DataSource = dt;
            }
            rs.Close();
            return OldDepartmentId;
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
                    cmd.CommandText = "sp_Insert_DepartmentData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_DepartmentData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Department_no", txtDepartmentID.Text.ToString());
                cmd.Parameters.AddWithValue("@Dep_Name", txtDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Telephone_no", Convert.ToInt32(txtTelephoneNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Fax_no", Convert.ToInt32(txtFaxNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@Dep_description", txtDescription.Text.ToString());
                
               
                cmd.ExecuteNonQuery();

                
                if (checkSave == 1)
                {
                    MessageBox.Show("Department Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Department Details Updated...");
                }

                PopulateData(1);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." +e.ToString());
            }

        }



        #endregion

        #region DataGrid to TextBoxes

        private void dgvDepartmentDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartmentDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtDepartmentID.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[0].Value.ToString();
                txtDepartment.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[1].Value.ToString();
                txtTelephoneNo.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[2].Value.ToString();
                txtFaxNo.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[4].Value.ToString();
                txtDescription.Text = dgvDepartmentDetails‏.SelectedRows[0].Cells[5].Value.ToString();
            }
            txtDepartmentID.Enabled = false;
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

       
      
    }
}
