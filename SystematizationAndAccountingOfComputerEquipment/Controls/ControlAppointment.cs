using System;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using Npgsql;
using SystematizationAndAccountingOfComputerEquipment.Classes;

namespace SystematizationAndAccountingOfComputerEquipment.Controls
{
    public partial class ControlAppointment : UserControl
    {
        int id;
        int id_equipment = 0;
        int id_employee;

        DataBase db = new DataBase();

        public ControlAppointment(int id, int type, string manufacture, string model, string imgUrl)
        {
            InitializeComponent();

            this.id = id;

            if(imgUrl != "")
            {
                pictureBox.Load(imgUrl);
            }

            labelManufacture.Text = manufacture;
            labelModel.Text = model;

            
            labelSelectEmployee.Visible = false;
            labelStatus.Visible = false;

            comboBoxEmployees.Visible = false;
            comboBoxStatus.Visible = false;

            comboBoxEmployees.Enabled = false;
            comboBoxStatus.Enabled = false;

            db.openConnection();

            NpgsqlCommand getType = new NpgsqlCommand($"SELECT title FROM types_equipment WHERE id = {type}", db.getConnection());
            labelType.Text = (string) getType.ExecuteScalar();

            db.closeConnection();
        }

        public ControlAppointment(int id, int id_equipment, int id_employee)
        {
            InitializeComponent();

            this.id = id;
            this.id_equipment = id_equipment;
            this.id_employee = id_employee;

            db.loadItemComboBox(comboBoxEmployees, "employees");
            db.loadItemComboBox(comboBoxStatus, "status");

            db.openConnection();

            NpgsqlCommand getEquipment = new NpgsqlCommand($"SELECT * FROM equipments WHERE id = {id_equipment}", db.getConnection());
            NpgsqlDataReader readerEquipment = getEquipment.ExecuteReader();

            int id_type = 0;
            int id_location = 0;
            int id_status = 0;
            while (readerEquipment.Read())
            {                
                string manufacture = readerEquipment.GetString(2);
                string model = readerEquipment.GetString(1);
                string imgUrl;
                id_type = readerEquipment.GetInt32(5);
                id_status = readerEquipment.GetInt32(7);
                if (readerEquipment.IsDBNull(6))
                {
                    imgUrl = "";
                }
                else
                {
                    imgUrl = readerEquipment.GetString(6);
                }

                pictureBox.Load(imgUrl);
                labelManufacture.Text = manufacture;
                labelModel.Text = model;
            }
            readerEquipment.Close();

            NpgsqlCommand getType = new NpgsqlCommand($"SELECT title FROM types_equipment WHERE id = {id_type}", db.getConnection());
            labelType.Text = (string)getType.ExecuteScalar();

            NpgsqlCommand getLocation = new NpgsqlCommand($"SELECT id_location FROM employees WHERE id = {id_employee}", db.getConnection());
            id_location = (int)getLocation.ExecuteScalar();                      

            db.closeConnection();

            comboBoxEmployees.SelectedIndex = id_employee - 1;
            comboBoxStatus.SelectedIndex = id_status - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.openConnection();

            try
            {
                this.Parent.Controls.Remove(this);

                if(id_equipment == 0)
                {
                    NpgsqlCommand deleteEquipment = new NpgsqlCommand($"DELETE FROM equipments WHERE id = {id}", db.getConnection());
                    deleteEquipment.ExecuteNonQuery();
                } else
                {
                    NpgsqlCommand deleteAppointment = new NpgsqlCommand($"DELETE FROM appointments WHERE id = {id}", db.getConnection());
                    deleteAppointment.ExecuteNonQuery();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            db.closeConnection();
        }

        private void comboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();



            db.closeConnection();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();



            db.closeConnection();
        }
    }
}
