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
    public partial class frmSalaryIncrementDetails : Office2007Form
    {
       
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region Constructors

        public frmSalaryIncrementDetails()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region Form Load

        private void frmSalaryIncrementDetails_Load(object sender, EventArgs e)
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
            dgvSalaryIncrementDetails.Enabled = true;
            String OldSalIncrId = null;
            SqlCommand command = new SqlCommand("sp_Select_SalaryIncrementData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldSalIncrId = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvSalaryIncrementDetails.DataSource = dt;
            }
            rs.Close();
            return OldSalIncrId;
        }

        #endregion

        #region AddNew Method

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
            FillComboBox();
        }

        private void FillComboBox()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_SalaryIncrementRequestData"; //confirm the SP name with the DB
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                cmbSalIncrReqID.Items.Add(rs[0]);
            }

            rs.Close();
        }

        private void AddNew()
        {
            DisableAllControls(this, true);
            txtSalaryIncrementID.Enabled = false;
            ClearAllFields(this);
            String newSalaryIncrementID = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtSalaryIncrementID.Text = newSalaryIncrementID;

           
            checkSave = 1;
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

                //var checkedButton = grpIncrementDetails.Controls.OfType<RadioButton>()
                //                      .FirstOrDefault(r => r.Checked);

                if (checkSave == 1)
                {
                    cmd.CommandText = "sp_Insert_SalaryIncrementData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_SalaryIncrementData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                string condition = null;
                if (rbtYes.Checked || rbtNo.Checked)
                {
                    condition = rbtYes.Checked ? "Yes" : "No";
                }
              
                cmd.Parameters.AddWithValue("@Sal_Inc_ID", txtSalaryIncrementID.Text.ToString());
                cmd.Parameters.AddWithValue("@Sal_Inc_Req_ID", cmbSalIncrReqID.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Condition", condition);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(txtIncrementAmt.Text.ToString()));
                

                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Salary Increment Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Salary Increment Details Updated...");
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

        private void dgvSalaryIncrementDetails_SelectionChanged(object sender, EventArgs e)
        {
          

            if (dgvSalaryIncrementDetails.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtSalaryIncrementID.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[0].Value.ToString();
                cmbSalIncrReqID.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[2].Value.ToString();
                txtRequestAmount.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[3].Value.ToString();
             //   rb.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[4].Value.ToString();
                if (dgvSalaryIncrementDetails.SelectedRows[0].Cells[4].Value.ToString() == "Yes")
                {
                    rbtYes.Checked = true;
                }
                else 
                {
                    rbtNo.Checked = true;
                }

                txtIncrementAmt.Text = dgvSalaryIncrementDetails.SelectedRows[0].Cells[5].Value.ToString();
               
            }
            txtSalaryIncrementID.Enabled = false;
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
            DialogBox1 form2 = new DialogBox1("Search Salary Increment Details", "Sal_Inc_ID", "Sal_Inc_Req_ID", "Employee_Name", "sp_Search_SalaryIncrementData");

            if (form2.ShowDialog() == DialogResult.OK)
            {

                dgvSalaryIncrementDetails.Enabled = true;
                rs = form2.rs;
                DataTable dt = new DataTable();
                dt.Load(rs);
                dgvSalaryIncrementDetails.DataSource = dt;
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
                cmd.CommandText = "sp_Delete_SalaryIncrementData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Sal_Inc_ID", txtSalaryIncrementID.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Increment Details Deleted...");
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
