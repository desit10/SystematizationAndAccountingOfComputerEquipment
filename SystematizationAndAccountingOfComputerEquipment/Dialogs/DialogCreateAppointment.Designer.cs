namespace SystematizationAndAccountingOfComputerEquipment.Dialogs
{
    partial class DialogCreateAppointment
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEquipments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypesEquipment = new System.Windows.Forms.ComboBox();
            this.btnCreateAppointments = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Сотрудник";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(12, 81);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEmployees.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Тип оборудования";
            // 
            // comboBoxEquipments
            // 
            this.comboBoxEquipments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipments.FormattingEnabled = true;
            this.comboBoxEquipments.Location = new System.Drawing.Point(221, 31);
            this.comboBoxEquipments.Name = "comboBoxEquipments";
            this.comboBoxEquipments.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEquipments.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Оборудование";
            // 
            // comboBoxTypesEquipment
            // 
            this.comboBoxTypesEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTypesEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypesEquipment.FormattingEnabled = true;
            this.comboBoxTypesEquipment.Location = new System.Drawing.Point(12, 31);
            this.comboBoxTypesEquipment.Name = "comboBoxTypesEquipment";
            this.comboBoxTypesEquipment.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTypesEquipment.TabIndex = 89;
            this.comboBoxTypesEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypesEquipment_SelectedIndexChanged);
            // 
            // btnCreateAppointments
            // 
            this.btnCreateAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCreateAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAppointments.ForeColor = System.Drawing.Color.White;
            this.btnCreateAppointments.Location = new System.Drawing.Point(165, 112);
            this.btnCreateAppointments.Name = "btnCreateAppointments";
            this.btnCreateAppointments.Size = new System.Drawing.Size(255, 29);
            this.btnCreateAppointments.TabIndex = 95;
            this.btnCreateAppointments.Text = "Назначить";
            this.btnCreateAppointments.UseVisualStyleBackColor = false;
            this.btnCreateAppointments.Click += new System.EventHandler(this.btnCreateAppointments_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 29);
            this.btnClose.TabIndex = 96;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DialogCreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 153);
            this.Controls.Add(this.btnCreateAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEquipments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTypesEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogCreateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Назначение оборудования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEquipments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypesEquipment;
        private System.Windows.Forms.Button btnCreateAppointments;
        private System.Windows.Forms.Button btnClose;
    }
}