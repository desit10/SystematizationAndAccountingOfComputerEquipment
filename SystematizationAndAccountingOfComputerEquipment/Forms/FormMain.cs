using Npgsql;
using System;
using System.Windows.Forms;
using SystematizationAndAccountingOfComputerEquipment.Classes;
using SystematizationAndAccountingOfComputerEquipment.Forms;
using SystematizationAndAccountingOfComputerEquipment.Dialogs;
using SystematizationAndAccountingOfComputerEquipment.Controls;

namespace SystematizationAndAccountingOfComputerEquipment
{
    public partial class FormMain : Form
    {
        DataBase db = new DataBase();
        bool isAppointment = false;
        string cmd = "";

        public FormMain(int idUser)
        {
            InitializeComponent();

            db.loadItemComboBox(comboBoxTypeEquipment, "types_equipment");
            db.loadItemComboBox(comboBoxLocations, "locations");
            db.loadItemComboBox(comboBoxEquipmentStatus, "status");
                       
            comboBoxTypeEquipment.SelectedIndex = 0;
            comboBoxLocations.SelectedIndex = 0;
            comboBoxEquipmentStatus.SelectedIndex = 0;

            cmd = "SELECT * FROM equipments ORDER BY id ASC";
            loadData(cmd, isAppointment);
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            DialogCreateAppointment dialogCreateAppointment = new DialogCreateAppointment();

            if (dialogCreateAppointment.ShowDialog() == DialogResult.OK)
            {
                if(isAppointment == true)
                {
                    flowLayoutPanel.Controls.Clear();

                    loadData(cmd, isAppointment);
                }
                
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            DialogAddEquipment dialogAddEquipment = new DialogAddEquipment();

            if (dialogAddEquipment.ShowDialog() == DialogResult.OK)
            {
                flowLayoutPanel.Controls.Clear();

                loadData(cmd, isAppointment);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DialogCreateReport dialogCreateReport = new DialogCreateReport();
            dialogCreateReport.ShowDialog();
        }

        private void btnShowEquipments_Click(object sender, EventArgs e)
        {
            isAppointment = false;
            cmd = $"SELECT * FROM equipments ORDER BY id ASC";
            loadData(cmd, isAppointment);
        }

        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            isAppointment = true;
            cmd = $"SELECT * FROM appointments ORDER BY id ASC";
            loadData(cmd, isAppointment);
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();

            loadData(cmd, isAppointment);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTypeEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (comboBoxEquipmentStatus.SelectedIndex != 0)
            {
                loadData(cmd + $" WHERE id_type = {comboBoxTypeEquipment.SelectedIndex}", isAppointment);
            }
            else
            {
                loadData(cmd, isAppointment);
            }*/
        }

        private void comboBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBoxEquipmentStatus.SelectedIndex != 0)
            {
                loadData(cmd + $" WHERE id_location = {comboBoxLocations.SelectedIndex}", isAppointment);
            }
            else
            {
                loadData(cmd, isAppointment);
            }*/
        }

        private void comboBoxEquipmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBoxEquipmentStatus.SelectedIndex != 0)
            {
                loadData(cmd + $" WHERE id_status = {comboBoxEquipmentStatus.SelectedIndex}", isAppointment);
            }
            else
            {
                loadData(cmd, isAppointment);
            }*/
        }  

        private void loadData(string cmd, bool isAppointment)
        {
            flowLayoutPanel.Controls.Clear();

            db.openConnection();

            NpgsqlCommand getData = new NpgsqlCommand(cmd, db.getConnection());
            NpgsqlDataReader readerData = getData.ExecuteReader();

            while (readerData.Read())
            {
                ControlAppointment controlAppointment;
                int id = readerData.GetInt32(0);

                if (isAppointment == false)
                {
                    int type = readerData.GetInt32(5);
                    string manufacture = readerData.GetString(2);
                    string model = readerData.GetString(1);
                    string imgUrl;
                    if (readerData.IsDBNull(6))
                    {
                        imgUrl = "";
                    } 
                    else
                    {
                        imgUrl = readerData.GetString(6);
                    }

                    controlAppointment = new ControlAppointment(id, type, manufacture, model, imgUrl);
                }
                else
                {
                    int id_equipment = readerData.GetInt32(1);
                    int id_employee = readerData.GetInt32(2);

                    controlAppointment = new ControlAppointment(id, id_equipment, id_employee);
                }
                flowLayoutPanel.Controls.Add(controlAppointment);
            }
            readerData.Close();

            db.closeConnection();
        }        

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form formAuth = new FormAuth();
            formAuth.Show();
        }        
    }
}
