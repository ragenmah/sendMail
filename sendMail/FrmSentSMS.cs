using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendMail
{
    public partial class FrmSentSMS : Form
    {
        public FrmSentSMS()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            //var getResponseTest = GetSendSMS("BCIPLbill", "wnxnYDCrAwy87dEgY2FY", "9808086299",  "hello");
            //MessageBox.Show(getResponseTest);
        }

        private static string GetSendSMS(string from, string token, string to, string text)
        {
            using (var client = new WebClient())
            {
                string parameters = "?";
                parameters += "from=" + from;
                parameters += "&to=" + to;
                parameters += "&text=" + text;
                parameters += "&token=" + token;
                var responseString = client.DownloadString("http://api.sparrowsms.com/v2/sms/" + parameters);
                return responseString;
            }
        }

        private void FrmSentSMS_Load(object sender, EventArgs e)
        {

            loadTemplate();
            setDate();
        }
        void loadTemplate()
        {
            DataTable dt = Global.fetchData(" select distinct [TemplateId], [TemplateName] from [dbo].[TemplateSMSmaster]");
            cmbTemplateName.DataSource = dt;
            cmbTemplateName.ValueMember = "TemplateId";
            cmbTemplateName.DisplayMember = "TemplateName";
            cmbTemplateName.SelectedIndex = 0;
        }

        void setDate()
        {
            mtxtDateFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mtxtDateto.Text = DateTime.Now.AddDays(6).ToString();


        }
    }
}
