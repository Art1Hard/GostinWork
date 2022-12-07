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
            AdminPanel ap = new AdminPanel();

            Help.Avtorization(this, ap, textBoxLogin, textBoxPassword); // вся логика авторизации
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }

        private void Avtorization_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonVoiti_Click(buttonVoiti, null);
            }

            if(e.KeyCode == Keys.Escape)
            {
                buttonNazad_Click(buttonNazad, null);
            }
        }
    }
}
