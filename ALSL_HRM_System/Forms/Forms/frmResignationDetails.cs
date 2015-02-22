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
    public partial class frmResignationDetails : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        bool checkChange = false;
        bool check = false;
        frmMDIMain form;

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

        #region Constructors
        public frmResignationDetails(frmMDIMain form)
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
        private void frmResignationDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
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
            dgvResignationDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_EmployeeResignationData", obj.sqlConnection); //use the correct view
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
                    txtEmployeeName.Text = "";
                    txtRegReason.Text = "";
                }
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        AddNew();
                        FillComboBoxes();
                        txtEmployeeName.Text = "";
                        txtRegReason.Text = "";
                    }
            }
        }

        private void FillComboBoxes()
        {
            cmbEmployeeID.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_EmployeeResignationData2";
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
                        cmbEmployeeID.Text = "";
                        cmbEmployeeID.Items.Clear();

                    }
            }
        }
        


        private void SaveData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;


                cmd.CommandText = "Update_EmployeeResignationData";
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Employee_No", cmbEmployeeID.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Reg_Date", dtpRegDate.Value.ToString("dd-MMM-yyyy"));
                cmd.Parameters.AddWithValue("@Reg_Reason", txtRegReason.Text.ToString());
                

                cmd.ExecuteNonQuery();


                MessageBox.Show("Resignation Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    

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
            check = false;
            if (dgvResignationDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                cmbEmployeeID.Text = dgvResignationDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dgvResignationDetails.SelectedRows[0].Cells[1].Value.ToString();
                dtpRegDate.Text = dgvResignationDetails.SelectedRows[0].Cells[4].Value.ToString();
                txtRegReason.Text = dgvResignationDetails.SelectedRows[0].Cells[5].Value.ToString();
                
            }
            cmbEmployeeID.Enabled = false;
            btnDelete.Enabled = true;
            check = true;

        }
        

        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!checkChange)
                    ClearAllFields(this);
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        ClearAllFields(this);
                checkChange = false;
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
            dgvResignationDetails.DataSource = null;
            btnDelete.Enabled = false;
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
            
            dlgSearch dlgBox = new dlgSearch("Search Employee Resignation Details", "Employee_ID", "Department_Name", "Designation_Name", "sp_Search_EmployeeResignationData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvResignationDetails.Enabled = true;
                rs = dlgBox.rs;
                DataTable dt = new DataTable();
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    dt.Load(rs);
                    dgvResignationDetails.DataSource = dt;
                    rs.Close();
                }
            }


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
            
            bool x1 = String.IsNullOrEmpty(cmbEmployeeID.Text.ToString());
            bool x2 = String.IsNullOrEmpty(dtpRegDate.Text.ToString());
            
          
            if (!x1 && !x2)

                return true;

            else
            {
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion

        #region TextBox Change


        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
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
