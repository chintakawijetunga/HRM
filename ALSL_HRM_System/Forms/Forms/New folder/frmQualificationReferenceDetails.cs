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

namespace ALSL_HRM_System.Forms
{
    public partial class frmQualificationReferenceDetails : Office2007Form
    {
        #region Variable Declaration


        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        String check = "false";

        #endregion

        #region Constructors
        public frmQualificationReferenceDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }



        #endregion

        #region Form Load
        private void frmQualificationReferenceDetails_Load(object sender, EventArgs e)
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
            dvgQualificationRefDetails.Enabled = true;
            SqlCommand command = new SqlCommand("sp_Select_QualificationRefrenceDetails", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            rs = command.ExecuteReader();
            dt.Load(rs);
            dvgQualificationRefDetails.DataSource = dt;
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
            txtQualificationRefNo.Enabled = false;

            ClearAllFields(this);
            String newBankId = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtQualificationRefNo.Text = newBankId;
            checkSave = 1;
        }



        #endregion

        #region Get Methods

        private string GetNextID()
        {
            String OldQualificationRefNo = null;
            SqlCommand command = new SqlCommand("sp_SelectAll_QualificationReferenceDetails", obj.sqlConnection); //make relavent SP name changes
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
                    cmd.CommandText = "sp_Insert_QualificationReferenceData";
                }
                else
                {
                    cmd.CommandText = "Update_QualificationReferenceData";
                }
                                                                                            
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@QualificationRefNo", txtQualificationRefNo.Text.ToString());
                cmd.Parameters.AddWithValue("@QualificationDescription", txtQualificationDescription.Text.ToString());
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text.ToString());
               

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Qualification Reference Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Qualification Reference Details Updated...");
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

            if (dvgQualificationRefDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtQualificationRefNo.Text = dvgQualificationRefDetails.SelectedRows[0].Cells[0].Value.ToString();
                txtQualificationDescription.Text = dvgQualificationRefDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtDetails.Text = dvgQualificationRefDetails.SelectedRows[0].Cells[2].Value.ToString();


                txtQualificationRefNo.Enabled = false;
                check = "false";
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
                cmd.CommandText = "sp_Delete_QualificationReferenceData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@QualificationRefNo", txtQualificationRefNo.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Qualification Reference Details Deleted...");
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
            if (MessageBox.Show("Are You Sure You Want to Clear?", "Clear the Fields", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClearAllFields(this);
                frmQualificationReferenceDetails_Load(sender, e);
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


        #region Dialogboxes and Search Method


        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenDialogBox();
        }


        private void OpenDialogBox()
        {



            DialogBox1 form2 = new DialogBox1("Search Bank Details", "Bank_ID", "Bank_Name", "Branch_No", "sp_Search_QualificationReferenceData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dvgQualificationRefDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs == null)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    dt.Load(rs);
                    dvgQualificationRefDetails.DataSource = dt;

                }
                rs.Close();
            }


        }

        #endregion


        #region Exit method
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

            bool x1 = String.IsNullOrEmpty(txtQualificationRefNo.Text.ToString());
            bool x2 = String.IsNullOrEmpty(txtQualificationDescription.Text.ToString());
            bool x3 = String.IsNullOrEmpty(txtDetails.Text.ToString());
          

            if (!x1 && !x2 && !x3 )

                return true;

            else
                
                return false;

        }
        #endregion

        
        
        #region TextBox Change
        private void txtBoxes_TextChanged(object sender, EventArgs e)
        {
            check = "true";
        }
        #endregion
































    }
}
