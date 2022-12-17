using System.Data.SqlClient;

namespace Plan_Gostin
{
    internal class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ARTPC;Initial Catalog=Gostin;Persist Security Info=True;User ID=AdminArt;Password=artem500"); // строка подключения к базе данных

        public void openConnection() // открытие подключения
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void closeConnection() // закрытие подключения
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public SqlConnection getConnection() // получение подключения
        {
            return con;
        }
    }
}
