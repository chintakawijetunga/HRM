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


namespace ALSL_HRM_System.Forms
{
    public partial class frmServiceExtendRequest : Office2007Form
    {

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmServiceExtendRequest()
        {
            InitializeComponent();
            DBConnectionMethod();    
        }

        #endregion
        
        #region Form Load

        private void frmServiceExtendRequest_Load(object sender, EventArgs e)
        {
            DisableAllControls(this, false);
            EnableButtons(btnPopulate);
            EnableButtons(btnAddNew);
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
            PopulateData(1);
        }

        private String PopulateData(int check)
        {
            dgvServiceExtendRequest.Enabled = true;
            String OldSrvExtReqId = null;
            SqlCommand command = new SqlCommand("sp_Select_ServiceExtendRequestData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldSrvExtReqId = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvServiceExtendRequest.DataSource = dt;
            }
            rs.Close();
            return OldSrvExtReqId;
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
            txtServiceExtReqID.Enabled = false;
            ClearAllFields(this);
            String newSerReqId = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtServiceExtReqID.Text = newSerReqId;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_PermanentEmployeeData";      //check sp name
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbEmployeeID.Items.Add(rs[0]);
            }

            rs.Close();

            checkSave = 1;

        }


        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "";               //check sp to get fName n lName
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                txtFirstName.Text = rs[1].ToString();
                txtLastName.Text = rs[2].ToString();
            }
        }

        #endregion

        #region Save Data Methods

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_ServiceExtendRequestData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_ServiceExtendRequestData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Extend_Req_ID", txtServiceExtReqID.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_ID", cmbEmployeeID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Duration", Convert.ToInt32(txtReqMonths.Text.ToString()));
                cmd.Parameters.AddWithValue("@Active", Convert.ToInt32(1));
                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Service Extend Request Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Service Extend Request Details Updated...");
                }

                PopulateData(1);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error Occured..." + e.ToString());
            }
        }

        #endregion

        #region DataGrid to TextBoxes

        private void dgvServiceExtendRequest_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServiceExtendRequest.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtServiceExtReqID.Text = dgvServiceExtendRequest.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeID.Text = dgvServiceExtendRequest.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvServiceExtendRequest.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvServiceExtendRequest.SelectedRows[0].Cells[3].Value.ToString();
                txtReqMonths.Text = dgvServiceExtendRequest.SelectedRows[0].Cells[4].Value.ToString();
               
            }
            txtServiceExtReqID.Enabled = false;
        }

        #endregion

        
        #region Clear Fields Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields(this);
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
            DialogBox1 form2 = new DialogBox1("Search Service Extend Request Details", "Extend_Req_ID", "Employee_ID", "", "sp_Search_ServiceExtendRequestData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvServiceExtendRequest.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                dt.Load(rs);
                dgvServiceExtendRequest.DataSource = dt;
                rs.Close();
            }
        }

        #endregion

        #region Delete Data Methods

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            PopulateData(1);
            ClearAllFields(this);
        }

        private void DeleteData()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = obj.sqlConnection;
                cmd.CommandText = "sp_Delete_ServiceExtendRequestData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bank_ID", txtServiceExtReqID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Service Extend Request Details Deleted...");
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
            ExitForm();
        }

        private void ExitForm()
        {
            this.Close();
        }

        #endregion

      
    }
}
