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

namespace ALSL_HRM_System.Forms
{
    public partial class frmTest : Form
    {
        ALSL_HRM_System.PublicClasses.DBConnection obj;

        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            testMethod();
        }

        private void testMethod()
        {
            string stmt;
            stmt = "select Leave_Type_Desc from D13_LeaveTypeData_tab";

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

            SqlCommand sqlCommand = new SqlCommand(stmt);

            sqlCommand.Connection = obj.sqlConnection;

            SqlDataReader dataReader;
            dataReader = sqlCommand.ExecuteReader();
            


            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0].ToString());
            }

           

        }
    }
}
