namespace sendMail
{
    partial class FrmSentSMS
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.mtxtDateto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtDateFrom = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTemplateName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmployee.ColumnHeadersHeight = 30;
            this.dgvEmployee.Location = new System.Drawing.Point(4, 55);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.Size = new System.Drawing.Size(1115, 399);
            this.dgvEmployee.TabIndex = 9;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnFilter);
            this.panelHeader.Controls.Add(this.btnShow);
            this.panelHeader.Controls.Add(this.mtxtDateto);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.mtxtDateFrom);
            this.panelHeader.Controls.Add(this.label7);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.cmbTemplateName);
            this.panelHeader.Location = new System.Drawing.Point(3, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1116, 48);
            this.panelHeader.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(834, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(337, 16);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // mtxtDateto
            // 
            this.mtxtDateto.Location = new System.Drawing.Point(728, 14);
            this.mtxtDateto.Mask = "00/00/0000";
            this.mtxtDateto.Name = "mtxtDateto";
            this.mtxtDateto.ReadOnly = true;
            this.mtxtDateto.Size = new System.Drawing.Size(100, 20);
            this.mtxtDateto.TabIndex = 13;
            this.mtxtDateto.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date To";
            // 
            // mtxtDateFrom
            // 
            this.mtxtDateFrom.Location = new System.Drawing.Point(547, 16);
            this.mtxtDateFrom.Mask = "00/00/0000";
            this.mtxtDateFrom.Name = "mtxtDateFrom";
            this.mtxtDateFrom.ReadOnly = true;
            this.mtxtDateFrom.Size = new System.Drawing.Size(100, 20);
            this.mtxtDateFrom.TabIndex = 11;
            this.mtxtDateFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template Name";
            // 
            // cmbTemplateName
            // 
            this.cmbTemplateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplateName.FormattingEnabled = true;
            this.cmbTemplateName.Location = new System.Drawing.Point(108, 15);
            this.cmbTemplateName.Name = "cmbTemplateName";
            this.cmbTemplateName.Size = new System.Drawing.Size(223, 21);
            this.cmbTemplateName.TabIndex = 0;
            // 
            // FrmSentSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 464);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmSentSMS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENT SMS";
            this.Load += new System.EventHandler(this.FrmSentSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.MaskedTextBox mtxtDateto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtDateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTemplateName;
        private System.Windows.Forms.Button btnFilter;
    }
}