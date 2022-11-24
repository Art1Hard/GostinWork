using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // --- SQLServer

namespace Plan_Gostin
{
    public partial class Avtorization : Form
    {
        DataBase db = new DataBase(); // --- Наш класс базы данных
        public Avtorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Avtorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*'; // --- Скрытие пароля с помощью символа
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void buttonVoiti_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text; // --- Создание переменной логина и занесение туда информацию о логине которую мы вводим
            var password = textBoxPassword.Text; // --- Создание переменной пароля и занесение туда информацию о логине которую мы вводим

            SqlDataAdapter adapter = new SqlDataAdapter(); // --- Инициализация класса Адаптера для работы с БД
            DataTable table = new DataTable(); // --- Инициализация класса Таблицы для работы с БД

            string queryString = $"select ID, Loggin, Pasword from ADMINS where Loggin = '{login}' and Pasword = '{password}'"; // --- Строка SQL запроса

            SqlCommand command = new SqlCommand(queryString, db.getConnection()); // --- Инициализация класса Команд(Sql Запрос, подключение Sqlbd)

            adapter.SelectCommand = command;
            adapter.Fill(table); // --- в эту таблицу заносим данные

            if (table.Rows.Count == 1) // --- если строка таблицы равна 1
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Help.isAdmin = true;
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); ;
                textBoxPassword.Text = "";
            }    
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
