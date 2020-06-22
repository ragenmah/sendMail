using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class FrmSendSMS : Form
    {
        public FrmSendSMS()
        {
            InitializeComponent();
        }

        private void FrmSendSMS_Load(object sender, EventArgs e)
        {
            loadTemplate();
            setDate();
        }
        void loadTemplate() {
            DataTable dt = Global.fetchData(" select distinct [TemplateId], [TemplateName] from [dbo].[TemplateSMSmaster]");
            cmbTemplateName.DataSource = dt;
            cmbTemplateName.ValueMember = "TemplateId";
            cmbTemplateName.DisplayMember = "TemplateName";
            cmbTemplateName.SelectedIndex = 0;
        }

        void setDate() {
            mtxtDateFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mtxtDateto.Text = DateTime.Now.AddDays(6).ToString();


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count>0)
            {
                dgvEmployee.Columns.Clear();
            }
            String FirstName="Ragen";
            String LastName = "";
            DataTable dtEmp = Global.fetchData("select * from  EmployeeMaster");

            //foreach (DataRow row in dtEmp.Rows)
            //{
            //     FirstName = row["FirstName"].ToString();
            //     LastName = row["LastName"].ToString();
            //    //string icoFileName = row["iconFile"].ToString();
            //    //string installScript = row["installScript"].ToString();
            //}
            DataTable dt = Global.fetchData($@"select em.EmployeeId,(Title+' '+FirstName+' '+LastName)as [Employee Name],
                                            epa.MobileNo as[Mobile],dm.DepartmentDesc,rm.RoleDesc
                                              from EmployeeMaster em left outer join DepartmentMaster dm on dm.DepartmentID=em.DepartmentID left outer join RoleMaster rm on rm.RoleId=em.RoleId left outer join  EmployeePerAdd epa on em.EmployeeId=epa.EmployeeId ");
            dt.Columns.Add("SMS TEXT", typeof(System.String));

            DataTable dtTemp = Global.fetchData(@"select TemplateMsg from TemplateSMSmaster where Templateid='" + cmbTemplateName.SelectedValue + "'");

            String smsText = "";
            if (dtTemp.Rows.Count>0)
            {
                smsText = dtTemp.Rows[0]["TemplateMsg"].ToString();
                //rtxtTempMessage.Text = smsText;
            }
            int i = 0;
            foreach (DataRow row in dtEmp.Rows)
            {
                FirstName = row["FirstName"].ToString();
                LastName = row["LastName"].ToString();
                //string icoFileName = row["iconFile"].ToString();
                //string installScript = row["installScript"].ToString();
                foreach (DataRow rows in dt.Rows)
                {
                    StringBuilder sms = new StringBuilder(@smsText);
                    sms.Replace("{FirstName}", FirstName);
                    sms.Replace("{MidName}", FirstName);
                    sms.Replace("{LastName}", LastName);
                    dt.Rows[i]["SMS TEXT"] = sms.ToString();

                    //rows["SMS TEXT"] = sms.ToString();
                    //row["SMS TEXT"] = $@""+ sms.ToString() + "";   
                }
                i++;
            }
           
            //rtxtTempMessage.Text = rtxtTempMessage.Text + $@"";
           //dt.Rows.Add("", "", "", "", $@"HELLO {FirstName}Dear {LastName}            ");
            dgvEmployee.DataSource = dt;
            dgvEmployee.ReadOnly = false;
             DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvEmployee.Columns.Add(chk);
            chk.HeaderText = "Tag";
            chk.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployee.Columns[dgvEmployee.Columns.Count-1].ReadOnly = false;
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string responseTest = "";
            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvEmployee.Rows[i].Cells[6].Value)==true)
                {
                    //responseTest = PostSendSMS("BCIPLbill", "wnxnYDCrAwy87dEgY2FY", "9808086299", "Hello");
                    //responseTest = PostSendSMS("BCIPLbill", "wnxnYDCrAwy87dEgY2FY", dgvEmployee.Rows[i].Cells["Mobile"].Value.ToString(), dgvEmployee.Rows[i].Cells["SMS TEXT"].Value.ToString(), "");
                    saveToDb();
                }
            }

            MessageBox.Show(responseTest);

        }


        private static string PostSendSMS(string from, string token, string to, string text,string url)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var values = new NameValueCollection();
                    values["from"] = from;
                    values["token"] = token;
                    values["to"] = to;
                    values["text"] = text;
                    var response = client.UploadValues("http://api.sparrowsms.com/v2/sms/", "Post", values);
                    var responseString = Encoding.Default.GetString(response);
                    return responseString;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Message send error");
                }
                return "";
            }
        }
        void saveToDb()
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {

            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <dgvEmployee.Rows.Count; i++)
            {
                dgvEmployee.Rows[i].Cells[6].Value = true;
            }
        }

        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                dgvEmployee.Rows[i].Cells[6].Value = false;
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvEmployee.Rows[i].Cells[6].Value)==true)
                {
                    dgvEmployee.Rows[i].Cells[6].Value = false;
                }
                else
                {
                    dgvEmployee.Rows[i].Cells[6].Value = true;
                }
                
            }
        }
        
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            try
            {
                var getResponseTest = GetCredits("wnxnYDCrAwy87dEgY2FY");
                Console.WriteLine(getResponseTest);
                //   MessageBox.Show(getResponseTest);
                string balance = "";


                JObject apiSearch = JObject.Parse(@getResponseTest);
                if (apiSearch != null)
                {
                    balance = @"Balance : \n credits availble :" + apiSearch["credits_available"].ToString() + "\n credits consumed :" + apiSearch["credits_consumed"] + "\n last balance added :" + apiSearch["last_balance_added"] + "\n minimum credit :" + apiSearch["minimum_credit"] + "\n";

                }

                // get JSON result objects into a list
                //IList<JToken> results = apiSearch.Children().ToList();

                //// serialize JSON results into .NET objects
                //IList<SearchResult> searchResults = new List<SearchResult>();
                //foreach (JToken result in results)
                //{
                //    balance = @"Balance : \n credits availble :" + apiSearch["credits_available"].ToString() + "\n credits consumed :" + apiSearch["credits_consumed"] + "\n last balance added :" + apiSearch["last_balance_added"] + "\n minimum credit :" + apiSearch["minimum_credit"] + "\n";

                //    //SearchResult searchResult = JsonConvert.DeserializeObject<SearchResult>(result.ToString());
                //    //searchResults.Add(searchResult);
                //}



                //foreach (SearchResult item in searchResults)
                //{
                //    //Console.WriteLine(item.credits_available);
                //    //Console.WriteLine(item.credits_consumed);
                //    //Console.WriteLine(item.last_balance_added);
                //    //Console.WriteLine(item.minimum_credit);
                //    //Console.WriteLine(item.response_code);
                //    balance = @"Balance \n credits availble :" + item.credits_available + "\n credits consumed :" + item.credits_consumed + "\n last balance added :" + item.last_balance_added + "\n minimum credit :" + item.minimum_credit + "\n";

                //}
                MessageBox.Show(balance, "Balance Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Balance Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


        }

        private static string GetCredits(string token)
        {
            using (var client = new WebClient())
            {
                string parameters = "?";
                parameters += "token=" + token;
                var responseString = client.DownloadString("http://api.sparrowsms.com/v2/credit/" + parameters);
                return responseString;
            }
        }
    }
}
public class SearchResult
{
    public int credits_available { get; set; }
    public int credits_consumed { get; set; }
    public int last_balance_added { get; set; }

    public int minimum_credit { get; set; }
    public int response_code { get; set; }
}