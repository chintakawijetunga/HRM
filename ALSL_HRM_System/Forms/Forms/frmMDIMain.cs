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


namespace ALSL_HRM_System.Forms.Forms
{
    public partial class frmMDIMain : Office2007Form
    {

        #region Variable Declaration
        ALSL_HRM_System.PublicClasses.DBConnection obj;
        String storedProcedureReports=null;
        String path = null;
        String storedProcedureLetters = null;
        String titleReports = null;
        String filePath = null;
        String comboBoxName = null;
        String comboBoxSP = null;
        String EmailSubject = null;
        #endregion

        public frmMDIMain()
        {
            InitializeComponent();
            DBConnectionMethod();
            //this.WindowState = FormWindowState.Maximized;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.ControlBox = false;
            this.TopMost = true;
            WindowState = FormWindowState.Maximized;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            SettingButtonImage();
            this.BackColor = Color.AliceBlue;
            
        }

        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        private void SettingButtonImage()
        {
            btnSelectedApplicantDetails.Image = Properties.Resources.Selected_Applicant;
            btnPermanentEmployeeDetails.Image = Properties.Resources.Permanent_Employee;
            btnAboutTheSoftware.Image = Properties.Resources.About_the_sw;
            btnBankDetails.Image = Properties.Resources.Bank_Details;
            btnChangePassword.Image = Properties.Resources.Create_New_Profile_Change_Password;
            btnDepartmentDetails.Image = Properties.Resources.Department_Details;
            btnDesignationDetails.Image = Properties.Resources.Designation_Details;
            btnEmployeeLeavingTakingReport.Image = Properties.Resources.Emp_Leave_Taking_Report;
            btnEmployeeLeaveDetails.Image = Properties.Resources.Emp_Leave;
            btnEmployeesOnProbationReport.Image = Properties.Resources.Emp_OnProbation_Report;
            btnEmployeeResignationDetails.Image = Properties.Resources.EmployeeRegDetails;
            btnEmployeeServiceLevelReport.Image = Properties.Resources.Emp_Service_Level_Report;
            btnEmployeesToBeContinuedReports.Image = Properties.Resources.Emp_To_Be_Continued_Report;
            btnHelp.Image = Properties.Resources.help;
            btnInHouseLoanConfirmationLetter.Image = Properties.Resources.InHouse_Loan_Confirmation_Letter;
            btnInHouseLoanRejectionLetter.Image = Properties.Resources.InHouse_Loan_Rejection_Letter;
            btnInHouseLoanRequestReport.Image = Properties.Resources.InHouse_Loan_Request_Report;
            btnLeaveConfirmationLetter.Image = Properties.Resources.Leave_Confirmation_Letter;
            btnLeaveTypeDetails.Image = Properties.Resources.Leave_Type;
            btnEmployeeLoanDetails.Image = Properties.Resources.Loan_Details;
            btnEmployeeLoanRequestData.Image = Properties.Resources.Loan_Request;
            btnLoanTypeDetails.Image = Properties.Resources.Loan_Type;
            btnPermanentEmployeeDetails.Image = Properties.Resources.Permanent_Employee;
            btnQualificationReferenceDetails.Image = Properties.Resources.Qualification_Reference;
            btnResignedEmployeesReport.Image = Properties.Resources.Resigned_Emp_Report;
            btnRetirementLetter.Image = Properties.Resources.Retirement_Letter;
            btnRetirementRemindingLetter.Image = Properties.Resources.Retirement_Reminding_Letter;
            btnSalaryIncrementLetter.Image = Properties.Resources.Salary_Increment_Letter;
            btnSalaryIncrementRejectionLetter.Image = Properties.Resources.Salary_Increment_Rejection_Letter;
            btnSalaryIncrementRequestReport.Image = Properties.Resources.Salary_Increment_Req_Report;
            btnEmployeeSalaryIncrementData.Image = Properties.Resources.Salary_Increment_Request;
            btnEmployeeSalaryIncrementDetails.Image = Properties.Resources.Salary_Increment;
            btnSelectedApplicantDetailedReport.Image = Properties.Resources.Selected_Applicant_Report;
            btnSelectedApplicantDetails.Image = Properties.Resources.Selected_Applicant;
            btnServiceExtendConfirmationLetter.Image = Properties.Resources.Service_Extend_Confirmation_Letter;
            btnServiceExtendRejectionLetter.Image = Properties.Resources.Service_Extend_Rejection_Letter;
            btnServiceExtendRequestReport.Image = Properties.Resources.Service_Extend_Request_Report;
            btnServiceExtendRequestData.Image = Properties.Resources.Service_Extend_Request;
            btnEmployeeServiceExtendDetails.Image = Properties.Resources.Service_Extend;
            btnEmployeeSpecialRemarksDetails.Image = Properties.Resources.Special_remarks;
            btnSystemUserDetails.Image = Properties.Resources.System_User_details;
            btnUserManual.Image = Properties.Resources.User_manual;
            btnVacancyDetails.Image = Properties.Resources.Vacancy;
        }

        #region General Information

        private void btnSelectedApplicantDetails_Click(object sender, EventArgs e)
        {
            frmSelectedApplicantInformation obj = new frmSelectedApplicantInformation(this);
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            
           
        }

        private void btnPermanentEmployeeDetails_Click(object sender, EventArgs e)
        {
            frmPermenentEmployees obj = new frmPermenentEmployees(this);
            
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btnEmployeeSpecialRemarksDetails_Click(object sender, EventArgs e)
        {
            frmSpecialRemark obj = new frmSpecialRemark(this);
            
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btnEmployeeServiceExtendDetails_Click(object sender, EventArgs e)
        {
            frmServiceExtendDetails obj = new frmServiceExtendDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnEmployeeSalaryIncrementDetails_Click(object sender, EventArgs e)
        {
            frmSalaryIncrementDetails obj = new frmSalaryIncrementDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnEmployeeLeaveDetails_Click(object sender, EventArgs e)
        {
            frmLeaveDetails obj = new frmLeaveDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnEmployeeLoanDetails_Click(object sender, EventArgs e)
        {
            frmLoanDetails obj = new frmLoanDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnEmployeeResignationDetails_Click(object sender, EventArgs e)
        {
            frmResignationDetails obj = new frmResignationDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Employee Requests

        private void btnEmployeeLoanRequestData_Click(object sender, EventArgs e)
        {
            frmLoanRequestDetails obj = new frmLoanRequestDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnEmployeeSalaryIncrementData_Click(object sender, EventArgs e)
        {
            frmSalaryIncrementRequest obj = new frmSalaryIncrementRequest(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
            
        }

        private void btnServiceExtendRequestData_Click(object sender, EventArgs e)
        {
            frmServiceExtendRequest obj = new frmServiceExtendRequest(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Referencial Data

       

        private void btnVacancyDetails_Click(object sender, EventArgs e)
        {
            frmVacancyData obj = new frmVacancyData(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnBankDetails_Click(object sender, EventArgs e)
        {
            frmBankDetails obj = new frmBankDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnDepartmentDetails_Click(object sender, EventArgs e)
        {
            frmDepartmentDetails obj = new frmDepartmentDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnDesignationDetails_Click(object sender, EventArgs e)
        {
            frmDesignationDetails obj = new frmDesignationDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnLoanTypeDetails_Click(object sender, EventArgs e)
        {
            frmLoanTypeDetails obj = new frmLoanTypeDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnQualificationReferenceDetails_Click(object sender, EventArgs e)
        {
            frmQualificationReferenceDetails obj = new frmQualificationReferenceDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnLeaveTypeDetails_Click(object sender, EventArgs e)
        {
            frmLeaveTypeDetails obj = new frmLeaveTypeDetails(this);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Report Generation

        private void btnSelectedApplicantDetailedReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Select_Applicant_Detailed_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crSelectedApplicantDetailReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crSelectedApplicantDetailReport.rpt";
                titleReports = "Selected Applicant Detailed Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnInHouseLoanRequestReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employees_In_House_Loan_Request_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeInHouseLoanRequestReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeInHouseLoanRequestReport.rpt";
                titleReports = "Employee In House Loan Request Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnSalaryIncrementRequestReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employees_Salry_Increment_Request_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeSalaryIncremenrRequestReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeSalaryIncremenrRequestReport.rpt";
                titleReports = "Salary Increment Request Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnServiceExtendRequestReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employee_Service_Extend_Request_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeServiceExtendRequestReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeServiceExtendRequestReport.rpt";
                titleReports = "Service Extend Request Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnEmployeeLeavingTakingReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employee_Leave_Taking_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeLeaveTakingReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeLeaveTakingReport.rpt";
                titleReports = "Employee Leave Taking Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnEmployeesOnProbationReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employees_On_Probation_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeOnProbationReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeOnProbationReport.rpt";
                titleReports = "Employees On Probation";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnEmployeeServiceLevelReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employees_Service_Level_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeServiceLevelReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeServiceLevelReport.rpt";
                titleReports = "Employee Service Level Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnResignedEmployeesReport_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employee_Resignation_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeeResignationReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeeResignationReport.rpt";
                titleReports = "Resigned Employees Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        private void btnEmployeesToBeContinuedReports_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureReports = "sp_Report_Employees_To_Be_Continued_Report";
                //path = @"D:\HRM Project\1\C#\ALSL_HRM_System\CrystalReports\crEmployeesToBeContinuedReport.rpt";
                path = @"C:\HRM Project\CrystalReports\crEmployeesToBeContinuedReport.rpt";
                titleReports = "Employees To Be Continued Report";
                dlgReportGenerator obj = new dlgReportGenerator(storedProcedureReports, path, titleReports, this);
                obj.ShowDialog();
            }
        }

        #endregion

        #region Letter Generator

        private void btnServiceExtendRejectionLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Service_Ext_Req_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrServiceExtendRejectionLetter.rpt";
                comboBoxName = "Service Extend Request ID";
                comboBoxSP = "sp_Select_ServiceExtendData";
                EmailSubject = "Service Extend Rejection Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnServiceExtendConfirmationLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Service_Ext_Req_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrServiceExtendConfirmationLetter.rpt";
                comboBoxName = "Service Extend Request ID";
                comboBoxSP = "sp_Select_ServiceExtendData";
                EmailSubject = "Service Extend Confirmation Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnSalaryIncrementRejectionLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Salary_Increment_Request_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrSalaryIncrementRejectionLetter.rpt";
                comboBoxName = "Salary Increment Request ID";
                comboBoxSP = "sp_Select_SalaryIncrementData";
                EmailSubject = "Salary Increment Rejection Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnSalaryIncrementLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Salary_Increment_Request_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrSalaryIncrementLetter.rpt";
                comboBoxName = "Salary Increment Request ID";
                comboBoxSP = "sp_Select_SalaryIncrementData";
                EmailSubject = "Salary Increment Confirmation Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnRetirementLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Employee_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrRetirementLetter.rpt";
                comboBoxName = "Employee ID";
                comboBoxSP = "sp_Select_Employees_To_Be_Retired";
                EmailSubject = "Retirement Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnRetirementRemindingLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Employee_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrRetirementRemindingLetter.rpt";
                comboBoxName = "Employee ID";
                comboBoxSP = "sp_Select_Employees_To_Be_Retired";
                EmailSubject = "Retirement Reminding Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnLeaveConfirmationLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Leave_ID";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrLeaveConfirmationLetter.rpt";
                comboBoxName = "Leave ID";
                comboBoxSP = "sp_Select_EmployeeLeaveData";
                EmailSubject = "Leave Confirmation Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnInHouseLoanRejectionLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Loan_Req_No";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrInHouseLoanRejectionLetter.rpt";
                comboBoxName = "Loan Request No";
                comboBoxSP = "sp_Select_InHouseLoanRequestData";
                EmailSubject = "In House Loan Rejection Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        private void btnInHouseLoanConfirmationLetter_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                storedProcedureLetters = "sp_Letter_PermanentEmployeeData_By_Loan_Req_No";
                filePath = @"C:\HRM Project\CrystalReportsLetters\ltrInHouseLoanConfirmationLetter.rpt";
                comboBoxName = "Loan Request No";
                comboBoxSP = "sp_Select_InHouseLoanRequestData";
                EmailSubject = "In House Loan Confirmation Letter";
                dlgLetterGenerator obj = new dlgLetterGenerator(storedProcedureLetters, filePath, comboBoxName, comboBoxSP, EmailSubject, this);
                obj.ShowDialog();
            }
        }

        #endregion

        #region System Management

        private void btnSystemUserDetails_Click(object sender, EventArgs e)
        {
            if (frmLoginUser.UserType == "Employee Level")
            {
                MessageBox.Show("You don't have previledges to perform this operation.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmSystemUser obj = new frmSystemUser(this);
                obj.Show();
                obj.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangeProfile obj = new frmChangeProfile();
            obj.ShowDialog();
            //obj.WindowState = FormWindowState.Maximized;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

            HRM_DBInstallation.frmDBRnB obj = new HRM_DBInstallation.frmDBRnB();
            obj.ShowDialog();
        }
        #endregion

        #region Logout Methods

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", Properties.Resources.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                AddToUserLoginData();
                this.Dispose();
            }
        }

        private void AddToUserLoginData()
        {

            SqlCommand cmd = new SqlCommand("Update_UserLoginData", obj.sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@Logout_Date", DateTime.Now.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Logout_Time", DateTime.Now.ToString("hh:mm:ss"));
            cmd.ExecuteNonQuery();

        }

        #endregion

        private void frmMDIMain_Load(object sender, EventArgs e)
        {
            this.Text = "Anala Laboratory Services (Pvt) Ltd. HRM System. Logged As - " + frmLoginUser.currentUserName;
        }

        private void btnUserManual_Click(object sender, EventArgs e)
        {
            filePath = @"C:\HRM Project\Documents\User Manual.pdf";
            frmDocumentViewer obj = new frmDocumentViewer(this, filePath);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            filePath = @"C:\HRM Project\Documents\User Manual.pdf";
            frmDocumentViewer obj = new frmDocumentViewer(this, filePath);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        private void btnAboutTheSoftware_Click(object sender, EventArgs e)
        {
            filePath = @"C:\HRM Project\Documents\SRS.pdf";
            frmDocumentViewer obj = new frmDocumentViewer(this, filePath);
            obj.Show();
            obj.WindowState = FormWindowState.Maximized;
        }

        

        







    }
}
