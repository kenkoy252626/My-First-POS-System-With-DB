using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB
{
    internal class ConnectinDB
    {

        private static string con = "Server=localhost;Port=3306;Database=Database;User Id=root;Password='';";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection Error!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }


        public bool Authentication(string UserName, string Password)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM tb_admin WHERE UserName = @UserName AND Password = @Password ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userName", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // User authenticated successfully
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
