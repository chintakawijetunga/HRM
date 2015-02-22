using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using ALSL_HRM_System.Forms.Forms;
namespace ALSL_HRM_System.Forms.Reports
{
    public partial class frmReportWindow : Office2007Form
    {
        #region Variable Declaration

        ALSL_HRM_System.PublicClasses.DBConnection obj;
       

        #endregion

        String printedBy;
        String fromDate;
        String toDate;
        String filePath;
        String SP;
        String department;
        String designation;
        frmMDIMain form;
        public frmReportWindow(String printedBy, String fromDate, String toDate, String filePath, String SP, String department, String designation, frmMDIMain form)
        {
            InitializeComponent();
            MdiParent = form;
            this.form = form;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            DBConnectionMethod();
            this.printedBy = printedBy;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.filePath = filePath;
            this.SP = SP;
            this.department = department;
            this.designation = designation;
            GenerateReportMethod();
        }


        #region DBConnection Class Calling Method

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }

        #endregion

        private void GenerateReportMethod()
        {
            SqlCommand command = new SqlCommand(SP, obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            if (string.IsNullOrEmpty(fromDate))
            {
                command.Parameters.AddWithValue("@fromDate", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@fromDate", fromDate);
            }

            if (string.IsNullOrEmpty(toDate))
            {
                command.Parameters.AddWithValue("@toDate", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@toDate", toDate);
            }


            if (string.IsNullOrEmpty(department))
            {
                command.Parameters.AddWithValue("@departmentName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@departmentName", department);
            }

            if (string.IsNullOrEmpty(designation))
            {
                command.Parameters.AddWithValue("@designationName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@designationName", designation);
            }
            
           
                       

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
             da.Fill(dt);
            
            ReportDocument reportObject = new ReportDocument();

            reportObject.Load(filePath);
            reportObject.SetDataSource(dt);

            if (fromDate == null)
                reportObject.SetParameterValue("DateFrom", "************************");
            else
                reportObject.SetParameterValue("DateFrom", fromDate);

            if (toDate == null)
                reportObject.SetParameterValue("DateTo", "************************");
            else
                reportObject.SetParameterValue("DateTo", toDate);

            reportObject.SetParameterValue("OrderedBy", "Management");
            reportObject.SetParameterValue("PrintedBy", printedBy);
          

            crystalReportViewer.ReportSource = reportObject;



        }



    }
}
