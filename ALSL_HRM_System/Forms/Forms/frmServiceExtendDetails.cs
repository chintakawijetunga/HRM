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
    public partial class frmServiceExtendDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        String isExtended = null;
        frmMDIMain form;
        #endregion

        #region Constructors
        public frmServiceExtendDetails(frmMDIMain form)
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

        #region Populate Method
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
            dgvServiceExtendDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_ServiceExtendData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvServiceExtendDetails.DataSource = dt;
            rs.Close();

        }


        #endregion

        #region Save Method
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rbtYesExtend.Checked)
                    isExtended = "1";
                else if (rbtNoExtend.Checked)
                    isExtended = "0";
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
                    cmd.CommandText = "sp_Insert_ServiceExtendData";
                }
                else
                {
                    cmd.CommandText = "Update_ServiceExtendData";
                }

                cmd.CommandType = CommandType.StoredProcedure;




                cmd.Parameters.AddWithValue("@Extend_ID", txtServiceExtendID.Text.ToString());
                cmd.Parameters.AddWithValue("@Extend_Req_ID", cmbExtendReqID.Text.ToString());
                cmd.Parameters.AddWithValue("@Is_Extended", isExtended);
                cmd.Parameters.AddWithValue("@Extended_From", dtpExtendFrom.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Extended_To", dtpExtendTo.Value.ToString("yyyy-MM-dd"));
                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Service Extend Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Service Extend Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }




        #endregion
           
        #region Delete Method
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
                cmd.CommandText = "sp_Delete_ServiceExtendData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Extend_ID ", txtServiceExtendID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }


        #endregion
        
        #region Clear Method
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
            dgvServiceExtendDetails.DataSource = null;
            btnDelete.Enabled = false;
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
                    FillConboBoxes();
                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillConboBoxes();
                    }
            }

        }

        

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtServiceExtendID.Enabled = false;

            ClearAllFields(this);
            String newServiceExtendID = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtServiceExtendID.Text = newServiceExtendID;
            checkSave = 1;
        }


        #endregion
        
        #region Fill ComboBox

        private void FillConboBoxes()
        {
            
            cmbExtendReqID.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_ServiceExtendRequestData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbExtendReqID.Items.Add(rs[0].ToString());
                
            }

            rs.Close();
        }

        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldServiceExtendID = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_ServiceExtendData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldServiceExtendID = rs[0].ToString();
            rs.Close();
            return OldServiceExtendID;
        }


        #endregion
        
        #region Search and DialogBox Method
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



            dlgSearch dlgBox = new dlgSearch("Search Service Extend Details", "Service_Extend_No", "Service_Extend_Request_No", "Unused", "sp_Search_ServiceExtendData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvServiceExtendDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvServiceExtendDetails.DataSource = dt;
                    rs.Close();
                }
            }


        }


        #endregion
        
        #region Form Load Method
        private void frmServiceExtendDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);

            
        }




        #endregion
        
        #region TextBox Change Method
        private void txtTextChange_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
        }



        #endregion
        
        #region Datagrid to TextBoxes Method
        private void dgvServiceExtendDetails_SelectionChanged(object sender, EventArgs e)
        {
            check = false;
            if (dgvServiceExtendDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtServiceExtendID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbExtendReqID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[2].Value.ToString();
                //txtEmployeeName.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[3].Value.ToString();
                dtpExtendFrom.Value=Convert.ToDateTime(dgvServiceExtendDetails.SelectedRows[0].Cells[3].Value.ToString());
                dtpExtendTo.Value = Convert.ToDateTime(dgvServiceExtendDetails.SelectedRows[0].Cells[4].Value.ToString());
                
               isExtended =dgvServiceExtendDetails.SelectedRows[0].Cells[5].Value.ToString();
                if(isExtended.Equals("1"))
                    rbtYesExtend.Checked=true;
                else
                    rbtNoExtend.Checked = true;

            }
            txtServiceExtendID.Enabled = false;
            btnDelete.Enabled = true;
            check = true;
        }



        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(txtServiceExtendID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(cmbExtendReqID.Text.ToString());
            bool x3 = String.IsNullOrEmpty(isExtended);
            bool x4 = String.IsNullOrEmpty(dtpExtendFrom.Text.ToString());
            bool x5 = String.IsNullOrEmpty(dtpExtendTo.Text.ToString());

            if (!x1 && !x2 && !x3 && !x4 && !x5)

                if (Convert.ToDateTime(dtpExtendFrom.Value.ToString("yyyy-MM-dd")) > Convert.ToDateTime(dtpExtendTo.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Start date should be less than End date.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbExtendReqID_TextChanged(object sender, EventArgs e)
        {

            GetEmpDetailsMethod();
        }

        private void GetEmpDetailsMethod()
        {
            String x = (cmbExtendReqID.Text).ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Search_ServiceExtendRequestData";
            cmd.Parameters.AddWithValue("@Extend_Req_ID", (cmbExtendReqID.Text).ToString());
            cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
            cmd.Parameters.AddWithValue("@Unused", DBNull.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtEmployeeID.Text = rs[1].ToString();
                txtEmployeeName.Text = rs[2].ToString();
            }
        }

        private void cmbExtendReqID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmpDetailsMethod();
        }

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
