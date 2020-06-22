namespace sendMail
{
    partial class FrmMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.sMSToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateMasterToolStripMenuItem,
            this.emailMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "&Master";
            // 
            // templateMasterToolStripMenuItem
            // 
            this.templateMasterToolStripMenuItem.Name = "templateMasterToolStripMenuItem";
            this.templateMasterToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.templateMasterToolStripMenuItem.Text = "&Template Master";
            this.templateMasterToolStripMenuItem.Click += new System.EventHandler(this.templateMasterToolStripMenuItem_Click);
            // 
            // emailMasterToolStripMenuItem
            // 
            this.emailMasterToolStripMenuItem.Name = "emailMasterToolStripMenuItem";
            this.emailMasterToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.emailMasterToolStripMenuItem.Text = "&Email Master";
            this.emailMasterToolStripMenuItem.Click += new System.EventHandler(this.emailMasterToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendSMSToolStripMenuItem,
            this.sentSMSToolStripMenuItem});
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sMSToolStripMenuItem.Text = "&SMS";
            // 
            // sendSMSToolStripMenuItem
            // 
            this.sendSMSToolStripMenuItem.Name = "sendSMSToolStripMenuItem";
            this.sendSMSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sendSMSToolStripMenuItem.Text = "Send SMS";
            this.sendSMSToolStripMenuItem.Click += new System.EventHandler(this.sendSMSToolStripMenuItem_Click);
            // 
            // sentSMSToolStripMenuItem
            // 
            this.sentSMSToolStripMenuItem.Name = "sentSMSToolStripMenuItem";
            this.sentSMSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sentSMSToolStripMenuItem.Text = "Sent SMS";
            this.sentSMSToolStripMenuItem.Click += new System.EventHandler(this.sentSMSToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIConfigToolStripMenuItem,
            this.emailConfigToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // aPIConfigToolStripMenuItem
            // 
            this.aPIConfigToolStripMenuItem.Name = "aPIConfigToolStripMenuItem";
            this.aPIConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aPIConfigToolStripMenuItem.Text = "API &Config";
            this.aPIConfigToolStripMenuItem.Click += new System.EventHandler(this.aPIConfigToolStripMenuItem_Click);
            // 
            // emailConfigToolStripMenuItem
            // 
            this.emailConfigToolStripMenuItem.Name = "emailConfigToolStripMenuItem";
            this.emailConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailConfigToolStripMenuItem.Text = "&Email Config";
            this.emailConfigToolStripMenuItem.Click += new System.EventHandler(this.emailConfigToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(311, 104);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(55, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "WelCOme";
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 377);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMaster";
            this.ShowIcon = false;
            this.Text = "SMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMaster_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentSMSToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem emailMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailConfigToolStripMenuItem;
    }
}