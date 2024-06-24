using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using SystematizationAndAccountingOfComputerEquipment.Classes;

namespace SystematizationAndAccountingOfComputerEquipment.Forms
{
    public partial class FormReg : Form
    {
        DataBase db = new DataBase();
        public FormReg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string patronymic = textBoxPatronymic.Text;
            string telephone = textBoxTelephone.Text;
            string mail = textBoxMail.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Заполните поле Имя.", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Заполните поле Фамилия.", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Заполните поле Отчество.", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("Заполните поле Телефон", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Заполните поле Эл. почта.", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("Заполните поле Логин.", "Ошибка");

                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните поле Пароль.", "Ошибка");

                return;
            }

            db.openConnection();


            NpgsqlCommand checkUser = new NpgsqlCommand($"SELECT id FROM users WHERE login = '{login}'", db.getConnection());
            int? checkLogin = (int?)checkUser.ExecuteScalar();

            if (checkLogin != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка");
                return;
            }

            NpgsqlCommand inserUser = new NpgsqlCommand(
                $"INSERT INTO users (login, password, id_role, name, telephone, mail) " +
                $"VALUES ('{login}', '{password}', {2}, '{surname + " " + name + " " + patronymic}','{telephone}', '{mail}')",
                db.getConnection());
            inserUser.ExecuteNonQuery();                               

            db.closeConnection();

            MessageBox.Show("Пользователь успешно зарегистрирован.", "Инфо");

            Close();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.Show();
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.ForeColor = ColorTranslator.FromHtml("#B99F6E");
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = ColorTranslator.FromHtml("#263145");
        }
    }
}
