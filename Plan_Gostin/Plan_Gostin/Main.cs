using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Application.Exit();
        }

        private void buttonAvtorization_Click(object sender, EventArgs e)
        {
            avt.ShowDialog();
            this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            PreviewDB prev = new PreviewDB();
            prev.Show();
            this.Hide();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}