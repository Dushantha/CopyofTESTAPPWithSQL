using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TEST_APP_With_SQL.util
{
    class dbConnection
    {

        private string conString = null;

        public SqlConnection getConnection()
        {
            SqlConnection con = null;
          
            try
            {
                conString = "Data Source=HOME-A3B80070D9"+"\\"+"SQLEXPRESS;Initial Catalog=SWFM;Integrated Security=True";
                con = new SqlConnection(conString);
                con.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return con;
        }
    }
}
