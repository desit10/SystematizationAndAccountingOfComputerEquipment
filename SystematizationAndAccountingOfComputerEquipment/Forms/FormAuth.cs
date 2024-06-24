using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using SystematizationAndAccountingOfComputerEquipment.Classes;

namespace SystematizationAndAccountingOfComputerEquipment.Forms
{
    public partial class FormAuth : Form
    {
        DataBase db = new DataBase();

        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин.", "Ошибка");
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите пароль.", "Ошибка");
            }
            else
            {
                int userId = 0;
                string passwordUser = null;

                db.openConnection();

                NpgsqlCommand checkUser = new NpgsqlCommand(
                    $"SELECT id, password, id_role FROM users WHERE login = '{login}'", db.getConnection());

                NpgsqlDataReader reader = checkUser.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        userId = reader.GetInt32(0);
                        passwordUser = reader.GetString(1);
                    }
                }
                db.closeConnection();

                if (passwordUser != null)
                {
                    if (passwordUser != password)
                    {
                        MessageBox.Show("Не верный пароль.", "Ошибка");
                    }

                    if (passwordUser == password)
                    {
                        Form formMain = new FormMain(userId);
                        this.Hide();
                        formMain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином не существует.", "Ошибка");
                }

            }
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            this.Hide();
            formReg.Show();
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void labelReg_MouseMove(object sender, MouseEventArgs e)
        {
            labelReg.ForeColor = ColorTranslator.FromHtml("#B99F6E");
        }

        private void labelReg_MouseLeave(object sender, EventArgs e)
        {
            labelReg.ForeColor = ColorTranslator.FromHtml("#263145");
        }
    }
}
