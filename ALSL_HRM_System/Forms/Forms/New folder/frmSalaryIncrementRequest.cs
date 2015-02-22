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
    public partial class frmSalaryIncrementRequest : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        String check = "false";

        #endregion

        #region Constructors
        public frmSalaryIncrementRequest()
        {
            InitializeComponent();
            DBConnectionMethod(); 
        }

        #endregion

        #region Form Load

        private void frmSalaryIncrementRequest_Load(object sender, EventArgs e)
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

        #region Populate Method
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            dgvSalaryIncReq.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_BankData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvSalaryIncReq.DataSource = dt;
            rs.Close();

        }

        #endregion

        #region Add New Method
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtSalaryIncReqNo.Enabled = false;
            
            ClearAllFields(this);
            String newBankId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtSalaryIncReqNo.Text = newBankId;
            checkSave = 1;
        }

       
        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldSalaryIncReqId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_SalaryIncReqData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldSalaryIncReqId = rs[0].ToString();
            rs.Close();
            return OldSalaryIncReqId;
        }


        #endregion

        #region Save Method
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
                    cmd.CommandText = "sp_Insert_SalaryIncReqData";
                }
                else
                {
                    cmd.CommandText = "Update_SalaryIncReqData";
                }

                cmd.CommandType = CommandType.StoredProcedure;
                /*Put the correct DB parameters*/
                cmd.Parameters.AddWithValue("@", txtSalaryIncReqNo.Text.ToString());
                cmd.Parameters.AddWithValue("@", cmbEmployeeID.Text.ToString());
                cmd.Parameters.AddWithValue("@", txtReqValue.Text.ToString());
                cmd.Parameters.AddWithValue("@", dtpRequestedDate.Value.ToString("dd-mm-yyyy"));

                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Salary Increment Request Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Salary Increment Request Details Updated...");
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }



        #endregion

        #region Datagrid to Textboxes

        private void dgvSalaryIncReq_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalaryIncReq.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtSalaryIncReqNo.Text = dgvSalaryIncReq.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeID.Text = dgvSalaryIncReq.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvSalaryIncReq.SelectedRows[0].Cells[2].Value.ToString();
                txtReqValue.Text = dgvSalaryIncReq.SelectedRows[0].Cells[3].Value.ToString();
                  }
            txtSalaryIncReqNo.Enabled = false;
            check = "false";
        }


#endregion

        #region Clear Fields Method
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmSalaryIncrementRequest_Load(sender, e);
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
        
        #region DialogBoxes and Search

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }



        private void OpenDialogBox()
        {

            DialogBox1 form2 = new DialogBox1("Search Salary Increment Request", "Bank_ID", "Bank_Name", "Branch_No", "sp_Search_SalaryIncReqData"); //make the relavent column name changes

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvSalaryIncReq.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs[0] == DBNull.Value)
                {
                    MessageBox.Show("No Records Found", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dt.Load(rs);
                    dgvSalaryIncReq.DataSource = dt;

                }
                rs.Close();
            }


        }


        #endregion
        
        #region Delete Method


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
                cmd.CommandText = "sp_Delete_SalaryIncReqData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_ID", txtSalaryIncReqNo.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Increment Request Details Deleted...", "");
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
            
            bool x1 = String.IsNullOrEmpty(txtSalaryIncReqNo.Text.ToString());
            bool x2 = String.IsNullOrEmpty(cmbEmployeeID.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtEmployeeName.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtReqValue.Text.ToString());

            if (!x1 && !x2 && !x3 && !x4)

                return true;

            else

                return false;

        }
        #endregion

        #region Controls value change

        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            check = "true";
        }

        #endregion

        #region ComboBox Value Change
        private void cmbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
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
