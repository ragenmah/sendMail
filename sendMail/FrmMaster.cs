using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendMail
{
    public partial class FrmMaster : Form
    {
        public FrmMaster()
        {
            InitializeComponent();

            //lblWelcome.Text = Global.serverName;
            lblWelcome.Text ="";

        }

        private void templateMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            templateFrm obj = new templateFrm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void FrmMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSendSMS obj = new FrmSendSMS();
            obj.MdiParent = this;
            obj.Show();
        }

        private void aPIConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPIConfig obj = new FrmAPIConfig();
            obj.MdiParent = this;
            obj.Show();
        }

        private void emailMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmail obj = new FrmEmail();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sentSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSentSMS obj = new FrmSentSMS();
            obj.MdiParent = this;
            obj.Show();
        }

        private void emailConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmailConfig obj = new FrmEmailConfig();
            obj.MdiParent = this;
            obj.Show();

        }
    }
}
