using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ALSL_HRM_System.PublicClasses
{
    class DBConnection
    {

        public SqlConnection sqlConnection = null;

        
        public void DBConnectionMethod() 
        {

            String ConnectionString = "Data Source=CHINTHAKALDCW;Initial Catalog=ALSL_HRM_DB;Integrated Security=True; MultipleActiveResultSets=True";
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
        
        }


    }
}
