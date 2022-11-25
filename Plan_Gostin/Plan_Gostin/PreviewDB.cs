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
    }
}
