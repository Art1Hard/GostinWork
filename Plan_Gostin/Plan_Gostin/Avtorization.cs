using System;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class Avtorization : Form
    {
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
                textBoxPassword.PasswordChar = '\0';
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
            if (e.KeyCode == Keys.Enter && textBoxLogin.Focused)
                textBoxPassword.Focus();

            else if(e.KeyCode == Keys.Enter)
                buttonVoiti_Click(buttonVoiti, null);

            if(e.KeyCode == Keys.Escape)
                buttonNazad_Click(buttonNazad, null);
        }

        private void Avtorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonNazad_Click(buttonNazad, null);
        }
    }
}
