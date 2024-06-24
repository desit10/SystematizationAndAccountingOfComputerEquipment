namespace SystematizationAndAccountingOfComputerEquipment
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAppointments = new System.Windows.Forms.Button();
            this.btnShowEquipments = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.comboBoxTypeEquipment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLocations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelComboBoxs = new System.Windows.Forms.Panel();
            this.panelComboBoxs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 139);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 41);
            this.btnReport.TabIndex = 81;
            this.btnReport.Text = "Отчётность";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.Location = new System.Drawing.Point(11, 609);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(144, 41);
            this.btnUpdateData.TabIndex = 83;
            this.btnUpdateData.Text = "Обновить";
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(11, 656);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 41);
            this.btnExit.TabIndex = 84;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnCreateAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateAppointment.ForeColor = System.Drawing.Color.White;
            this.btnCreateAppointment.Location = new System.Drawing.Point(11, 17);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(144, 55);
            this.btnCreateAppointment.TabIndex = 80;
            this.btnCreateAppointment.Text = "Назначить оборудование";
            this.btnCreateAppointment.UseVisualStyleBackColor = false;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Location = new System.Drawing.Point(161, 67);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1310, 630);
            this.flowLayoutPanel.TabIndex = 82;
            // 
            // btnShowAppointments
            // 
            this.btnShowAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnShowAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAppointments.ForeColor = System.Drawing.Color.White;
            this.btnShowAppointments.Location = new System.Drawing.Point(11, 500);
            this.btnShowAppointments.Name = "btnShowAppointments";
            this.btnShowAppointments.Size = new System.Drawing.Size(144, 55);
            this.btnShowAppointments.TabIndex = 85;
            this.btnShowAppointments.Text = "Назначенное оборудование";
            this.btnShowAppointments.UseVisualStyleBackColor = false;
            this.btnShowAppointments.Click += new System.EventHandler(this.btnShowAppointments_Click);
            // 
            // btnShowEquipments
            // 
            this.btnShowEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowEquipments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnShowEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowEquipments.ForeColor = System.Drawing.Color.White;
            this.btnShowEquipments.Location = new System.Drawing.Point(11, 562);
            this.btnShowEquipments.Name = "btnShowEquipments";
            this.btnShowEquipments.Size = new System.Drawing.Size(144, 41);
            this.btnShowEquipments.TabIndex = 86;
            this.btnShowEquipments.Text = "Всё оборудование";
            this.btnShowEquipments.UseVisualStyleBackColor = false;
            this.btnShowEquipments.Click += new System.EventHandler(this.btnShowEquipments_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEquipment.ForeColor = System.Drawing.Color.White;
            this.btnAddEquipment.Location = new System.Drawing.Point(11, 78);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(144, 55);
            this.btnAddEquipment.TabIndex = 87;
            this.btnAddEquipment.Text = "Добавить оборудование";
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // comboBoxTypeEquipment
            // 
            this.comboBoxTypeEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeEquipment.FormattingEnabled = true;
            this.comboBoxTypeEquipment.Items.AddRange(new object[] {
            "Без фильтра"});
            this.comboBoxTypeEquipment.Location = new System.Drawing.Point(0, 28);
            this.comboBoxTypeEquipment.Name = "comboBoxTypeEquipment";
            this.comboBoxTypeEquipment.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTypeEquipment.TabIndex = 83;
            this.comboBoxTypeEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEquipment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Местонахождение";
            // 
            // comboBoxLocations
            // 
            this.comboBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocations.FormattingEnabled = true;
            this.comboBoxLocations.Items.AddRange(new object[] {
            "Без фильтра"});
            this.comboBoxLocations.Location = new System.Drawing.Point(206, 28);
            this.comboBoxLocations.Name = "comboBoxLocations";
            this.comboBoxLocations.Size = new System.Drawing.Size(200, 24);
            this.comboBoxLocations.TabIndex = 81;
            this.comboBoxLocations.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocations_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(-3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Тип оборудования";
            // 
            // comboBoxEquipmentStatus
            // 
            this.comboBoxEquipmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipmentStatus.FormattingEnabled = true;
            this.comboBoxEquipmentStatus.Items.AddRange(new object[] {
            "Без фильтра"});
            this.comboBoxEquipmentStatus.Location = new System.Drawing.Point(412, 28);
            this.comboBoxEquipmentStatus.Name = "comboBoxEquipmentStatus";
            this.comboBoxEquipmentStatus.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEquipmentStatus.TabIndex = 85;
            this.comboBoxEquipmentStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipmentStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(409, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Статус оборудования";
            // 
            // panelComboBoxs
            // 
            this.panelComboBoxs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelComboBoxs.Controls.Add(this.label4);
            this.panelComboBoxs.Controls.Add(this.comboBoxEquipmentStatus);
            this.panelComboBoxs.Controls.Add(this.label3);
            this.panelComboBoxs.Controls.Add(this.comboBoxLocations);
            this.panelComboBoxs.Controls.Add(this.label2);
            this.panelComboBoxs.Controls.Add(this.comboBoxTypeEquipment);
            this.panelComboBoxs.Location = new System.Drawing.Point(161, 6);
            this.panelComboBoxs.Name = "panelComboBoxs";
            this.panelComboBoxs.Size = new System.Drawing.Size(1310, 62);
            this.panelComboBoxs.TabIndex = 79;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnShowEquipments);
            this.Controls.Add(this.btnShowAppointments);
            this.Controls.Add(this.panelComboBoxs);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет оборудования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.panelComboBoxs.ResumeLayout(false);
            this.panelComboBoxs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.Button btnShowEquipments;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.ComboBox comboBoxTypeEquipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLocations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEquipmentStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelComboBoxs;
    }
}

