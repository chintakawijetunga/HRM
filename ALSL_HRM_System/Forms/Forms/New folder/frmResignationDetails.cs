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
using ALSL_HRM_System.DialogBoxes;
using System.Text.RegularExpressions;

namespace ALSL_HRM_System.Forms
{
    public partial class frmResignationDetails : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        String check = "false";

        #endregion

        #region Constructors
        public frmResignationDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region Form Load
        private void frmResignationDetails_Load(object sender, EventArgs e)
        {
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

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
        }


        private void PopulateData()
        {
            dgvResignationDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_BankData", obj.sqlConnection); //use the correct view
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvResignationDetails.DataSource = dt;
            rs.Close();

        }


        #endregion

        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_PermanentEmployeeData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbEmployeeID.Items.Add(rs[0]);
            }

            rs.Close();


        }

        private void AddNew()
        {
            DisableAllControls(this, true);

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
            /*
             Change the SP and the Textbox names.
             
             */


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;


                cmd.CommandText = "Update_PermanentEmployee_ResignationData";
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Employee_ID", cmbEmployeeID.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Reg_Date", dtpRegDate.Value.ToString("dd-MMM-yyyy"));
                cmd.Parameters.AddWithValue("@Reg_Reason", txtRegReason.Text.ToString());
                

                cmd.ExecuteNonQuery();


                MessageBox.Show("Resignation Details Added...");
                    

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }



        #endregion

        #region DataGrid to TextBoxes

        private void dgvResignationDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResignationDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                cmbEmployeeID.Text = dgvResignationDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dgvResignationDetails.SelectedRows[0].Cells[1].Value.ToString();
                dtpRegDate.Text = dgvResignationDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtRegReason.Text = dgvResignationDetails.SelectedRows[0].Cells[3].Value.ToString();
                
            }
            cmbEmployeeID.Enabled = false;
            check = "false";

        }
        

        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmResignationDetails_Load(sender, e);
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

        #region DialogBox and Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }

        private void OpenDialogBox()
        {
            //make relavent changes


            DialogBox1 form2 = new DialogBox1("Search Employee Resignation Details", "Employee_ID", "Department_Name", "Designation_No", "sp_Search_PermanentEmployee_ResignationData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvResignationDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs == null)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    dt.Load(rs);
                    dgvResignationDetails.DataSource = dt;

                }
                rs.Close();
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
                cmd.CommandText = "sp_Delete_PermanentEmployee_ResignationDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Employee_ID", cmbEmployeeID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Resignation Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion

        #region Exit Method

        private void btnExit_Click_1(object sender, EventArgs e)
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
            
            bool x1 = String.IsNullOrEmpty(cmbEmployeeID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(dtpRegDate.Text.ToString());
            
          
            if (!x1 && !x2)

                return true;

            else

                return false;

        }
        #endregion

        #region TextBox Change


        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            check = "true";
        }
        #endregion

        #region Combo Box value Change

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Employee_ID = (cmbEmployeeID.SelectedItem).ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_PermanentEmployeeData";
            cmd.Parameters.AddWithValue("@Employee_No", (cmbEmployeeID.SelectedItem).ToString());
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtEmployeeName.Text = rs[1].ToString() + " " + rs[2].ToString() + " " + rs[3].ToString();
            }

            rs.Close();
        }

        #endregion
    }
}
