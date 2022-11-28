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

        public static void ReadSingRow(DataGridView dgw, IDataRecord record) // чтение из БД-таблицы информацию и заносим эти строки в DataGridView
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






        string table = "ROOMS"; // переменная с таблицей Номеров

        private void filterTextBox_TextChanged(object sender, EventArgs e) // при смене текста
        {
            if (vibor == "Цена")
                FilterDB.Filter_DB(dataGridView1, filterTextBox, table, "Price", bigRadioButton); // фильтрует по Цене

            if (vibor == "Номер")
                FilterDB.Filter_DB(dataGridView1, filterTextBox, table, "Gost_ROOM"); // фильтрует по Номеру

            if (vibor == "Окончание")
                FilterDB.Filter_DB(dataGridView1, filterTextBox, table, "Okonchanie"); // фильтрует по Дате

            if (vibor == "Доп услуги")
                FilterDB.Filter_DB(dataGridView1, filterTextBox, table, "Dop_Uslugi"); // фильтрует по Услугам
        }

        private void filterButton_Click(object sender, EventArgs e) // при клике на кнопку
        {
            FilterDB.Filter_DB(dataGridView1, statusComboBox, table, "Gost_Status"); // фильтрует по Статусу
        }

        bool isFilter = false; // логическая переменна фильтр ли она
        private bool VisibleElements(bool isFilter) // скрытие элементов при условии,
        {
            if (isFilter) // если, нажата кнопка выбора фильтра то,
                sortButton.Enabled = false;
            else
            {
                statusComboBox.Visible = false;
                filterTextBox.Visible = false;
                filterTextBox.Text = "";
                filterButton.Visible = false;
                bigRadioButton.Visible = false;
                littleRadioButton.Visible = false;
            }

            isFilter = false; // переменная возвращается в default состояние
            return isFilter; // возвращаем состояние
        }

        private void viborButton_Click(object sender, EventArgs e) // кнопка выбора фильтра
        {
            isFilter = true; // это есть фильтр
            isFilter = VisibleElements(isFilter); // скрытие элементов сортировки

            // в зависимости от выбора фильтра мы выбираем что скрыть/показать в окне фильтра, и присваиваем значение переменной vibor.
            vibor = FilterDB.SelectFilter(viborComboBox, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);

        }

        private void viborSortButton_Click(object sender, EventArgs e) // кнопка выбора сортировки
        {
            VisibleElements(isFilter); // скрытие элементов фильтра

            // в зависимости от выбора сортировки мы выбираем что скрыть/показать в окне сортировки, и присваиваем значение переменной vibor.
            vibor = SortDB.SelectSort(sortComboBox, sortButton);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            SortDB.SortDGW(vibor, "Номер", vozrastRadioButton, dataGridView1, "Gost_ROOM", table); // сортирует по Номеру
            SortDB.SortDGW(vibor, "Статус", vozrastRadioButton, dataGridView1, "Gost_Status", table); // сортирует по Статусу
            SortDB.SortDGW(vibor, "Доп услуги", vozrastRadioButton, dataGridView1, "Dop_uslugi", table); // сортирует по Услугам
            SortDB.SortDGW(vibor, "Окончание", vozrastRadioButton, dataGridView1, "Okonchanie", table); // сортирует по Дате
            SortDB.SortDGW(vibor, "Цена", vozrastRadioButton, dataGridView1, "Price", table); // сортирует по Цене
        }
    }
}