using System;
using System.Collections.Generic;
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
                PreviewDB.ReadSingRow(dgw, reader);
            }
            reader.Close();
        }
    }
}
