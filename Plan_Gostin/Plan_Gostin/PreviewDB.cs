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
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Gost_Room", "Номер");
            dataGridView1.Columns.Add("Gost_Status", "Статус");
            dataGridView1.Columns.Add("Dop_uslugi", "Доп. услуги");
            dataGridView1.Columns.Add("Okonchanie", "Окончание");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add("isNew", string.Empty);

            dataGridView1.Columns[3].Width = 200;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void ReadSingRow(DataGridView dgw, IDataRecord record)
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
            if (Help.isAdmin)
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
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }
    }
}
