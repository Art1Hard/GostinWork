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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            KeyPreview = true;
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AllowUserToResizeColumns = false; // нельзя пользователю в dgw менять размер столбцов 
            dataGridView1.AllowUserToResizeRows = false; // нельзя пользователю в dgw менять размер строк 
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Help.CreateColumns(dataGridView1);
            Help.RefreshDataGrid(dataGridView1);
            Help.VisibleColumns(dataGridView1);
            Help.SortDisabled(dataGridView1);
            Help.VisibleHeaders(dataGridView1, false);
            Help.WidthColumns(dataGridView1);
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            Hide();
        }

        private void Reservation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                назадToolStripMenuItem_Click(назадToolStripMenuItem, null);
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.RefreshDataGrid(dataGridView1);
        }
    }
}
