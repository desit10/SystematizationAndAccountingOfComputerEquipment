using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace SystematizationAndAccountingOfComputerEquipment.Classes
{
    internal class DataBase
    {
        private NpgsqlConnection connection = 
            new NpgsqlConnection("Server=localhost;  User Id=postgres; password=2207; Database=AccountingComputerEquipmentDB");
        
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public int getMaxId(string table)
        {

            NpgsqlCommand getMaxId = new NpgsqlCommand($"SELECT MAX(id) FROM {table}", connection);
            int maxId = (int)getMaxId.ExecuteScalar();

            return maxId;
        }

        public void loadItemComboBox(ComboBox comboBox, string tableName)
        {
            openConnection();

            NpgsqlCommand getItems;
            if (tableName == "employees")
            {
                getItems = new NpgsqlCommand($"SELECT name FROM {tableName} ORDER BY id ASC", connection);
            }            
            else
            {
                getItems = new NpgsqlCommand($"SELECT title FROM {tableName} ORDER BY id ASC", connection);
            }
            
            NpgsqlDataReader readerItems = getItems.ExecuteReader();

            while (readerItems.Read())
            {
                comboBox.Items.Add($"{readerItems.GetString(0)}");
            }
            readerItems.Close();

            closeConnection();
        }
    }
}
