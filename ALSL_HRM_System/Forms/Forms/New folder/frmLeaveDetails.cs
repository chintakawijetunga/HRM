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
    public partial class frmLeaveDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Costructors

        public frmLeaveDetails()
        {
            InitializeComponent();
            DBConnectionMethod();

        }

        #endregion

        #region Form Load

        private void frmLeaveDetails_Load(object sender, EventArgs e)
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
            dgvLeaveDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_EmployeeLeaveData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvLeaveDetails.DataSource = dt;
            rs.Close();

        }

        #endregion

        #region Add New Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
            FillComboBoxes();
        }


        private void AddNew()
        {
            DisableAllControls(this, true);
            txtLeaveID.Enabled = false;
            
            ClearAllFields(this);
            String newLeaveId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtLeaveID.Text = newLeaveId;
            checkSave = 1;
        }

        #endregion
        
        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmLeaveDetails_Load(sender, e);
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

        #region DataGrid to TextBoxes

        private void dgvLeaveDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLeaveDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtLeaveID.Text = dgvLeaveDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeID.Text=dgvLeaveDetails.SelectedRows[0].Cells[1].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(dgvLeaveDetails.SelectedRows[0].Cells[2].Value.ToString());
                dtpEndDate.Value = Convert.ToDateTime(dgvLeaveDetails.SelectedRows[0].Cells[3].Value.ToString());
                if (dgvLeaveDetails.SelectedRows[0].Cells[4].Value.ToString().Equals("Confirmed"))
                {
                    cbLeaveConfirmed.Checked = true;
                }
                else
                {
                    cbLeaveConfirmed.Checked = false;
                }

                cmbLeaveType.Text=dgvLeaveDetails.SelectedRows[0].Cells[7].Value.ToString();
                txtNumberofLeaves.Text = dgvLeaveDetails.SelectedRows[0].Cells[8].Value.ToString();
                txtEmployeeName.Text = dgvLeaveDetails.SelectedRows[0].Cells[9].Value.ToString();
            }

            txtLeaveID.Enabled = false;
            FillComboBoxes();
        }

        #endregion
        
        #region Get Methods

        private string GetNextID()
        {
            String OldLeaveId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_EmployeeLeaveData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldLeaveId = rs[0].ToString();
            rs.Close();
            return OldLeaveId;
        }


        #endregion
        
        #region Save Data

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
            String LeaveCondition = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_BankData";
                }
                else
                {
                    cmd.CommandText = "Update_BankData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                if (cbLeaveConfirmed.Checked)
                {
                    LeaveCondition = "Confirmed";
                }
                else
                {
                    LeaveCondition = "Not Confirmed";
                }

                cmd.Parameters.AddWithValue("@Leave_ID", txtLeaveID.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_ID", (cmbEmployeeID.SelectedItem).ToString());
                cmd.Parameters.AddWithValue("@Leave_St_Date", dtpStartDate.Value.ToString("dd-mm-yyyy"));
                cmd.Parameters.AddWithValue("@Leave_End_Date", dtpEndDate.Value.ToString("dd-mm-yyyy"));
                cmd.Parameters.AddWithValue("@No_Of_Leaves", txtNumberofLeaves.Text.ToString());
                cmd.Parameters.AddWithValue("@Condition", LeaveCondition);
                cmd.Parameters.AddWithValue("@Leave_Type", (cmbLeaveType.SelectedItem).ToString());
                cmd.Parameters.AddWithValue("@Employee_Name", txtEmployeeName.Text.ToString());


                


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Bank Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Bank Details Updated...");
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion

        #region Fill ComboBoxes

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

            cmd.CommandText = "sp_Select_LeaveTypeData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                cmbLeaveType.Items.Add(rs[0]);
            }

            rs.Close();
        }


        #endregion
        
        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(txtLeaveID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtEmployeeName.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtNumberofLeaves.Text.ToString());
            bool x4 = String.IsNullOrEmpty((cmbEmployeeID.SelectedItem).ToString());
            bool x5 = String.IsNullOrEmpty((cmbLeaveType.SelectedItem).ToString());
            bool x6 = String.IsNullOrEmpty(dtpStartDate.Value.ToString("dd-mm-yyyy"));
            bool x7 = String.IsNullOrEmpty(dtpEndDate.Value.ToString("dd-mm-yyyy"));
            

            if (!x1 && !x2 && !x3 && !x4 && !x5 && !x6 && !x7)

                return true;

            else

                return false;

        }
        #endregion

        #region Delete Methods

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
                cmd.CommandText = "sp_Delete_EmployeeLeaveData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Leave_ID", txtLeaveID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Leave Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }

        #endregion

        #region DialogBox Method

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }


         private void OpenDialogBox()
        {



            DialogBox1 form2 = new DialogBox1("Search Employee Leave Details", "Leave_ID", "Employee_ID", "Leave_Type", "sp_Search_EmployeeLeaveData");
            
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    
                    dgvLeaveDetails.Enabled = true;
                    rs = form2.rs;
                    DataTable dt = new DataTable();
                    if (rs == null)
                    {
                        //MessageBox.Show("");
                    }
                    else
                    {
                        dt.Load(rs);
                        dgvLeaveDetails.DataSource = dt;
                        
                    }
                    rs.Close();
                }
            

        }


        #endregion

        #region Exit Methods

         private void btnExit_Click(object sender, EventArgs e)
         {
             if (MessageBox.Show("Are You Sure You Want to Exit?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 ExitForm();
             }
         }

        private void ExitForm()
        {
            this.Close();
        }

        #endregion

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Employee_ID=(cmbEmployeeID.SelectedItem).ToString();
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

        

       

    }
}
