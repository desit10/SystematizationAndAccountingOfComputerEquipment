using Npgsql;
using System;
using System.Windows.Forms;
using SystematizationAndAccountingOfComputerEquipment.Classes;

namespace SystematizationAndAccountingOfComputerEquipment.Dialogs
{
    public partial class DialogCreateAppointment : Form
    {
        DataBase db = new DataBase();

        public DialogCreateAppointment()
        {
            InitializeComponent();

            db.loadItemComboBox(comboBoxTypesEquipment, "types_equipment");
            db.loadItemComboBox(comboBoxEmployees, "employees");

            btnClose.DialogResult = DialogResult.Cancel;
            btnCreateAppointments.DialogResult = DialogResult.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAppointments_Click(object sender, EventArgs e)
        {
            db.openConnection();

            try
            {
                NpgsqlCommand getId = new NpgsqlCommand(
                    $"SELECT id FROM equipments WHERE model = '{comboBoxEquipments.Text}'",
                    db.getConnection());                

                NpgsqlCommand insertAppointment = new NpgsqlCommand(
                    "INSERT INTO appointments (id_equipment, id_employee)" +
                    $"VALUES ({(int)getId.ExecuteScalar()}, {comboBoxEmployees.SelectedIndex + 1});",
                    db.getConnection());
                insertAppointment.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void comboBoxTypesEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEquipments.Items.Clear();

            db.openConnection();

            NpgsqlCommand getEquipments = new NpgsqlCommand($"SELECT model FROM equipments WHERE id_type = {comboBoxTypesEquipment.SelectedIndex + 1} ORDER BY id ASC", db.getConnection());
            NpgsqlDataReader reader = getEquipments.ExecuteReader();

            while(reader.Read())
            {
                comboBoxEquipments.Items.Add(reader.GetString(0));
            }
            reader.Close();

            db.closeConnection();
        }
    }
}
