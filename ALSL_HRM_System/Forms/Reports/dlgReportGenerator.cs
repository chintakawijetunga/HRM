using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using ALSL_HRM_System.Forms.Reports;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms
{
    public partial class dlgReportGenerator : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        bool checkBoxStatus;
        String storedProcedure=null;
        String path = null;
        frmMDIMain form=null;

        #endregion

        #region Constructor

        public dlgReportGenerator(String storedProcedure, String path, String title, frmMDIMain form)
        {
            InitializeComponent();
            this.TopMost = true;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            this.storedProcedure = storedProcedure;
            this.path=path;
            this.Text += " - " + title;
            DBConnectionMethod();
            this.form = form;
        }
        #endregion
        
        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        #region Report Generate Methods

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            String currentUserName = null;
            //String storedProcedure="sp_Report_Select_Applicant_Detailed_Report";
            //String path= @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crSelectedApplicantDetailReport.rpt";
                      
            //String storedProcedure = "sp_Report_Employees_To_Be_Retired_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeesToBeRetiredReport.rpt";
                        
            //String storedProcedure = "sp_Report_Employees_Service_Level_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeServiceLevelReport.rpt";
            
            //String storedProcedure = "sp_Report_Employees_On_Probation_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeOnProbationReport.rpt";
            
            //String storedProcedure = "sp_Report_Employees_In_House_Loan_Request_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeInHouseLoanRequestReport.rpt";

            //String storedProcedure = "sp_Report_Employee_Resignation_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeResignationReport.rpt";
            
            //String storedProcedure = "sp_Report_Employees_Salry_Increment_Request_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeSalaryIncremenrRequestReport.rpt";

            //String storedProcedure = "sp_Report_Employees_To_Be_Continued_Report";
            //String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeesToBeContinuedReport.rpt";

            //String storedProcedure = "sp_Report_Employee_Leave_Taking_Report";
           // String path = @"D:\HRM Project\1\C#\ALSL_HRM_System\ALSL_HRM_System\CrystalReports\crEmployeeLeaveTakingReport.rpt";

            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Get_Currently_Logged_User";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                currentUserName = rs[0].ToString();
            }

            rs.Close();



           

            String department=null;
            String designation=null;
            String dateFrom = null;
            String dateTo = null;
            
            if (cbDepartmentName.SelectedItem ==null || (cbDepartmentName.SelectedItem).ToString().Equals("--------"))
            {
               
            }
            else
            {
                department = (cbDepartmentName.SelectedItem).ToString();
            }


            if (cbDesignationName.SelectedItem == null || (cbDesignationName.SelectedItem).ToString().Equals("--------"))
            {

            }
            else
            {
                designation = (cbDesignationName.SelectedItem).ToString();
            }

            if(checkBoxStatus)
            {
                dateFrom = dtpDateFrom.Value.ToString("dd-MMM-yyyy");
                dateTo = dtpDateTo.Value.ToString("dd-MMM-yyyy");

            }






            frmReportWindow repObj = new frmReportWindow(currentUserName, dateFrom, dateTo, path, storedProcedure, department, designation, form);
                   
            repObj.Show();
            this.Close();

        }

        #endregion

        #region Load Event

        private void dlgReportGenerator_Load(object sender, EventArgs e)
        {
            FillComboBox();
            fieldsEnableDisable(false);
            checkBoxStatus = false;
        }

        #endregion

        #region Fill ComboBox

        private void FillComboBox()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;
            cmd.CommandText = "sp_Select_DepartmentData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            cbDepartmentName.Items.Add("--------");
            cbDesignationName.Items.Add("--------");
            while (rs.Read())
            {
                cbDepartmentName.Items.Add(rs[1]);
            }

            rs.Close();

            cmd.CommandText = "sp_Select_DesignationData";
            cmd.CommandType = CommandType.StoredProcedure;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {

                cbDesignationName.Items.Add(rs[1]);
            }

            rs.Close();


        }

        #endregion

        #region Checking the CheckBox

        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnable.Checked)
            {
                checkBoxStatus = true;
                fieldsEnableDisable(true);
                
            }
            if (!chkEnable.Checked)
            {
                checkBoxStatus = false;
                fieldsEnableDisable(false);
                
            }
        }

        #endregion

        #region DateTimePicker Enable and Disable

        private void fieldsEnableDisable(bool value)
        {
            dtpDateFrom.Enabled = value;
            dtpDateTo.Enabled = value;
        }

        #endregion

        #region Exit Method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


    }
}
