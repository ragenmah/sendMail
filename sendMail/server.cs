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

namespace sendMail
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Data Source='"+cmbServer.Text+"';Initial Catalog='"+txtDatabaseName.Text+"';User ID="+txtUserName.Text+";Password="+txtPass.Text+"";
            sql = "select * from employeemaster";


            connection = new SqlConnection(connetionString);
            try
            {
                //connection.Open();
                //command = new SqlCommand(sql, connection);
                //command.ExecuteNonQuery();
                //command.Dispose();
                //connection.Close();
                SqlHelper helper = new SqlHelper(connetionString);
                if (helper.isConnection)
                {
                    Global.serverName = cmbServer.Text;
                    Global.dbName = txtDatabaseName.Text;
                    Global.userName = txtUserName.Text;
                    Global.password = txtPass.Text;
                    this.Hide();
                    FrmMaster master = new FrmMaster();

                    master.ShowDialog();

                }
                //MessageBox.Show(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Can not open connection ! ");
            }
        }

        private void server_Load(object sender, EventArgs e)
        {
            //cmbServer.Items.Add(".");
            //cmbServer.Items.Add("(local)");
            //cmbServer.Items.Add(@".\Sql14");
            //cmbServer.Items.Add(String.Format(@"{0}\sql14", Environment.MachineName));
            cmbServer.SelectedIndex = 0;
        }
    }
}
