using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal.Services
{
    public class Database
    {
        //public static string ConnectionString = "server = 127.0.0.1; port = 3306; " +
        //    "username = grib; password = v1esbut1s; database = journal";
        public static string ConnectionString = "server = 127.0.0.1; port = 3306; " +
            "username = mysql; password = mysql; database = journal";

        public int ExecuteSqlCommand(string query)
        {
            int lastInsertId = 0;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                lastInsertId = Convert.ToInt32(command.LastInsertedId);
                conn.Close();
            }

            return lastInsertId;
        }

        public DataTable SelectCommand(string query)
        {
            DataTable table = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(query, conn);

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            return table;
        }

        public ListView ReadTable(string query, ListView list)
        {
            MySqlDataReader table;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                table = command.ExecuteReader();
                while (table.Read())
                {
                    ListViewItem lvi = new ListViewItem(table[0].ToString());
                    lvi.SubItems.Add(table[1].ToString());
                    lvi.SubItems.Add(table[2].ToString());
                    list.Items.Add(lvi);
                }
            }

            return list;
        }

        public List<string> GetListTable(string query)
        {
            MySqlDataReader table;
            List<string> list = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                table = command.ExecuteReader();
                while (table.Read())
                {
                    list.Add(table[0].ToString());
                }
            }

            return list;
        }

        public bool CheckUser(string login)
        {
            string query = $"SELECT * FROM `users` WHERE `Login` = '{login}'";
            var table = SelectCommand(query);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
