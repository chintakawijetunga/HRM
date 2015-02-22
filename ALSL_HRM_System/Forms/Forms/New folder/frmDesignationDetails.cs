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
    public partial class frmDesignationDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmDesignationDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
            
        }

        #endregion

        #region Form Load

        private void frmDesignationDetails_Load(object sender, EventArgs e)
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

        #region Populate Method

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData(1);
        }

        private String PopulateData(int check)
        {
            dgvDesignationDetails.Enabled = true;
            String OldDesignationID = null;
            SqlCommand command = new SqlCommand("sp_Select_DesignationData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldDesignationID = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvDesignationDetails.DataSource = dt;
            }
            rs.Close();
            return OldDesignationID;
        }
        #endregion

        #region Add New

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }
        private void AddNew()
        {
            DisableAllControls(this, true);
            txtDesignationID.Enabled = false;
            ClearAllFields(this);
            String newDesignationID = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtDesignationID.Text = newDesignationID;
            checkSave = 1;
        }

        #endregion

        #region Save Method

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
                    cmd.CommandText = "sp_Insert_DesignationData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_DesignationData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Designation_No", txtDesignationID.Text.ToString());
                cmd.Parameters.AddWithValue("@Desg_Description", txtDesignationDescription.Text.ToString());
                cmd.Parameters.AddWithValue("@Basic_Salary", Convert.ToInt32(txtBasicSalary.Text.ToString()));
                cmd.Parameters.AddWithValue("@OT_Rate", Convert.ToInt32(txtOTRate.Text.ToString()));
                cmd.Parameters.AddWithValue("@Max_Loan_Value", Convert.ToInt32(txtMaxLoanValue.Text.ToString()));
                cmd.Parameters.AddWithValue("@Active", Convert.ToInt32(1));

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Designation Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Designation Details Updated...");
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

        private void dgvDesignationDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDesignationDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtDesignationID.Text = dgvDesignationDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtDesignationDescription.Text = dgvDesignationDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtBasicSalary.Text = dgvDesignationDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtOTRate.Text = dgvDesignationDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtMaxLoanValue.Text = dgvDesignationDetails.SelectedRows[0].Cells[4].Value.ToString();
               
            }
            txtDesignationID.Enabled = false;
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
            DialogBox1 form2 = new DialogBox1("Search Designation Details", "Designation_ID", "Designaion_Desc", "", "sp_Search_DesignationData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvDesignationDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                dt.Load(rs);
                dgvDesignationDetails.DataSource = dt;
                rs.Close();
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
                cmd.CommandText = "sp_Delete_DesignationData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Designation_No", txtDesignationID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Designation Details Deleted...");
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
