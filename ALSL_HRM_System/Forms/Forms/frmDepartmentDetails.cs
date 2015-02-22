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
using ALSL_HRM_System.Forms.Forms;


namespace ALSL_HRM_System.Forms
{
    public partial class frmDepartmentDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
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

        public frmDepartmentDetails(frmMDIMain form)
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
                    AddNew();
                else
                    if (MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        AddNew();
            }

        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtDepartmentID.Enabled = false;
            ClearAllFields(this);
            String newDepartmentID = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
           
            txtDepartmentID.Text = newDepartmentID;
            checkSave = 1;
            btnDelete.Enabled = false;
        }

        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldBankId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_DepartmentData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldBankId = rs[0].ToString();
            rs.Close();
            return OldBankId;
        }


        #endregion

        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(!checkChange)
            ClearAllFields(this);
            else
                if(MessageBox.Show(Properties.Resources.ContentChanged, Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
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
            dgvDepartmentDetails.DataSource=null;
            btnDelete.Enabled = false;
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
                cmd.CommandText = "sp_Delete_DepartmentData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Department_no", txtDepartmentID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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



            dlgSearch dlgBox = new dlgSearch("Search Department Details", "Department_ID", "Department_Name", "Unused", "sp_Search_DepartmentData");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvDepartmentDetails.Enabled = true;
                rs = dlgBox.rs;
                if (!rs.HasRows) 
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    DataTable dt = new DataTable();
                    dt.Load(rs);
                    dgvDepartmentDetails.DataSource = dt;
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

        #region Form Load

        private void frmDepartmentDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnSearch);
            EnableButtons(btnExit);
            dgvDepartmentDetails.Enabled = true;
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

            dgvDepartmentDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_DepartmentData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvDepartmentDetails.DataSource = dt;
            rs.Close();
            btnClear.Enabled = true;

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
                    cmd.CommandText = "sp_Insert_DepartmentData";
                }
                else
                {
                    cmd.CommandText = "Update_DepartmentData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Department_no", txtDepartmentID.Text.ToString());
                cmd.Parameters.AddWithValue("@Dep_Name", txtDepartment.Text.ToString());
                cmd.Parameters.AddWithValue("@Telephone_no", txtTelephoneNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Fax_no", txtFaxNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.ToString());
                cmd.Parameters.AddWithValue("@Dep_description", txtDescription.Text.ToString());
                
               
                cmd.ExecuteNonQuery();

                
                if (checkSave == 1)
                {
                    MessageBox.Show("Department Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Department Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopulateData();

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
            check = false;
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

            btnDelete.Enabled = true;
            check = true;
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

        #region TextBoxes Change Events

        private void txtChanges_TextChanged(object sender, EventArgs e)
        {

            if (check)
            {
                checkChange = true;
                btnSave.Enabled = true;
            }
            
        }

        


     
        

        #endregion

        #region Validate Methods

        private Boolean ValidateMethod()
        {

            bool x1 = String.IsNullOrEmpty(txtDepartment.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtEmail.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtFaxNo.Text.ToString());
            bool x4 = String.IsNullOrEmpty(txtTelephoneNo.Text.ToString());


            if (!x1 && !x2 && !x3 && !x4)

                if (EmailValidate())
                {
                    if (PhoneValidate(txtFaxNo.Text) && PhoneValidate(txtTelephoneNo.Text))

                        return true;
                    else
                    {
                        MessageBox.Show("Contact Numbers are not in the correct format.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Email Address is not in the correct format.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }




            else
                MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

        }

        private bool PhoneValidate(String Number)
        {
            if (Number.Length < 7 || Number.Length > 12)
                return false;
            else
                return Regex.IsMatch(Number, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", RegexOptions.IgnoreCase);
        }

        private bool EmailValidate()
        {
            return Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        #endregion


    }
}
