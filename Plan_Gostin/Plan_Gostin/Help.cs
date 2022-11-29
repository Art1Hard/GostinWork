using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public static class Help
    {
        public static bool isAdmin = false;

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

        public static void VisibleHeaders(DataGridView dgw, bool visible)
        {
            dgw.ColumnHeadersVisible = visible;
            dgw.RowHeadersVisible = visible;
        }

        public static void WidthColumns(DataGridView dgw) // метод изменения ширины столбцов
        {
            // изменение ширины столбцов
            dgw.Columns[3].Width = 200; // изменяется только четвертый столбец
        }
    }
}
