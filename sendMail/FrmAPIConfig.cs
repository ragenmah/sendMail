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
    public partial class FrmAPIConfig : Form
    {
        string connetionString = "Data Source='" + Global.serverName + "';Initial Catalog='" + Global.dbName + "';User ID=" + Global.userName + ";Password=" + Global.password + "";

        SqlConnection connection;
        SqlCommand command;
        string sql = null;
        String ApiConfigId = "Auto";
        public FrmAPIConfig()
        {
            InitializeComponent();
        }

        private void FrmAPIConfig_Load(object sender, EventArgs e)
        {
            cmbVendorName.SelectedIndex = 0;
            txtURLLink.Text = "http://api.sparrowsms.com/v2/sms/";
            txtIdentity.Text = "BCIPLbill";
            txtToken.Text = "wnxnYDCrAwy87dEgY2FY";
            loadSMSApiOnfig();
        }

        void loadSMSApiOnfig() {
            DataTable dt = Global.fetchData(@"select   [ClientID] as [Token]
      ,[UserName] as [Identity],[Password] ,[URLLink] as[URL Link]
  FROM[PAY10001].[dbo].[SmsApiConfig]");
            //if (dt.Rows.Count>0)
            //{
                dgvSMSApi.DataSource = dt;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Global.fetchData("select * from [dbo].[SmsApiConfig] where ClientID='" + txtToken.Text+"' ").Rows.Count>0);
            {
                MessageBox.Show("API with same Token have Already been saved.\nPlease try with another token", "HiTech Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
             //   txtToken.Focus();
                return;
            }

            using (connection = new SqlConnection(connetionString))
            {
                try
                {
                    connection.Open();
                    //command = new SqlCommand(sql, connection);

                    sql=@"insert into [dbo].[SmsApiConfig]
           ([VendorName]
           ,[ClientID]
           ,[UserName]
           ,[Password]
           ,[URLLink])
     VALUES
           (@VendorName,
           @ClientID,
           @UserName,
           @Password,
           @URLLink)";
                    //command.ExecuteNonQuery();
                    //command.Dispose();
                    //connection.Close();
                    command = new SqlCommand(sql, connection);
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@VendorName", cmbVendorName.Text);
                    command.Parameters.AddWithValue("@ClientID", txtToken.Text);
                    command.Parameters.AddWithValue("@UserName", txtIdentity.Text);
                    command.Parameters.AddWithValue("@Password", String.Empty);
                    command.Parameters.AddWithValue("@URLLink", txtURLLink.Text.Trim());
                  
                    int numRes = command.ExecuteNonQuery();

                    if (numRes > 0)
                    {
                        MessageBox.Show("Your API Configuration has been saved successfully.", "HiTech Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClearAllData();
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }


                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "HiTech PayRoll - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            loadSMSApiOnfig();
        }
    }
}
