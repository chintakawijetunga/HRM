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
    public partial class frmQualificationReferenceDetails : Office2007Form
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
        public frmQualificationReferenceDetails(frmMDIMain form)
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
        private void frmQualificationReferenceDetails_Load(object sender, EventArgs e)
        {
            MdiParent = form;
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
            dgvQualificationRefDetails.Enabled = true;
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
            }
        }

        private void PopulateData()
        {
            dgvQualificationRefDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_QualificationRefrenceDetails", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvQualificationRefDetails.DataSource = dt;
            rs.Close();
            check = false;
            btnClear.Enabled = true;
        }


        #endregion
        
        #region Add New Method
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Manager Level")
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
            txtQualificationRefNo.Enabled = false;

            ClearAllFields(this);
            String newBankId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtQualificationRefNo.Text = newBankId;
            checkSave = 1;
            btnDelete.Enabled = false;
        }



        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldQualificationRefNo = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_QualificationRefrenceDetails", obj.sqlConnection); //make relavent SP name changes
            command.CommandType = System.Data.CommandType.StoredProcedure;

            rs = command.ExecuteReader();

            while (rs.Read())
                OldQualificationRefNo = rs[0].ToString();
            rs.Close();
            return OldQualificationRefNo;
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
                    cmd.CommandText = "sp_Insert_QualificationReferenceData";
                }
                else
                {
                    cmd.CommandText = "Update_QualificationReferenceData";
                }
                                                                                            
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Qualification_No", txtQualificationRefNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Quli_Description", txtQualificationDescription.Text.ToString());
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text.ToString());
               

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Qualification Reference Details Added.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Qualification Reference Details Updated.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }


        #endregion
        
        #region Datagridview to Textboxes


        private void dvgQualificationRefDetails_SelectionChanged(object sender, EventArgs e)
        {
            check = false;
            if (dgvQualificationRefDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtQualificationRefNo.Text = dgvQualificationRefDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtQualificationDescription.Text = dgvQualificationRefDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtDetails.Text = dgvQualificationRefDetails.SelectedRows[0].Cells[2].Value.ToString();


                txtQualificationRefNo.Enabled = false;
                btnDelete.Enabled = true;
                check = true;
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
                if (MessageBox.Show("Are You Sure You Want to Delete?", "Delete Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteData();
                    PopulateData();
                    ClearAllFields(this);
                }
            }
        }

        private void DeleteData()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Delete_QualificationReferenceData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Qualification_No", txtQualificationRefNo.Text.ToString());

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
            dgvQualificationRefDetails.DataSource = null;
            btnDelete.Enabled = false;
        }



        #endregion
        
        #region Dialogboxes and Search Method


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



            dlgSearch dlgBox = new dlgSearch("Search Qualification Reference Details", "Qualification_No", "Quli_Description", "Unused", "sp_Search_QualificationRefrenceDetails");

            if (dlgBox.ShowDialog() == DialogResult.OK)
            {

                dgvQualificationRefDetails.Enabled = true;
                rs = dlgBox.rs;
                if (!rs.HasRows)
                {
                    MessageBox.Show("No data found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt.Load(rs);
                    dgvQualificationRefDetails.DataSource = dt;
                    rs.Close();
                }
            }


        }

        #endregion
        
        #region Exit method
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

            bool x1 = String.IsNullOrEmpty(txtQualificationRefNo.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtQualificationDescription.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtDetails.Text.ToString());


            if (!x1 && !x2 && !x3)
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



    }
}
