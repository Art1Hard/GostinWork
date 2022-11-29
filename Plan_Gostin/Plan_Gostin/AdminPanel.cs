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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Help.isAdmin = false;
            main.Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            PreviewDB prev = new PreviewDB();
            prev.Show();
            this.Hide();
        }

        private void AdminPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                выходToolStripMenuItem_Click(выходToolStripMenuItem, null);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation();
            res.Show();
            Hide();
        }
    }
}
