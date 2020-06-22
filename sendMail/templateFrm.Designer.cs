namespace sendMail
{
    partial class templateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(templateFrm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtCreationDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtxtTempMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvTemplate = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTemplateFor = new System.Windows.Forms.ComboBox();
            this.FormattingToolStrip = new System.Windows.Forms.ToolStrip();
            this.FontStyle = new System.Windows.Forms.ToolStripComboBox();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.FontBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.FormattingToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTemplateFor);
            this.groupBox2.Controls.Add(this.cmbFields);
            this.groupBox2.Controls.Add(this.mtxtCreationDate);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTempName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 340);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Template Details";
            // 
            // mtxtCreationDate
            // 
            this.mtxtCreationDate.Location = new System.Drawing.Point(448, 30);
            this.mtxtCreationDate.Mask = "00/00/0000";
            this.mtxtCreationDate.Name = "mtxtCreationDate";
            this.mtxtCreationDate.ReadOnly = true;
            this.mtxtCreationDate.Size = new System.Drawing.Size(100, 20);
            this.mtxtCreationDate.TabIndex = 9;
            this.mtxtCreationDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtTempMessage);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(4, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 249);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your Message";
            // 
            // rtxtTempMessage
            // 
            this.rtxtTempMessage.Location = new System.Drawing.Point(4, 17);
            this.rtxtTempMessage.Name = "rtxtTempMessage";
            this.rtxtTempMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtTempMessage.Size = new System.Drawing.Size(536, 226);
            this.rtxtTempMessage.TabIndex = 1;
            this.rtxtTempMessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Fields";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date";
            // 
            // txtTempName
            // 
            this.txtTempName.Location = new System.Drawing.Point(106, 30);
            this.txtTempName.Name = "txtTempName";
            this.txtTempName.Size = new System.Drawing.Size(273, 20);
            this.txtTempName.TabIndex = 5;
            this.txtTempName.Leave += new System.EventHandler(this.txtTempName_Leave);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(94, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvTemplate
            // 
            this.dgvTemplate.AllowUserToAddRows = false;
            this.dgvTemplate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemplate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTemplate.ColumnHeadersHeight = 30;
            this.dgvTemplate.Location = new System.Drawing.Point(5, 446);
            this.dgvTemplate.Name = "dgvTemplate";
            this.dgvTemplate.ReadOnly = true;
            this.dgvTemplate.RowHeadersVisible = false;
            this.dgvTemplate.Size = new System.Drawing.Size(572, 115);
            this.dgvTemplate.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.FormattingToolStrip);
            this.bodyPanel.Controls.Add(this.groupBox2);
            this.bodyPanel.Location = new System.Drawing.Point(5, 41);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(572, 399);
            this.bodyPanel.TabIndex = 10;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.btnNew);
            this.navPanel.Controls.Add(this.btnEdit);
            this.navPanel.Controls.Add(this.btnDelete);
            this.navPanel.Location = new System.Drawing.Point(5, 6);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(270, 29);
            this.navPanel.TabIndex = 11;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnCancel);
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Location = new System.Drawing.Point(377, 6);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(200, 34);
            this.panelFooter.TabIndex = 12;
            // 
            // cmbFields
            // 
            this.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Items.AddRange(new object[] {
            "FirstName",
            "LastName"});
            this.cmbFields.Location = new System.Drawing.Point(106, 58);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(273, 21);
            this.cmbFields.Sorted = true;
            this.cmbFields.TabIndex = 10;
            this.cmbFields.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Template Name";
            // 
            // cmbTemplateFor
            // 
            this.cmbTemplateFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplateFor.FormattingEnabled = true;
            this.cmbTemplateFor.Items.AddRange(new object[] {
            "EMAIL",
            "SMS"});
            this.cmbTemplateFor.Location = new System.Drawing.Point(448, 60);
            this.cmbTemplateFor.Name = "cmbTemplateFor";
            this.cmbTemplateFor.Size = new System.Drawing.Size(99, 21);
            this.cmbTemplateFor.Sorted = true;
            this.cmbTemplateFor.TabIndex = 10;
            this.cmbTemplateFor.SelectedIndexChanged += new System.EventHandler(this.cmbFields_SelectedIndexChanged);
            // 
            // FormattingToolStrip
            // 
            this.FormattingToolStrip.AutoSize = false;
            this.FormattingToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FormattingToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FormattingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontStyle,
            this.FontSize,
            this.toolStripSeparator1,
            this.Bold,
            this.Italic,
            this.Underline,
            this.toolStripSeparator2,
            this.FontColor,
            this.FontBackgroundColor});
            this.FormattingToolStrip.Location = new System.Drawing.Point(7, 348);
            this.FormattingToolStrip.Name = "FormattingToolStrip";
            this.FormattingToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.FormattingToolStrip.Size = new System.Drawing.Size(428, 37);
            this.FormattingToolStrip.TabIndex = 32;
            // 
            // FontStyle
            // 
            this.FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontStyle.Items.AddRange(new object[] {
            "Arial",
            "Courier New",
            "Times New Roman",
            "Verdana"});
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(170, 37);
            this.FontStyle.ToolTipText = "Font style";
            this.FontStyle.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "18",
            "24",
            "32",
            "36"});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(90, 37);
            this.FontSize.ToolTipText = "Font Size";
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 34);
            this.Bold.ToolTipText = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 34);
            this.Italic.ToolTipText = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 34);
            this.Underline.ToolTipText = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // FontColor
            // 
            this.FontColor.BackColor = System.Drawing.Color.White;
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(23, 34);
            this.FontColor.ToolTipText = "FontColor";
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // FontBackgroundColor
            // 
            this.FontBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBackgroundColor.Name = "FontBackgroundColor";
            this.FontBackgroundColor.Size = new System.Drawing.Size(23, 34);
            this.FontBackgroundColor.ToolTipText = "Font Background Color";
            this.FontBackgroundColor.Click += new System.EventHandler(this.FontBackgroundColor_Click);
            // 
            // templateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 564);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.dgvTemplate);
            this.Controls.Add(this.bodyPanel);
            this.MaximizeBox = false;
            this.Name = "templateFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAKE A SMS TEMPLATE";
            this.Load += new System.EventHandler(this.templateFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplate)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.FormattingToolStrip.ResumeLayout(false);
            this.FormattingToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtxtTempMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempName;
        private System.Windows.Forms.MaskedTextBox mtxtCreationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvTemplate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTemplateFor;
        private System.Windows.Forms.ToolStrip FormattingToolStrip;
        private System.Windows.Forms.ToolStripComboBox FontStyle;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton FontColor;
        private System.Windows.Forms.ToolStripButton FontBackgroundColor;
    }
}