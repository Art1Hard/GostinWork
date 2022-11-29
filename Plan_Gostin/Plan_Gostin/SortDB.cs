using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Plan_Gostin
{
    public static class SortDB
    {
        public static string SelectSort(ComboBox sortComboBox, Button sortButton)
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
                    Help.ReadSingRow(dgw, reader);
                }

                reader.Close();
            }
        }
    }
}
