using Npgsql;
using System;
using System.IO;
using System.Windows.Forms;
using SystematizationAndAccountingOfComputerEquipment.Classes;

namespace SystematizationAndAccountingOfComputerEquipment.Dialogs
{
    public partial class DialogAddEquipment : Form
    {
        DataBase db = new DataBase();
        public DialogAddEquipment()
        {
            InitializeComponent();

            db.loadItemComboBox(comboTypesEquipment, "types_equipment");

            btnClose.DialogResult = DialogResult.Cancel;
            btnAddEquipment.DialogResult = DialogResult.None;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            db.openConnection();

            try
            {                  
                NpgsqlCommand insertEquipment = new NpgsqlCommand(
                    "INSERT INTO equipments (model, manufacture, purchase_date, warranty_expiration_date, id_type, img_url, id_status)" +
                    $"VALUES ('{textBoxModel.Text}', '{textBoxManufacture.Text}', '{datePurchase.Value.ToString("yyyy-MM-dd")}'," +
                    $"'{dateWarrantyExpiration.Value.ToString("yyyy-MM-dd")}', {comboTypesEquipment.SelectedIndex + 1}, " +
                    $"'{pictureBox.ImageLocation}', {1});", 
                    db.getConnection());
                insertEquipment.ExecuteNonQuery();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png) | *.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = openFileDialog.FileName;

                // Check if the file exists
                if (File.Exists(imagePath))
                {
                    // Display the image in the PictureBox
                    pictureBox.Load(imagePath);
                }
                else
                {
                    MessageBox.Show("Error: File not found.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
