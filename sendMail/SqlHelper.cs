using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sendMail
{
    class SqlHelper
    {
        static string conString = "Data Source='" + Global.serverName + "';Initial Catalog='" + Global.dbName + "';User ID=" + Global.userName + ";Password=" + Global.password + "";
        public static string connString()
        {
            return conString;
        }

        SqlConnection cn;
        public SqlHelper()
        {
            cn = new SqlConnection(conString);
        }
        public SqlHelper(string connectionString)
        {
            cn = new SqlConnection(connectionString);
        }

       
        public SqlConnection sqlconnector()
        {
            return cn = new SqlConnection(conString);

        }
        public bool isConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}
