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
    public partial class frmServiceExtendDetails : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;
        String check = "false";
        String isExtended = null;

        #endregion

        #region Constructors
        public frmServiceExtendDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
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
                    cmd.CommandText = "sp_Insert_ServiceExtendData";
                }
                else
                {
                    cmd.CommandText = "Update_ServiceExtendData";
                }

                cmd.CommandType = CommandType.StoredProcedure;
                

                if(rbtYesExtend.Checked)
                    isExtended="1";
                else if(rbtNoExtend.Checked)
                    isExtended="0";

                cmd.Parameters.AddWithValue("@Service_Extend_ID", txtServiceExtendID.Text.ToString());
                cmd.Parameters.AddWithValue("@Service_Extend_Request_ID", cmbExtendReqID.Text.ToString());
                cmd.Parameters.AddWithValue("@Is_Extended", isExtended);
                cmd.Parameters.AddWithValue("@Extend_From", dtpExtendFrom.Value.ToString("dd-mm-yyyy"));
                cmd.Parameters.AddWithValue("@Extend_To", dtpExtendTo.Value.ToString("dd-mm-yyyy"));
                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Service Extend Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Service Extend Details Updated...");
                }

                PopulateData();

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }

        }




        #endregion


        #region Populate Method
        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData();
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


        #region Delete Method
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void DeleteData()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Delete_ServiceExtendData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Service_Extend_ID", txtServiceExtendID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Extend Details Deleted...");
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
                frmServiceExtendDetails_Load(sender, e);
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


        #region Exit Method
        private void btnExit_Click(object sender, EventArgs e)
        {

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
            txtServiceExtendID.Enabled = false;

            ClearAllFields(this);
            String newServiceExtendID = Regex.Replace(GetNextID(), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtServiceExtendID.Text = newServiceExtendID;
            checkSave = 1;
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
            OpenDialogBox();
        }

        private void OpenDialogBox()
        {



            DialogBox1 form2 = new DialogBox1("Search Bank Details", "Bank_ID", "Bank_Name", "Branch_No", "sp_Search_BankData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvServiceExtendDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                if (rs == null)
                {
                    //MessageBox.Show("");
                }
                else
                {
                    dt.Load(rs);
                    dgvServiceExtendDetails.DataSource = dt;

                }
                rs.Close();
            }


        }


        #endregion


        #region Form Load Method
        private void frmServiceExtendDetails_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
            EnableButtons(btnExit);
            EnableButtons(btnSearch);
        }




        #endregion


        #region TextBox Change Method
        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion


        #region Datagrid to TextBoxes Method
        private void dgvServiceExtendDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServiceExtendDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtServiceExtendID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbExtendReqID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeID.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtEmployeeName.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[3].Value.ToString();
                dtpExtendFrom.Text=dgvServiceExtendDetails.SelectedRows[0].Cells[4].Value.ToString();
                dtpExtendTo.Text = dgvServiceExtendDetails.SelectedRows[0].Cells[5].Value.ToString();
                
               isExtended =dgvServiceExtendDetails.SelectedRows[0].Cells[6].Value.ToString();
                if(isExtended.Equals("1"))
                    rbtYesExtend.Select();
                else
                    rbtNoExtend.Select();

            }
            txtServiceExtendID.Enabled = false;
            check = "false";
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

                return true;

            else

                return false;

        }
        #endregion
    }
}
