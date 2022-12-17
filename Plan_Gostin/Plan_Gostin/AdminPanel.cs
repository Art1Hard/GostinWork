using System;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из совоего Аккаунта?", "Аккаунт", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                Main main = new Main();
                Help.isAdmin = false;
                main.Show();
                Hide();
            }    
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            PreviewDB prev = new PreviewDB();
            prev.Show();
            Hide();
        }

        private void AdminPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                выходИзАккаунтаToolStripMenuItem_Click(выходИзАккаунтаToolStripMenuItem, null);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
            Hide();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            выходToolStripMenuItem_Click(выходToolStripMenuItem, null);
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
