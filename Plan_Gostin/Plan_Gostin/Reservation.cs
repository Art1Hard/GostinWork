using System;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public partial class Reservation : Form
    {
        private int selectedRow;
        private string vibor;

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

            // FILTER
            filterTextBox.Visible = false; // скрытие текст-бокса
            bigRadioButton.Visible = false; // скрытие радио-кнопки >
            littleRadioButton.Visible = false; // скрытие радио-кнопки <
            statusComboBox.Visible = false; // скрытие комбо-бокса статуса
            filterButton.Visible = false; // скрытие кнопки сортировки по статусу
            bigRadioButton.Checked = true; // при инициализации радио-кнопка фильтра будет активирована
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
            if (e.KeyCode == Keys.Escape) // если нажать esc то,
                назадToolStripMenuItem_Click(назадToolStripMenuItem, null);

            if (e.KeyCode == Keys.R) // если нажать R то,
                обновитьТаблицуToolStripMenuItem_Click(обновитьТаблицуToolStripMenuItem, null);
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.RefreshDataGrid(dataGridView1);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            Help.Updating(dataGridView1, roomTextBox, statusTextBox, "Занят");
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Help.Updating(dataGridView1, roomTextBox, statusTextBox, "Свободен"); // метод для Update-таблицы
        }

        private void viborButton_Click(object sender, EventArgs e)
        {
            // в зависимости от выбора фильтра мы выбираем что скрыть/показать в окне фильтра, и присваиваем значение переменной vibor.
            vibor = Help.SelectFilter(viborComboBox, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
        }

        string table = "ROOMS";

        private void filterTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (vibor == "Цена")
                Help.Filter_DB(dataGridView1, filterTextBox, table, "Price", bigRadioButton); // фильтрует по Цене

            if (vibor == "Номер")
                Help.Filter_DB(dataGridView1, filterTextBox, table, "Gost_ROOM"); // фильтрует по Номеру

            if (vibor == "Окончание")
                Help.Filter_DB(dataGridView1, filterTextBox, table, "Okonchanie"); // фильтрует по Дате

            if (vibor == "Доп услуги")
                Help.Filter_DB(dataGridView1, filterTextBox, table, "Dop_Uslugi"); // фильтрует по Услугам
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            Help.Filter_DB(dataGridView1, statusComboBox, table, "Gost_Status"); // фильтрует по Статусу
        }

        private void Reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            назадToolStripMenuItem_Click(назадToolStripMenuItem, null);
        }
    }
}
