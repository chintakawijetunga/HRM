using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ALSL_HRM_System.DialogBoxes
{
    public partial class dlgSearch : Office2007Form
    {
        
        public SqlDataReader rs = null;
        ALSL_HRM_System.PublicClasses.DBConnection obj=null;
        String SP;

        public dlgSearch(String TitleText, String para1, String para2, String para3, String SP)
        {

            InitializeComponent();
            this.TopMost = true;
            this.styleManager1.ManagerStyle = eStyle.Office2010Blue;
            
            btnSearch.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            this.Text = TitleText;
            
            label1.Text = para1; 
            label2.Text = para2;
            label3.Text = para3;

            if (para3 == "Unused")
            {
                label3.Visible = false;
                textBox3.Visible = false;
            }

            this.SP = SP;

            DBConnectionMethod();

        }

        private void DBConnectionMethod()
        {

            obj = new ALSL_HRM_System.PublicClasses.DBConnection();
            obj.DBConnectionMethod();

        }


        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
            SqlCommand command = new SqlCommand(SP, obj.sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;


            if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                command.Parameters.AddWithValue("@" + label1.Text, DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@" + label1.Text, textBox1.Text.ToString());
            }

            if (string.IsNullOrEmpty(textBox2.Text.ToString()))
            {
                command.Parameters.AddWithValue("@" + label2.Text, DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@" + label2.Text, textBox2.Text.ToString());
            }

            if (string.IsNullOrEmpty(textBox3.Text.ToString()))
            {
                command.Parameters.AddWithValue("@" + label3.Text, DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@" + label3.Text, textBox3.Text.ToString());
            }


            rs = command.ExecuteReader();
            

        }


        


    }
}
