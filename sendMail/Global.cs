using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sendMail
{
    class Global
    {
        //private static string sserverName = "";
        SqlHelper sql = new SqlHelper();
      
       
        public static string serverName {
            get;
            set;
        }
        public static string dbName
        {
            get;
            set;
        }
        public static string userName
        {
            get;
            set;
        }
        public static string password
        {
            get;
            set;
        }

        public static DataTable  fetchData(String sql) {
            string conString = "Data Source='" + Global.serverName + "';Initial Catalog='" + Global.dbName + "';User ID=" + Global.userName + ";Password=" + Global.password + "";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conString)) {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {

                        sda.Fill(dt);


                    }
                }
            }
            
            return dt;

        }

    }
}
