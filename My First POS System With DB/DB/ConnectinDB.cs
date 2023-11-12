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

        private static string con = "Server=localhost;Port=3306;Database=db_fastfood;User Id=root;Password='';";

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
    }
}
