using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HRM_DBInstallation
{
    

    class DBConnectionBackup
    {

public SqlConnection sqlConnectionfrmSystemUser = null;


        public void DBConnectionMethod(String DBSerever)
        {
            
                String ConnectionString = "Data Source=" + DBSerever + ";Initial Catalog=master;Integrated Security=True";
                sqlConnectionfrmSystemUser = new SqlConnection(ConnectionString);
                sqlConnectionfrmSystemUser.Open();
            
        }
    }
}
