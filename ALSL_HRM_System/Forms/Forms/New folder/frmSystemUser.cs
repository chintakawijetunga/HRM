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

namespace ALSL_HRM_System.Forms
{
    public partial class frmSystemUser : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructor

        public frmSystemUser()
        {
            InitializeComponent();
            DBConnectionMethod();
            
        }

        #endregion

        #region Form Load

        private void frmSystemUser_Load(object sender, EventArgs e)
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
            dgvSystemUsers.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_SystemUsersData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dgvSystemUsers.DataSource = dt;
            rs.Close();
        }

        #endregion

        #region Add New Methods

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            ClearAllFields(this);

        }

        #endregion

        #region Clear Fields Methods

       private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmSystemUser_Load(sender, e);
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

        #region Save Methods

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Save?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (/*ValidateMethod()*/true)
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
                    cmd.CommandText = "sp_Insert_BankData";
                }
                else
                {
                    cmd.CommandText = "Update_BankData";
                }

                cmd.CommandType = CommandType.StoredProcedure;
                /*
                cmd.Parameters.AddWithValue("@Bank_ID", txtBankID.Text.ToString());
                cmd.Parameters.AddWithValue("@Bank_Name", txtBank.Text.ToString());
                cmd.Parameters.AddWithValue("@Branch_No", txtBankBranchNo.Text.ToString());
                cmd.Parameters.AddWithValue("@Branch_Name", txtBankBranch.Text.ToString());
                cmd.Parameters.AddWithValue("@Address1", txtAddress1.Text.ToString());
                cmd.Parameters.AddWithValue("@Address2", txtAddress2.Text.ToString());
                cmd.Parameters.AddWithValue("@Address3", txtAddress3.Text.ToString());
                cmd.Parameters.AddWithValue("@Tel_No", Convert.ToInt32(txtTelephoneNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Fax_No", Convert.ToInt32(txtFaxNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text.ToString());

                cmd.ExecuteNonQuery();
                */

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
                cmd.CommandText = "sp_Delete_BankData";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Bank_ID", txtBankID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Bank Details Deleted...");
            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
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
            /*


            DialogBox1 form2 = new DialogBox1("Search Bank Details", "Bank_ID", "Bank_Name", "Branch_No", "sp_Search_BankData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvBankDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs == null)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    dt.Load(rs);
                    dgvBankDetails.DataSource = dt;

                }
                rs.Close();
            }

            */
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
            this.Close();
        }

        #endregion

    }
}
