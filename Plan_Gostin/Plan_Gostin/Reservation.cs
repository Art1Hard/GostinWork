using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class Reservation : Form
    {
        private int selectedRow;

        public Reservation()
        {
            InitializeComponent();
            KeyPreview = true;
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AllowUserToResizeColumns = false; // нельзя пользователю в dgw менять размер столбцов 
            dataGridView1.AllowUserToResizeRows = false; // нельзя пользователю в dgw менять размер строк 
            statusTextBox.ReadOnly = true;
            priceTextBox.ReadOnly = true;
            roomTextBox.ReadOnly = true;
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            Help.CreateColumns(dataGridView1);
            Help.RefreshDataGrid(dataGridView1);
            Help.VisibleColumns(dataGridView1);
            Help.SortDisabled(dataGridView1);
            Help.VisibleHeaders(dataGridView1, true, false);
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

        private void buyButton_Click(object sender, EventArgs e)
        {
            Updating(roomTextBox, statusTextBox, "Занят");
            Help.RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                roomTextBox.Text = row.Cells[1].Value.ToString();
                statusTextBox.Text = row.Cells[2].Value.ToString();
                priceTextBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private static void Updating(TextBox roomTextBox, TextBox statusTextBox, string status)
        {
            try
            {
                DataBase dataBase = new DataBase();

                var isStatus = statusTextBox.Text;

                if (isStatus != status)
                {
                    dataBase.openConnection();
                    var room = roomTextBox.Text;
                    var changeQuery = $"update ROOMS set Gost_Status = '{status}' where Gost_ROOM = {room}";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Уже " + status);
            }
            catch
            {
                MessageBox.Show("Возможно пустые строки, попробуйте выбрать элемент в таблице");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Updating(roomTextBox, statusTextBox, "Свободен");
            Help.RefreshDataGrid(dataGridView1);
        }
    }
}
