using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // подключение базы данных SQL

namespace Plan_Gostin
{
    enum RowState // состояние данных в таблице
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class PreviewDB : Form
    {
        DataBase dataBase = new DataBase(); // инициализация нашего класса

        int selectedRow;

        private string vibor; // переменная для помощи в "Выборе"
        private string sortVibor; // переменная для помощи в "Выборе" сортировка

        public PreviewDB()
        {
            StartPosition = FormStartPosition.CenterScreen; // форма по середине экрана
            InitializeComponent();

            VisibleElementFilter(); // скрытие элементов фильтра
            bigRadioButton.Checked = true; // при инициализации радио-кнопка будет активирована
            vozrastRadioButton.Checked = true; // при инициализации радио-кнопка будет активирована

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            KeyPreview = true; // включает на форме назначение кнопок

            if (!Help.isAdmin) // если мы не админ,
            {
                Width = 685; // ширина формы
            }
        }

        private void CreateColumns() // создание колонок в таблице
        {
            // добавление колонок
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Gost_Room", "Номер");
            dataGridView1.Columns.Add("Gost_Status", "Статус");
            dataGridView1.Columns.Add("Dop_uslugi", "Доп. услуги");
            dataGridView1.Columns.Add("Okonchanie", "Окончание");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add("isNew", string.Empty);
        }

        private void WidthColumns() // метод изменения ширины столбцов
        {
            // изменение ширины столбцов
            dataGridView1.Columns[3].Width = 200;
        }

        private void DataGridViewWidth() // изменение ширины dgw
        {
            if (!Help.isAdmin) // если мы не вошли то,
                dataGridView1.Width = 650;
        }

        private void VisibleColumns() // метод скрытия ненужных столбцов
        {
            // скрытие ненужных столбцов
            if (!Help.isAdmin) // если вы не вошли, то скрываются id номеров
            {
                dataGridView1.Columns[0].Visible = false;
            }
            dataGridView1.Columns[6].Visible = false;
        }

        private void ReadSingRow(DataGridView dgw, IDataRecord record) // чтение из БД-таблицы информацию и заносим эти строки в DataGridView
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetDateTime(4).ToShortDateString(), record.GetInt32(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw) // обновление данных в dgw
        {
            dgw.Rows.Clear(); // очищаем строки у dgw

            string queryString = $"select * from rooms"; // sql запрос

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }
            reader.Close();
        }


        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Help.isAdmin) // если мы администратор то,
            {
                AdminPanel adm = new AdminPanel();
                adm.Show();
                this.Hide();
            }
            else // если нет,
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void SortExitDGW(DataGridView dgw)
        {
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void PreviewDB_Load(object sender, EventArgs e)
        {
            CreateColumns(); // Вызываем метод создания колонок
            WidthColumns(); // Вызываем метод изменения ширины колонок
            VisibleColumns(); // Вызываем метод скрытия ненужных колонок
            RefreshDataGrid(dataGridView1); // Вызываем метод обновления dgw
            DataGridViewWidth(); // Вызываем метод изменения ширины dgw
            SortExitDGW(dataGridView1); // Отключаем сортировку dgw
        }

        private void PreviewDB_KeyDown(object sender, KeyEventArgs e) // метод привязывания кнопок
        {
            if (e.KeyCode == Keys.Escape) // если нажать esc то,
            {
                назадToolStripMenuItem_Click(назадToolStripMenuItem, null); // вызывается метод возвращения на предыдущую форму
            }

            if (e.KeyCode == Keys.R) // если нажать R то,
            {
                обновитьТаблицуToolStripMenuItem_Click(обновитьТаблицуToolStripMenuItem, null); // вызывается метод обновления таблицы
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e) // обновление таблицы
        {
            RefreshDataGrid(dataGridView1);
        }

        private void VisibleElementFilter() // при инициализации скрываем элементы
        {
            filterTextBox.Visible = false;
            bigRadioButton.Visible = false;
            littleRadioButton.Visible = false;
            statusComboBox.Visible = false;
            filterButton.Visible = false;

            sortButton.Enabled = false; // сортировка
        }

        private void FilterROOM(DataGridView dgw) // фильтр "Номер"
        {
            dgw.Rows.Clear();

            string filterString = string.Format("Select * from ROOMS where Gost_ROOM like '%" + filterTextBox.Text + "%'");

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }

        private void FilterStatus(DataGridView dgw) // фильтр "Статус"
        {
            dataGridView1.Rows.Clear();
            string status = "";

            switch (statusComboBox.SelectedIndex)
            {
                case 0:
                    status = "Занят";
                    break;
                case 1:
                    status = "Свободен";
                    break;
            }

            string filterString = string.Format("Select * from ROOMS where Gost_Status like '%" + status + "%'");

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dataGridView1, reader);
            }

            reader.Close();
        }

        private void FilterDop(DataGridView dgw) // фильтр "Доп. Услуги"
        {
            dgw.Rows.Clear();

            string filterString = string.Format("Select * from ROOMS where Dop_uslugi like '%" + filterTextBox.Text + "%'");

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }

        private void FilterPrice(DataGridView dgw) // фильтр "Цена"
        {
            dgw.Rows.Clear();

            try
            {
                int value = Convert.ToInt32(filterTextBox.Text);
                string filterString = "";

                if (bigRadioButton.Checked)
                {
                    filterString = string.Format("Select * from ROOMS where Price >= " + value);
                }
                if (littleRadioButton.Checked)
                {
                    filterString = string.Format("Select * from ROOMS where Price <= " + value);
                }



                SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                dataBase.openConnection();

                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingRow(dgw, reader);
                }

                reader.Close();
            }
            catch
            {
                filterTextBox.Text = "";
            }
        }

        private void FilterEnd(DataGridView dgw) // фильтр "Окончание"
        {
            dgw.Rows.Clear();

            string filterString = string.Format("Select * from ROOMS where Okonchanie like '%" + filterTextBox.Text + "%'");

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }



        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (vibor == "Цена")
            {
                FilterPrice(dataGridView1);
            }
            if (vibor == "Номер")
                FilterROOM(dataGridView1);
            if (vibor == "Окончание")
                FilterEnd(dataGridView1);
            if (vibor == "Доп услуги")
                FilterDop(dataGridView1);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterStatus(dataGridView1);
        }

        private void HelpVibor(int index)
        {
            if (index == 0)
            {
                statusComboBox.Visible = false;
                filterButton.Visible = false;
                filterTextBox.Visible = true;
                bigRadioButton.Visible = true;
                littleRadioButton.Visible = true;
                bigRadioButton.Enabled = false;
                littleRadioButton.Enabled = false;
            }
            if (index == 1)
            {
                statusComboBox.Visible = true;
                filterButton.Visible = true;
                filterTextBox.Visible = false;
                bigRadioButton.Visible = false;
                littleRadioButton.Visible = false;
            }
            if (index == 2)
            {
                statusComboBox.Visible = false;
                filterButton.Visible = false;
                filterTextBox.Visible = true;
                bigRadioButton.Visible = true;
                littleRadioButton.Visible = true;
                bigRadioButton.Enabled = true;
                littleRadioButton.Enabled = true;
            }
        }

        private void viborButton_Click(object sender, EventArgs e)
        {
            switch (viborComboBox.SelectedIndex)
            {
                case 0:
                    vibor = "Номер";
                    HelpVibor(0);
                    break;
                case 1:
                    HelpVibor(1);
                    break;
                case 2:
                    vibor = "Доп услуги";
                    HelpVibor(0);
                    break;
                case 3:
                    vibor = "Окончание";
                    HelpVibor(0);
                    break;
                case 4:
                    vibor = "Цена";
                    HelpVibor(2);
                    break;

            }

        }

        private void viborSortButton_Click(object sender, EventArgs e)
        {
            switch (sortComboBox.SelectedIndex)
            {
                case 0:
                    sortVibor = "Номер";
                    sortButton.Enabled = true;
                    break;
                case 1:
                    sortVibor = "Статус";
                    sortButton.Enabled = true;
                    break;
                case 2:
                    sortVibor = "Доп услуги";
                    sortButton.Enabled = true;
                    break;
                case 3:
                    sortVibor = "Окончание";
                    sortButton.Enabled = true;
                    break;
                case 4:
                    sortVibor = "Цена";
                    sortButton.Enabled = true;
                    break;
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (sortVibor == "Номер")
            {
                if (vozrastRadioButton.Checked)
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Gost_ROOM");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
                else
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Gost_ROOM desc");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
            }

            if (sortVibor == "Статус")
            {
                if (vozrastRadioButton.Checked)
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Gost_Status");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
                else
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Gost_Status desc");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
            }

            if (sortVibor == "Доп услуги")
            {
                if (vozrastRadioButton.Checked)
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Dop_uslugi");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
                else
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Dop_uslugi DESC");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
            }

            if (sortVibor == "Окончание")
            {
                if (vozrastRadioButton.Checked)
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Okonchanie");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
                else
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Okonchanie DESC");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
            }

            if (sortVibor == "Цена")
            {
                if (vozrastRadioButton.Checked)
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Price");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
                else
                {
                    dataGridView1.Rows.Clear();

                    string filterString = string.Format("Select * from ROOMS order by Price DESC");

                    SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                    dataBase.openConnection();

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        ReadSingRow(dataGridView1, reader);
                    }

                    reader.Close();
                }
            }
        }
    }
}