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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ALSL_HRM_System.Forms
{
    public partial class frmSpecialRemark : Office2007Form
    {
        #region Constructors

        public frmSpecialRemark()
        {
            InitializeComponent();
            DBConnectionMethod();
        }

        #endregion

        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        int checkSave = 0;

        #endregion

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {
            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();
        }
        
        #endregion

        #region Form Load

        private void frmSpecialRemark_Load(object sender, EventArgs e)
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

        #region Populate Methods

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            PopulateData(1);
        }

        private String PopulateData(int check)
        {

            dgvSpecialRemark.Enabled = true;
            String OldRemarkId = null;
            SqlCommand command = new SqlCommand("sp_Select_SpecialRemarksData", obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            rs = command.ExecuteReader();

            if (check == 2)
            {
                while (rs.Read())
                {
                    OldRemarkId = rs[0].ToString();
                }
            }
            else
            {
                dt.Load(rs);
                dgvSpecialRemark.DataSource = dt;
            }
            rs.Close();
            return OldRemarkId;
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
            cmbEmployeeNumber.Enabled = false;
            //btnUpdate.Enabled = false;
            ClearAllFields(this);
            String newRemarkId = Regex.Replace(PopulateData(2), "\\d+",
            m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));

            txtRemarkId.Text = newRemarkId;
            checkSave = 1;
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
                    cmd.CommandText = "sp_Insert_SpecialRemarksData";
                }
                else
                {
                    cmd.CommandText = "sp_Update_SpecialRemarksData";
                }

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Remark_ID", txtRemarkId.Text.ToString());
                cmd.Parameters.AddWithValue("@Employee_ID", cmbEmployeeNumber.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SR_Date", dtpRemarkDate.Value.ToString());
                cmd.Parameters.AddWithValue("@SR_Des", txtRemark.Text.ToString());


                cmd.ExecuteNonQuery();


                if (checkSave == 1)
                {
                    MessageBox.Show("Remark Details Added...");
                    checkSave = 0;
                }
                else
                {
                    MessageBox.Show("Remark Details Updated...");
                }

                PopulateData(1);

            }

              catch (Exception e)
              {
                  MessageBox.Show("Error Occured..." + e.ToString());
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
                cmd.CommandText = "sp_Delete_SpecialRemarksData";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Remark_ID", txtRemarkId.Text.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Remark Details Deleted...");
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

        #region DataGrid to TextBoxes

        private void dgvSpecialRemark_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSpecialRemark.SelectedRows.Count == 1)
            {
                DisableAllControls(this, true);
                txtRemarkId.Text = dgvSpecialRemark.SelectedRows[0].Cells[0].Value.ToString();
                cmbEmployeeNumber.SelectedText = dgvSpecialRemark.SelectedRows[0].Cells[1].Value.ToString();
                txtEmployeeName.Text = dgvSpecialRemark.SelectedRows[0].Cells[2].Value.ToString();
                dtpRemarkDate.Text = dgvSpecialRemark.SelectedRows[0].Cells[3].Value.ToString();
                txtRemark.Text = dgvSpecialRemark.SelectedRows[0].Cells[4].Value.ToString();

            }
            txtRemarkId.Enabled = false;
        }

        #endregion
    }
}



