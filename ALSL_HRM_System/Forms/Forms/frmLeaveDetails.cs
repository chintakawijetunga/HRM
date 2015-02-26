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
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class frmLeaveDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        frmMDIMain form;
        #endregion
//test github
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

        #region Costructors

        public frmLeaveDetails(frmMDIMain form)
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

        private void frmLeaveDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
            dgvLeaveDetails.Enabled = true;
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
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                PopulateData();
                check = false;
                btnDelete.Enabled = false;
            }
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
            btnClear.Enabled = true;
        }

        #endregion

        #region Add New Method

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
                    FillComboBoxes();
                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillComboBoxes();
                    }
            }
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
            btnDelete.Enabled = false;
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
            dgvLeaveDetails.DataSource = null;
            cmbEmployeeID.Text ="";
            cmbLeaveType.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvLeaveDetails_SelectionChanged(object sender, EventArgs e)
        {
            check = false;
            if (dgvLeaveDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtLeaveID.Text = dgvLeaveDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeID.Text=dgvLeaveDetails.SelectedRows[0].Cells[1].Value.ToString();
                dtpStartDate.Value = Convert.ToDateTime(dgvLeaveDetails.SelectedRows[0].Cells[3].Value.ToString());
                dtpEndDate.Value = Convert.ToDateTime(dgvLeaveDetails.SelectedRows[0].Cells[4].Value.ToString());
                if (dgvLeaveDetails.SelectedRows[0].Cells[5].Value.ToString().Equals("1"))
                {
                    cbLeaveConfirmed.Checked = true;
                }
                else
                {
                    cbLeaveConfirmed.Checked = false;
                }

                cmbLeaveType.Text=dgvLeaveDetails.SelectedRows[0].Cells[6].Value.ToString();
                txtNumberofLeaves.Text = dgvLeaveDetails.SelectedRows[0].Cells[7].Value.ToString();
                txtEmployeeName.Text = dgvLeaveDetails.SelectedRows[0].Cells[2].Value.ToString();
            }

            txtLeaveID.Enabled = false;
            FillComboBoxes();
            check = true;
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
            String LeaveCondition = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_EmployeeLeaveData";
                }
                else
                {
                    cmd.CommandText = "Update_EmployeeLeaveData";
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
                String x=dtpStartDate.Value.ToString("yyyy/MM/dd");
                String y=dtpEndDate.Value.ToString("yyyy/MM/dd");
                cmd.Parameters.AddWithValue("@Leave_ID", txtLeaveID.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_ID", (cmbEmployeeID.Text).ToString());
                cmd.Parameters.AddWithValue("@Leave_St_Date", x);
                cmd.Parameters.AddWithValue("@Leave_End_Date", y);
                cmd.Parameters.AddWithValue("@Condition", LeaveCondition);
                cmd.Parameters.AddWithValue("@Leave_Type", (cmbLeaveType.Text).ToString());


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Leave Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Leave Details Update.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
            cmbEmployeeID.Items.Clear();
            cmbLeaveType.Items.Clear();
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
                cmbLeaveType.Items.Add(rs[1]);
            }

            rs.Close();
        }


        #endregion
        
        #region Validate Methods

        private Boolean ValidateMethod()
        {
           
            bool x1 = String.IsNullOrEmpty(txtLeaveID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtEmployeeName.Text.ToString());
            bool x4 = String.IsNullOrEmpty((cmbEmployeeID.Text).ToString());
            bool x5 = String.IsNullOrEmpty((cmbLeaveType.Text).ToString());
            bool x6 = String.IsNullOrEmpty(dtpStartDate.Value.ToString("dd-mm-yyyy"));
            bool x7 = String.IsNullOrEmpty(dtpEndDate.Value.ToString("dd-mm-yyyy"));
            

            if (!x1 && !x2  && !x4 && !x5 && !x6 && !x7)


                if (dtpStartDate.Value > dtpEndDate.Value)
                {
                    MessageBox.Show("Start date should be less than the end date.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                else
                {
                    return true;
                }

            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion

        #region Delete Methods

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
                cmd.CommandText = "sp_Delete_EmployeeLeaveData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Leave_ID", txtLeaveID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
           
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



            dlgSearch dlgBox = new dlgSearch("Search Employee Leave Details", "Leave_ID", "Employee_ID", "Leave_Type", "sp_Search_EmployeeLeaveData");
            
                if (dlgBox.ShowDialog() == DialogResult.OK)
                {
                    
                    dgvLeaveDetails.Enabled = true;
                    rs = dlgBox.rs;
                    DataTable dt = new DataTable();
                    if (!rs.HasRows)
                    {
                        MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dt.Load(rs);
                        dgvLeaveDetails.DataSource = dt;
                        rs.Close();
                    }
                }
            

        }


        #endregion

        #region Exit Methods

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

        #region ComboBox Index Changed Method

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }

        #endregion

        #region TextBoxes Change Events

        private void txtTextChanged_TextChanged(object sender, EventArgs e)
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
