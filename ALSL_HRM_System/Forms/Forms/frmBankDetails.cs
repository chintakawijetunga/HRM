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
using ALSL_HRM_System.Forms;
using ALSL_HRM_System.DialogBoxes;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class frmBankDetails : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        bool checkChange = false;
        bool check = false;
        frmMDIMain form;

        #endregion

        #region Constructors

        public frmBankDetails(frmMDIMain form)
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

        private void frmBankDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            //MdiParent = form;
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
            dgvBankDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_BankData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs=command.ExecuteReader();
            dt.Load(rs);
            dgvBankDetails.DataSource = dt;
            rs.Close();
            
        }


#endregion

        #region Shortcut Keys

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F2))
            {
                if(btnPopulate.Enabled)
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
            txtBankID.Enabled = false;
            
            ClearAllFields(this);
            String newBankId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtBankID.Text = newBankId;
            checkSave = 1;
            btnDelete.Enabled = false;
        }

       
        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldBankId = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_BankData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            
            rs = command.ExecuteReader();
           
            while(rs.Read())
            OldBankId = rs[0].ToString();
            rs.Close();
            return OldBankId;
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
                    cmd.CommandText = "sp_Insert_BankData";
                }
                else
                {
                    cmd.CommandText = "Update_BankData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Bank_ID", txtBankID.Text.ToString());
                cmd.Parameters.AddWithValue("@Bank_Name", txtBank.Text.ToString());
                cmd.Parameters.AddWithValue("@Branch_No", txtBankBranchNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Branch_Name", txtBankBranch.Text.ToString());
                cmd.Parameters.AddWithValue("@Address1", txtAddress1.Text.ToString());
                cmd.Parameters.AddWithValue("@Address2", txtAddress2.Text.ToString());
                cmd.Parameters.AddWithValue("@Address3", txtAddress3.Text.ToString());
                cmd.Parameters.AddWithValue("@Tel_No", txtTelephoneNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Fax_No", txtFaxNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text.ToString());

                cmd.ExecuteNonQuery();

                
                if (checkSave == 1)
                {
                    MessageBox.Show("Bank Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Bank Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvBankDetails_SelectionChanged(object sender, EventArgs e)
        {
            
            check = false;
            if (dgvBankDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtBankID.Text = dgvBankDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtBank.Text=dgvBankDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtBankBranchNo.Text=dgvBankDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtBankBranch.Text=dgvBankDetails.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress1.Text=dgvBankDetails.SelectedRows[0].Cells[4].Value.ToString();
                txtAddress2.Text=dgvBankDetails.SelectedRows[0].Cells[5].Value.ToString();
                txtAddress3.Text=dgvBankDetails.SelectedRows[0].Cells[6].Value.ToString();
                txtTelephoneNo.Text=dgvBankDetails.SelectedRows[0].Cells[7].Value.ToString();
                txtFaxNo.Text=dgvBankDetails.SelectedRows[0].Cells[8].Value.ToString();
                txtEmailAddress.Text = dgvBankDetails.SelectedRows[0].Cells[9].Value.ToString();
            }
            btnDelete.Enabled = true;
            check = true;
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
            dgvBankDetails.DataSource = null;
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


          
            dlgSearch dlgBox = new dlgSearch("Search Bank Details", "Bank_ID", "Bank_Name", "Branch_No", "sp_Search_BankData");
            
                if (dlgBox.ShowDialog() == DialogResult.OK)
                {
                    
                    dgvBankDetails.Enabled = true;
                    rs = dlgBox.rs;
                    DataTable dt = new DataTable();
                    if (!rs.HasRows)
                    {
                        MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        
                        dt.Load(rs);
                        dgvBankDetails.DataSource = dt;
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
                cmd.CommandText = "sp_Delete_BankData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_ID", txtBankID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show(Properties.Resources.Deleted, Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Boolean  ValidateMethod()
        {
            
           bool x1 = String.IsNullOrEmpty(txtBankID.Text.ToString());
           bool x2 = String.IsNullOrEmpty(txtBank.Text.ToString());
           bool x3 = String.IsNullOrEmpty(txtBankBranchNo.Text.ToString());
           bool x4 = String.IsNullOrEmpty(txtBankBranch.Text.ToString());
           bool x5 = String.IsNullOrEmpty(txtAddress1.Text.ToString());
           bool x6 = String.IsNullOrEmpty(txtAddress2.Text.ToString());
           bool x7 = String.IsNullOrEmpty(txtAddress3.Text.ToString());
           bool x8 = String.IsNullOrEmpty(txtTelephoneNo.Text.ToString()); 
           bool x9 = String.IsNullOrEmpty(txtFaxNo.Text.ToString()) ;
           bool x0 = String.IsNullOrEmpty(txtEmailAddress.Text.ToString());

           if (!x1 && !x2 && !x3 && !x4 && !x5 && !x6 && !x7 && !x8 && !x9 && !x0)
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
           {
               MessageBox.Show("Fill the mandotory fields.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }

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
            return Regex.IsMatch(txtEmailAddress.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }


        #endregion

        #region Content Change Methods

        private void txtBoxes_TextChanged(object sender, EventArgs e)
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

