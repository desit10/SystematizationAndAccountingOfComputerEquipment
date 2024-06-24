namespace SystematizationAndAccountingOfComputerEquipment.Dialogs
{
    partial class DialogCreateReport
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
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.flowLayoutPanelReports = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateReport.ForeColor = System.Drawing.Color.White;
            this.btnCreateReport.Location = new System.Drawing.Point(166, 160);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(304, 31);
            this.btnCreateReport.TabIndex = 13;
            this.btnCreateReport.Text = "Создать отчётность";
            this.btnCreateReport.UseVisualStyleBackColor = false;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // flowLayoutPanelReports
            // 
            this.flowLayoutPanelReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelReports.AutoScroll = true;
            this.flowLayoutPanelReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelReports.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelReports.Name = "flowLayoutPanelReports";
            this.flowLayoutPanelReports.Size = new System.Drawing.Size(458, 142);
            this.flowLayoutPanelReports.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DialogCreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.flowLayoutPanelReports);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogCreateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчётность";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReports;
        private System.Windows.Forms.Button btnClose;
    }
}