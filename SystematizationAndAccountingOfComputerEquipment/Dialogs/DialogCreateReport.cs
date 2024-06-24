using Npgsql;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SystematizationAndAccountingOfComputerEquipment.Classes;
using SystematizationAndAccountingOfComputerEquipment.Controls;

namespace SystematizationAndAccountingOfComputerEquipment.Dialogs
{
    public partial class DialogCreateReport : Form
    {
        private DataBase db = new DataBase();
        private string folderPath = $@"C:\Моя папочка\Учет\Отчётность";
       
        public DialogCreateReport()
        {
            InitializeComponent();

            // Создать папку, если она не существует
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            dirInfo.Create();

            // Получить список файлов в папке
            //DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = dirInfo.GetFiles();

            foreach (FileInfo file in files)
            {
                flowLayoutPanelReports.Controls.Add(new ControlFile(file.Name, file.FullName));
            }
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {          
            string fileName = $"Отчетность.xls";

            try
            {
                // Создать папку, если она не существует
                DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
                dirInfo.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании папки 'Отчётность':\n{ex.Message}", "Ошибка");
            }

            string destinationPath = Path.Combine(folderPath, fileName);

            if (!File.Exists(destinationPath))
            {
                flowLayoutPanelReports.Controls.Add(new ControlFile(fileName, destinationPath));

                ExportToXslFile(destinationPath);

                MessageBox.Show($"Отчётность успешно создана", "Info");
            }
            else
            {
                ExportToXslFile(destinationPath);

                MessageBox.Show($"Отчётность успешно обновлена", "Info");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToXslFile(string filePath)
        {
            string[] columnNames = new string[] { "Номер", "Тип оборудования", "Производитель", "Модель", "Местонахождение", "Кто использует", "Статус", "Дата покупки", "Дата истичения срока использования" };
            // создаем строку
            StringBuilder sb = new StringBuilder();

            // проходим по каждому столбцу таблицы
            foreach (string columnName in columnNames)
            {
                // записываем название столбца в строку
                sb.Append(columnName + " ");

                // ставим разделитель
                sb.Append('\t');
            }

            // делаем перенос на следующую строку
            sb.Length--;
            sb[sb.Length - 1] = '\n';

            // записываем данные в файл
            File.WriteAllText(filePath, getApplications(sb).ToString(), Encoding.GetEncoding(1251));
        }

        private StringBuilder getApplications(StringBuilder sb)
        {
            db.openConnection();

            NpgsqlCommand getData = new NpgsqlCommand(
                "SELECT equipments.id, types_equipment.title, equipments.manufacture, equipments.model, " +
                "locations.title, employees.name, status.title, " +
                "TO_CHAR(equipments.purchase_date, 'DD.MM.YYYY'), TO_CHAR(equipments.warranty_expiration_date, 'DD.MM.YYYY') FROM appointments " +
                "JOIN equipments ON appointments.id_equipment = equipments.id " +
                "JOIN types_equipment ON equipments.id_type = types_equipment.id " +
                "JOIN employees ON appointments.id_employee = employees.id " +
                "JOIN status ON equipments.id_status = status.id " +
                "JOIN locations ON employees.id_location = locations.id",
                db.getConnection());
            NpgsqlDataReader dataReader = getData.ExecuteReader();

            int countColumn = dataReader.FieldCount;
            while (dataReader.Read())
            {
                for (int i = 0; i < countColumn; i++)
                {
                    // записываем значение ячейки в строку
                    sb.Append($"{dataReader.GetValue(i)} ");

                    // ставим разделитель
                    sb.Append('\t');
                }

                // делаем перенос на следующую строку
                sb.Length--;
                sb[sb.Length - 1] = '\n';
            }
            dataReader.Close();

            db.closeConnection();

            return sb;
        }
    }
}
