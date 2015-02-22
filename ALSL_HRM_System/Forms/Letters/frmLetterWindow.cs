using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Outlook = Microsoft.Office.Interop.Outlook;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using ALSL_HRM_System.Forms.Forms;

namespace ALSL_HRM_System.Forms.Letters
{
    public partial class frmLetterWindow : Office2007Form
    {
        #region Variable declaration
        ALSL_HRM_System.PublicClasses.DBConnection obj;
        SqlDataReader rs = null;
        String employeeDetails;
        String location;
        String emailAddress;
        String EmailSubject = null;
        String EmailBody = null;
        String SearchID=null;
        frmMDIMain form;
        #endregion

        #region Constructor

        public frmLetterWindow(String employeeDetails, String location, String emailAddress, String EmailSubject, String EmailBody, String SearchID, frmMDIMain form)
        {
            InitializeComponent();
            MdiParent = form;
            this.form = form;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            this.employeeDetails = employeeDetails;
            this.location = location;
            this.emailAddress = emailAddress;
            this.EmailSubject = EmailSubject;
            this.EmailBody = EmailBody;
            this.Text = EmailSubject;
            this.SearchID = SearchID;
            DBConnectionMethod();
            
        }

        #endregion

        #region DBConnection Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion
        #region Form Load Method

        private void frmLetterWindow_Load(object sender, EventArgs e)
        {
            CreateReportMethod();

        }

        private void CreateReportMethod()
        {

            ReportDocument reportObject = new ReportDocument();
            String fileSaveLocation = @"D:\Attachment.pdf";
            reportObject.Load(location);
            reportObject=SetParameters(reportObject);
            crystalReportViewer1.ReportSource = reportObject;
            crystalReportViewer1.Refresh();
            if (emailAddress != "")
            {
                reportObject.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileSaveLocation);
                SendMessageMethod(fileSaveLocation);
            }
            else
            {
                MessageBox.Show("Email Not Sent because no email address was provided.", Properties.Resources.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ReportDocument SetParameters(ReportDocument reportObject)
        {

            reportObject.SetParameterValue("EmployeeDetails", employeeDetails);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = obj.sqlConnection;

            #region Retirement Reminding Letter

            if (EmailSubject == "Retirement Reminding Letter")
            {
                cmd.CommandText = "sp_Search_PermanentEmployeeData";
                cmd.Parameters.AddWithValue("@Employee_No", SearchID);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("RetirementDate", rs["Retire_Date"]);
                }
            }

            #endregion
            
            #region Retirement Letter

            if (EmailSubject == "Retirement Letter")
            {
                cmd.CommandText = "sp_Search_PermanentEmployeeData";
                cmd.Parameters.AddWithValue("@Employee_No", SearchID);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("RetirementDate", rs["Retire_Date"]);
                    reportObject.SetParameterValue("NoofYears", rs["Service Period"]);
                }
            }

            #endregion
          
            #region Leave Confirmation Letter

            if (EmailSubject == "Leave Confirmation Letter")
            {
                cmd.CommandText = "sp_Search_EmployeeLeaveData";
                cmd.Parameters.AddWithValue("@Leave_ID", SearchID);
                cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Leave_Type", DBNull.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("FromDateLeave", rs["Leave_St_Date"]);
                    reportObject.SetParameterValue("ToDateLeave", rs["Leave_End_Date"]);
                }
            }

            #endregion

            #region In House Loan Rejection Letter

            if (EmailSubject == "In House Loan Rejection Letter")
            {
                cmd.CommandText = "sp_Search_InHouseLoanRequestData";
                cmd.Parameters.AddWithValue("@Loan_Request_No", SearchID);
                cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Loan_Type", DBNull.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("RequestedDate", rs["Request_Date"]);
                    reportObject.SetParameterValue("RequestedAmount", rs["Loan_Amount"]);
                }
            }

            #endregion

            #region Leave Confirmation Letter

            if (EmailSubject == "In House Loan Confirmation Letter")
            {
                cmd.CommandText = "sp_Search_InHouseLoanRequestData";
                cmd.Parameters.AddWithValue("@Loan_Request_No", SearchID);
                cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Loan_Type", DBNull.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("RequestedDate", rs["Request_Date"]);
                    reportObject.SetParameterValue("RequestedAmount", rs["Loan_Amount"]);
                }
            }

            #endregion

            #region Salary Increment Confirmation Letter

            if (EmailSubject == "Salary Increment Confirmation Letter")
            {
                cmd.CommandText = "sp_Search_SalaryIncrementData";
                cmd.Parameters.AddWithValue("@Salary_Increment_ID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary_Increment_Request_ID", SearchID);
                cmd.Parameters.AddWithValue("@Employee_ID", DBNull.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                rs = cmd.ExecuteReader();

                while (rs.Read())
                {
                    reportObject.SetParameterValue("incrementAmount", rs["Increment Amount"]);
                }
            }

            #endregion


            return reportObject;
        }



        #endregion

        #region Send Email Method

        private void SendMessageMethod(String fileGetLoacation)
        {

            Outlook.Application oApp = new Outlook.Application();
            Outlook.MailItem email = (Outlook.MailItem)(oApp.CreateItem(Outlook.OlItemType.olMailItem));
            email.Recipients.Add(emailAddress);
            email.Subject = EmailSubject;
            email.Body = EmailBody;
            email.Attachments.Add(fileGetLoacation, Outlook.OlAttachmentType.olByValue, 1, fileGetLoacation);


            try
            {
                ((Outlook.MailItem)email).Send();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email sending failed. Goto the draft folder in MS Outlook.", Properties.Resources.CompanyName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            email = null;

        }

        #endregion

    }
}
