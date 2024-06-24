namespace SystematizationAndAccountingOfComputerEquipment.Controls
{
    partial class ControlAppointment
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelManufacture = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelSelectEmployee = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип оборудования";
            // 
            // labelType
            // 
            this.labelType.AutoEllipsis = true;
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(3, 16);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(130, 16);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Тип оборудования";
            // 
            // labelModel
            // 
            this.labelModel.AutoEllipsis = true;
            this.labelModel.AutoSize = true;
            this.labelModel.ForeColor = System.Drawing.Color.White;
            this.labelModel.Location = new System.Drawing.Point(3, 264);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 16);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(3, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Модель";
            // 
            // labelManufacture
            // 
            this.labelManufacture.AutoEllipsis = true;
            this.labelManufacture.AutoSize = true;
            this.labelManufacture.ForeColor = System.Drawing.Color.White;
            this.labelManufacture.Location = new System.Drawing.Point(3, 232);
            this.labelManufacture.Name = "labelManufacture";
            this.labelManufacture.Size = new System.Drawing.Size(111, 16);
            this.labelManufacture.TabIndex = 6;
            this.labelManufacture.Text = "Производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Производитель";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 36);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(175, 175);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(389, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelSelectEmployee
            // 
            this.labelSelectEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectEmployee.AutoSize = true;
            this.labelSelectEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.labelSelectEmployee.Location = new System.Drawing.Point(190, 6);
            this.labelSelectEmployee.Name = "labelSelectEmployee";
            this.labelSelectEmployee.Size = new System.Drawing.Size(173, 16);
            this.labelSelectEmployee.TabIndex = 24;
            this.labelSelectEmployee.Text = "Назначенный сотрудник:";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(372, 3);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(225, 24);
            this.comboBoxEmployees.TabIndex = 23;
            this.comboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployees_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.labelStatus.Location = new System.Drawing.Point(190, 36);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(154, 16);
            this.labelStatus.TabIndex = 26;
            this.labelStatus.Text = "Статус оборудования:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(372, 33);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(225, 24);
            this.comboBoxStatus.TabIndex = 25;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // ControlAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelSelectEmployee);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelManufacture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label1);
            this.Name = "ControlAppointment";
            this.Size = new System.Drawing.Size(600, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelManufacture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelSelectEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
