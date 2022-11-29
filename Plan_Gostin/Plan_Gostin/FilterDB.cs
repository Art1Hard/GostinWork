using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Gostin
{
    public static class FilterDB
    {
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
                Help.ReadSingRow(dgw, reader);
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
                    Help.ReadSingRow(dgw, reader);
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
                Help.ReadSingRow(dgw, reader);
            }

            reader.Close();
        }
    }
}
