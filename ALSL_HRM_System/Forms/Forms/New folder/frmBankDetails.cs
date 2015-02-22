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

namespace ALSL_HRM_System.Forms
{
    public partial class frmBankDetails : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave=0;
        String check = "false";

        #endregion

        #region Constructors

        public frmBankDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
            
        }

        #endregion

        #region Form Load

        private void frmBankDetails_Load(object sender, EventArgs e)
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
        
        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            AddNew();

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
                cmd.Parameters.AddWithValue("@Tel_No", Convert.ToInt32(txtTelephoneNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Fax_No", Convert.ToInt32(txtFaxNo.Text.ToString()));
                cmd.Parameters.AddWithValue("@Email", txtEmailAddress.Text.ToString());

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
                MessageBox.Show("Error Occured..." +e.ToString());
            }

        }



        #endregion
        
        #region DataGrid to TextBoxes

        private void dgvBankDetails_SelectionChanged(object sender, EventArgs e)
        {
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
            txtBankID.Enabled = false;
            check = "false";
        }
        
        #endregion
        
        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmBankDetails_Load(sender, e);
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
                cmd.CommandText = "sp_Delete_BankData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_ID", txtBankID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Bank Details Deleted...");
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
              
               return true;

           else

                return false;

        }
        #endregion

        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            check = "true";
        }


    }
}
