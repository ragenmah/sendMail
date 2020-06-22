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
    public partial class templateFrm : Form
    {
        string connetionString = "Data Source='" + Global.serverName + "';Initial Catalog='" + Global.dbName + "';User ID=" + Global.userName + ";Password=" + Global.password + "";

        SqlConnection connection;
        SqlCommand command;
        string sql = null;
        String TemplateID = "Auto";

        public templateFrm()
        {
            InitializeComponent();
        }

        private void templateFrm_Load(object sender, EventArgs e)
        {
            mtxtCreationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            ControlMode(true, false);
            FontStyle.SelectedItem = "Arial";
            FontSize.SelectedItem = "10";
            loadTemplate();
            btnNew.Focus();
            cmbTemplateFor.SelectedItem="SMS";
            cmbFields.SelectedIndex = 0;
            rtxtTempMessage.Text="";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Tag = "New";
            ControlMode(false, true);
            // txtTempName.Focus();
        }

        void ControlMode(bool nav, bool detail)
        {
            navPanel.Enabled = nav;
            bodyPanel.Enabled = detail;
            panelFooter.Enabled = detail;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControlMode(true, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Tag = "Edit";
            ControlMode(false, true);
            txtTempName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Tag = "Delete";
            ControlMode(false, true);
            txtTempName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = Global.fetchData(@"Select * from dbo.TemplateSMSmaster where TemplateName='" + txtTempName.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The Template already exists ", "HiTech PayRoll - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempName.Focus();
            }
            else if (this.Tag == "New" || this.Tag == "Edit")
            {
                //string templateId=
                //SqlHelper con = new SqlHelper();
                //          sql = @"INSERT INTO [dbo].[TemplateSMS]
                //      ([TemplateId]
                //      ,[TemplateType]
                //      ,[TemplateName]
                //      ,[TemplateMsg]
                //      ,[creationDate])
                //VALUES
                //      ()";


                using (connection = new SqlConnection(connetionString))
                {
                    try
                    {
                        connection.Open();
                        //command = new SqlCommand(sql, connection);

                        DateTime createdDate = Convert.ToDateTime(Convert.ToDateTime(mtxtCreationDate.Text).ToString("dd/MM/yyyy HH:mm tt"));
                        var createdTime = DateTime.Now.TimeOfDay;
                        //command.ExecuteNonQuery();
                        //command.Dispose();
                        //connection.Close();
                        command = new SqlCommand("[MASTER].[SP_TranTemplateSMSMaster]", connection);
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TranType", this.Tag == "New" ? "Insert" : "Update");
                        command.Parameters.AddWithValue("@TemplateId", TemplateID);
                        command.Parameters.AddWithValue("@TemplateType", String.Empty);
                        command.Parameters.AddWithValue("@TemplateName", txtTempName.Text);
                        command.Parameters.AddWithValue("@TemplateMsg", rtxtTempMessage.Text);
                        command.Parameters.AddWithValue("@creationDate", createdDate);
                        command.Parameters.AddWithValue("@updateDate", DateTime.Now);
                        command.Parameters.AddWithValue("@OutMsg", String.Empty);

                        int numRes = command.ExecuteNonQuery();

                        if (numRes > 0)
                        {
                            MessageBox.Show("Your Template has been saved successfully.", "HiTech Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            loadTemplate();
        }
        void loadTemplate()
        {
            DataTable dt = Global.fetchData(@"Select [TemplateName]
           ,[TemplateMsg]
           ,[creationDate] as[Creation Date],updateDate as [Update Date] from dbo.TemplateSMSmaster ");
            dgvTemplate.DataSource = dt;
        }

        private void txtTempName_Leave(object sender, EventArgs e)
        {
            DataTable dt = Global.fetchData(@"Select * from dbo.TemplateSMSmaster where TemplateName='" + txtTempName.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The Template already exists ", "HiTech PayRoll - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempName.Focus();
            }

        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtTempMessage.Text = rtxtTempMessage.Text + "{" + cmbFields.Text + "}";
        }

        private void FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }
        private void SetSelectionFont()
        {


            try
            {
                System.Drawing.FontStyle style = System.Drawing.FontStyle.Regular;

                bool bold = ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked;
                bool italic = ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked;
                bool underline = ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked;
                if (bold)
                {
                    style |= System.Drawing.FontStyle.Bold;
                }
                if (italic)
                {
                    style |= System.Drawing.FontStyle.Italic;
                }
                if (underline)
                {
                    style |= System.Drawing.FontStyle.Underline;
                }
                Single styleSingle = 1;
                if (!string.IsNullOrEmpty(this.FormattingToolStrip.Items[1].Text))
                    styleSingle = Convert.ToSingle(((ToolStripComboBox)this.FormattingToolStrip.Items[1]).Text);
                string fontFamily = ((ToolStripComboBox)this.FormattingToolStrip.Items[0]).Text;
                rtxtTempMessage.SelectionFont = new Font(fontFamily, styleSingle, style);
                this.rtxtTempMessage.Focus();
            }
            catch (Exception e)
            {

            }

        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.rtxtTempMessage.SelectionColor = dialog.Color;
                // ((ToolStripButton)this.FormattingToolStrip.Items[7]).Image = CreateFontColorIcon(dialog.Color);
                ((ToolStripButton)this.FormattingToolStrip.Items[7]).BackColor = dialog.Color;
            }
        }

        private void FontBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.rtxtTempMessage.SelectionBackColor = dialog.Color;
                // ((ToolStripButton)this.FormattingToolStrip.Items[8]).Image = CreateFontBackColorIcon(dialog.Color);
                ((ToolStripButton)this.FormattingToolStrip.Items[8]).BackColor = dialog.Color;
            }
        }
    }
}
