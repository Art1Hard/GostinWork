using System;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class Main : Form
    {
        Avtorization avt = new Avtorization();
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // --- Начальная позиция окна(центр)
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAvtorization_Click(object sender, EventArgs e)
        {
            avt.Show();
            Hide();
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAvtorization_Click(buttonAvtorization, null);
        }

        private void buttonRelation_Click(object sender, EventArgs e)
        {
            Ralation rel = new Ralation();
            rel.ShowDialog();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            PreviewDB prev = new PreviewDB();
            prev.Show();
            Hide();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                выходToolStripMenuItem1_Click(выходToolStripMenuItem1, null);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}