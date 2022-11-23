using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Gostin
{
    internal class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=ARTPC;Initial Catalog=Gostin;Persist Security Info=True;User ID=AdminArt;Password=artem500");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
