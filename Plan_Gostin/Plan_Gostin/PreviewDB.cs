using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        DataBase dataBase = new DataBase();

        int selectedRow;

        public PreviewDB()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            VisibleElementFilter();
            bigRadioButton.Checked = true;

            KeyPreview = true;

            if(!Help.isAdmin)
            {
                Width = 685;
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
            if(!Help.isAdmin) // если мы не вошли то,
                dataGridView1.Width = 650;
        }

        private void VisibleColumns() // метод скрытия ненужных столбцов
        {
            // скрытие ненужных столбцов
            if(!Help.isAdmin) // если вы не вошли, то скрываются id номеров
            {
                dataGridView1.Columns[0].Visible = false;
            }
            dataGridView1.Columns[6].Visible = false;
        }

        private void ReadSingRow(DataGridView dgw, IDataRecord record) // чтение из БД-таблицы информацию и заносим эти строки в DataGridView
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetDateTime(4).ToShortDateString(), record.GetInt32(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from rooms";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingRow(dgw, reader);
            }
            reader.Close();
        }


        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Help.isAdmin) // если мы администратор мы переходим на форму для
            {
                AdminPanel adm = new AdminPanel();
                adm.Show();
                this.Hide();
            }
            else
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void PreviewDB_Load(object sender, EventArgs e)
        {
            CreateColumns(); // Вызываем метод создания колонок
            WidthColumns(); // Вызываем метод изменения ширины колонок
            VisibleColumns(); // Вызываем метод скрытия ненужных колонок
            RefreshDataGrid(dataGridView1); // Вызываем метод обновления dgw
            DataGridViewWidth(); // Вызываем метод изменения ширины dgw
        }

        private void PreviewDB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                назадToolStripMenuItem_Click(назадToolStripMenuItem, null);
            }
            
            if(e.KeyCode == Keys.R)
            {
                обновитьТаблицуToolStripMenuItem_Click(обновитьТаблицуToolStripMenuItem, null);
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
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
        }
        private void FilterROOM(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string filterString = string.Format("Select * from ROOMS where Gost_ROOM like '%" + filterTextBox.Text + "%'");

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while(reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }

        private void FilterEnd(DataGridView dgw)
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

        private void FilterDop(DataGridView dgw)
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

        private void FilterPrice(DataGridView dgw)
        {
            dgw.Rows.Clear();

            try
            {
                int value = Convert.ToInt32(filterTextBox.Text);
                string filterString ="";

                if(bigRadioButton.Checked)
                {
                    filterString = string.Format("Select * from ROOMS where Price >= " + value + "order by Price");
                }
                if(littleRadioButton.Checked)
                {
                    filterString = string.Format("Select * from ROOMS where Price <= " + value + "order by Price");
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

        private string vibor; 

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if(vibor == "Цена")
            {
                FilterPrice(dataGridView1);
            }
            if(vibor == "Номер")
                FilterROOM(dataGridView1);
            if (vibor == "Окончание")
                FilterEnd(dataGridView1);
            if (vibor == "Доп услуги")
                FilterDop(dataGridView1);
        }

        private void FilterStatus(DataGridView dgw)
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterStatus(dataGridView1);
        }

        private void HelpVibor(int index)
        {
            if(index == 0)
            {
                statusComboBox.Visible = false;
                filterButton.Visible = false;
                filterTextBox.Visible = true;
                bigRadioButton.Visible = true;
                littleRadioButton.Visible = true;
                bigRadioButton.Enabled = false;
                littleRadioButton.Enabled = false;
            }
            if(index == 1)
            {
                statusComboBox.Visible = true;
                filterButton.Visible = true;
                filterTextBox.Visible = false;
                bigRadioButton.Visible = false;
                littleRadioButton.Visible = false;
            }
            if(index == 2)
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
            switch(viborComboBox.SelectedIndex)
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
    }
}
