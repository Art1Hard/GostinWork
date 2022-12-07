using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; // подключение базы данных SQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public static class Help
    {
        public enum RowState // состояние данных в таблице
        {
            Existed,
            New,
            Modified,
            ModifiedNew,
            Deleted
        }

        public static bool isAdmin = false; // проверка на администратора

        public static void SortDisabled(DataGridView dgw) // отключаем сортировку в dgw
        {
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public static void ReadSingRow(DataGridView dgw, IDataRecord record) // чтение из БД-таблицы информацию и заносим эти строки в DataGridView
        {
            dgw.Rows.Add(record.GetInt32(0),
            record.GetInt32(1),
            record.GetString(2),
            record.GetString(3),
            record.GetDateTime(4).ToShortDateString(),
            record.GetInt32(5),
            RowState.ModifiedNew);
        }

        public static void RefreshDataGrid(DataGridView dgw) // обновление данных в dgw
        {
            DataBase dataBase = new DataBase();

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

        public static void CreateColumns(DataGridView dgw) // создание колонок в таблице
        {
            // добавление колонок
            dgw.Columns.Add("id", "id");
            dgw.Columns.Add("Gost_Room", "Номер");
            dgw.Columns.Add("Gost_Status", "Статус");
            dgw.Columns.Add("Dop_uslugi", "Доп. услуги");
            dgw.Columns.Add("Okonchanie", "Окончание");
            dgw.Columns.Add("Price", "Цена");
            dgw.Columns.Add("isNew", string.Empty);
        }

        public static void VisibleColumns(DataGridView dgw) // метод скрытия ненужных столбцов
        {
            // скрытие ненужных столбцов
            if (!isAdmin) // если вы не вошли, то скрываются id номеров
            {
                dgw.Columns[0].Visible = false;
            }
            dgw.Columns[6].Visible = false;
        }

        public static void VisibleHeaders(DataGridView dgw, bool column, bool row) // видимость главных строк и столбцов
        {
            dgw.ColumnHeadersVisible = column;
            dgw.RowHeadersVisible = row;
        }

        public static void WidthColumns(DataGridView dgw) // метод изменения ширины столбцов
        {
            // изменение ширины столбцов
            dgw.Columns[0].Width = 40;
            dgw.Columns[1].Width = 50;
            dgw.Columns[2].Width = 70;
            dgw.Columns[3].Width = 150;
            dgw.Columns[4].Width = 70;
            dgw.Columns[5].Width = 50;
        }

        public static string SelectSort(ComboBox sortComboBox, Button sortButton) // выбор сортировки
        {
            string vibor;

            switch (sortComboBox.SelectedIndex)
            {
                case 0:
                    vibor = "Номер";
                    sortButton.Enabled = true;
                    break;
                case 1:
                    vibor = "Статус";
                    sortButton.Enabled = true;
                    break;
                case 2:
                    vibor = "Доп услуги";
                    sortButton.Enabled = true;
                    break;
                case 3:
                    vibor = "Окончание";
                    sortButton.Enabled = true;
                    break;
                case 4:
                    vibor = "Цена";
                    sortButton.Enabled = true;
                    break;
                default:
                    vibor = "";
                    break;
            }
            return vibor;
        }

        public static void SortDGW(string choice, string trueChoice, RadioButton ascending, DataGridView dgw, string sqlRow, string sqlTable)
        {
            if (choice == trueChoice)
            {
                DataBase dataBase = new DataBase();

                dgw.Rows.Clear();

                string filterString;

                if (ascending.Checked)
                    filterString = string.Format("Select * from {1} order by {0}", sqlRow, sqlTable);

                else
                    filterString = string.Format("Select * from {1} order by {0} desc", sqlRow, sqlTable);

                SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

                dataBase.openConnection();

                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingRow(dgw, reader);
                }

                reader.Close();
            }
        }

        private static void VisibleObjectFilter(int vibor, ComboBox statusComboBox, Button filterButton, TextBox filterTextBox, RadioButton bigRadioButton, RadioButton littleRadioButton)
        {
            if (vibor == 0)
            {
                statusComboBox.Visible = false;
                filterButton.Visible = false;
                filterTextBox.Visible = true;
                bigRadioButton.Visible = true;
                littleRadioButton.Visible = true;
                bigRadioButton.Enabled = false;
                littleRadioButton.Enabled = false;
            }
            if (vibor == 1)
            {
                statusComboBox.Visible = true;
                filterButton.Visible = true;
                filterTextBox.Visible = false;
                bigRadioButton.Visible = false;
                littleRadioButton.Visible = false;
            }
            if (vibor == 2)
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

        public static string SelectFilter(ComboBox viborComboBox, ComboBox statusComboBox, Button filterButton, TextBox filterTextBox, RadioButton bigRadioButton, RadioButton littleRadioButton)
        {
            PreviewDB prDB = new PreviewDB();

            string vibor;

            switch (viborComboBox.SelectedIndex)
            {
                case 0:
                    vibor = "Номер";
                    VisibleObjectFilter(0, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
                    break;
                case 1:
                    vibor = "";
                    VisibleObjectFilter(1, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
                    break;
                case 2:
                    vibor = "Доп услуги";
                    VisibleObjectFilter(0, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
                    break;
                case 3:
                    vibor = "Окончание";
                    VisibleObjectFilter(0, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
                    break;
                case 4:
                    vibor = "Цена";
                    VisibleObjectFilter(2, statusComboBox, filterButton, filterTextBox, bigRadioButton, littleRadioButton);
                    break;
                default:
                    vibor = "";
                    break;
            }
            return vibor;
        }

        public static void Filter_DB(DataGridView dgw, TextBox filterTextBox, string sqlTable, string sqlRow)
        {
            DataBase dataBase = new DataBase();
            dgw.Rows.Clear();

            string filterString = string.Format("Select * from {1} where {2} like '%{0}%'", filterTextBox.Text, sqlTable, sqlRow);

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }

        public static void Filter_DB(DataGridView dgw, TextBox filterTextBox, string sqlTable, string sqlRow, RadioButton bigRadioButton)
        {
            DataBase dataBase = new DataBase();
            dgw.Rows.Clear();

            string filterString;

            try
            {
                if (bigRadioButton.Checked)
                    filterString = string.Format("Select * from {1} where {2} >= {0}", filterTextBox.Text, sqlTable, sqlRow);

                else
                    filterString = string.Format("Select * from {1} where {2} <= {0}", filterTextBox.Text, sqlTable, sqlRow);

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

        public static void Filter_DB(DataGridView dgw, ComboBox statusComboBox, string sqlTable, string sqlRow)
        {
            DataBase dataBase = new DataBase();
            dgw.Rows.Clear();

            string status;

            switch (statusComboBox.SelectedIndex)
            {
                case 0:
                    status = "Занят";
                    break;
                case 1:
                    status = "Свободен";
                    break;
                default:
                    status = "";
                    break;

            }

            string filterString = string.Format("Select * from {1} where {2} like '%{0}%'", status, sqlTable, sqlRow);

            SqlCommand com = new SqlCommand(filterString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                ReadSingRow(dgw, reader);
            }

            reader.Close();
        }

        // авторизация
        public static void Avtorization(Form thisForm, Form secondForm, TextBox loginTB, TextBox passwordTB)
        {
            DataBase db = new DataBase();

            var login = loginTB.Text; // --- Создание переменной логина и занесение туда информацию о логине которую мы вводим
            var password = passwordTB.Text; // --- Создание переменной пароля и занесение туда информацию о логине которую мы вводим

            SqlDataAdapter adapter = new SqlDataAdapter(); // --- Инициализация класса Адаптера для работы с БД
            DataTable table = new DataTable(); // --- Инициализация класса Таблицы для работы с БД

            string queryString = $"select ID, Loggin, Pasword from ADMINS where Loggin = '{login}' and Pasword = '{password}'"; // --- Строка SQL запроса

            SqlCommand command = new SqlCommand(queryString, db.getConnection()); // --- Инициализация класса Команд(Sql Запрос, подключение Sqlbd)

            adapter.SelectCommand = command;
            adapter.Fill(table); // --- в эту таблицу заносим данные

            if (table.Rows.Count == 1) // --- если строка таблицы равна 1
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                isAdmin = true;
                secondForm.Show();
                thisForm.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); ;
                passwordTB.Text = "";
            }
        }
    }
}
