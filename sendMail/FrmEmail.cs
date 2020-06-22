using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendMail
{
    public partial class FrmEmail : Form
    {
        OpenFileDialog ofdAttachment;
        String fileName = "";
        public FrmEmail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please make the sender mail account settings change. \n Go to myaccount.google.com log in with your mail and search for less secure aoo access and enable it", "Information for greater mail service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void SendEmail()
        {
            try
            {
                
                string fromAddress = txtSenderEmail.Text;
                string toAddress = txtRecipientEmail.Text;
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(fromAddress, toAddress);

                message.Subject = txtSubject.Text;
                message.Body = ""+rtbBody.Text.Trim()+"";
                
                //message.IsBodyHtml = true;
                message.IsBodyHtml = cbxHtmlBody.Checked;
                
                message.Priority = System.Net.Mail.MailPriority.High;



                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(txtSmtpServer.Text, Convert.ToInt32(txtPortNumber.Text));

                client.EnableSsl = cbxSSL.Checked;

                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(fromAddress, txtSenderPassword.Text.Trim());
                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    message.Attachments.Add(attachment);
                }
                client.Send(message);


                MessageBox.Show("Your mail has been sent.","Message sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //using (MailMessage mail = new MailMessage())
                //{
                //    mail.From = new MailAddress("Ragenmah99@gmail.com");
                //    mail.To.Add("Ragenmah99@gmail.com");
                //    mail.Subject = "Hello World";
                //    mail.Body = "<h1>Hello</h1>";
                //    mail.IsBodyHtml = true;
                //    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                //    {
                //        smtp.Credentials = new NetworkCredential("Ragenmah99@gmail.com", "");
                //        smtp.EnableSsl = true;
                //        smtp.Send(mail);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mail Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            SendEmail();
        }

        private void txtPortNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (comboBox1.Text)
            {
                case "google":
                    txtSmtpServer.Text = "smtp.gmail.com";
                    txtPortNumber.Text = "587";
                    cbxSSL.Checked = true;
                    return;
                case "yahoo":
                    txtSmtpServer.Text = "smtp.mail.yahoo.com";
                    txtPortNumber.Text = "587";
                    cbxSSL.Checked = true;
                    return;
                default:
                    break;
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
                lblFileLoc.Text = fileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var responseTest = PostSendSMS("BCIPLbill", "wnxnYDCrAwy87dEgY2FY", "9808086299", "Hello");
            MessageBox.Show(responseTest);

        }

        private static string PostSendSMS(string from, string token, string to, string text)
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
                    MessageBox.Show(e.ToString(),"Message send error");
                }
                return "";
            }
        }
    }
}
