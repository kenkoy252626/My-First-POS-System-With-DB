using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace My_First_POS_System_With_DB
{

    internal class ConnectionDB
    {
        public static string con = "Server=localhost;Port=3306;Database=eatnrun;User Id=root;Password='';";

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
                string query = "SELECT * FROM accounts WHERE EmployeeEmail = @UserName AND Password = @Password AND EmployeePosition = 'Cashier'";


                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);
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

        public static void RegisterUser(string name, DateTime bday, string gender, Image image, string address, string email, string password)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string cashierQuery = "INSERT INTO accounts (AccountPfp, EmployeeName, EmployeePosition, EmployeeBday, EmployeeGender, EmployeeAddress, EmployeeEmail, EmployeeID, Password) " +
                                      "VALUES (@AccountPfp, @EmployeeName, 'Cashier', @EmployeeBday, @EmployeeGender, @EmployeeAddress, @EmployeeEmail, NULL, @Password)";

                using (MySqlCommand cashierCmd = new MySqlCommand(cashierQuery, connection))
                {
                    cashierCmd.Parameters.AddWithValue("@EmployeeName", name);
                    cashierCmd.Parameters.AddWithValue("@EmployeeBday", bday);
                    cashierCmd.Parameters.AddWithValue("@EmployeeGender", gender);
                    cashierCmd.Parameters.AddWithValue("@EmployeeAddress", address);
                    cashierCmd.Parameters.AddWithValue("@EmployeeEmail", email);
                    cashierCmd.Parameters.AddWithValue("@Password", password);

                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, ImageFormat.Jpeg);
                            cashierCmd.Parameters.AddWithValue("@AccountPfp", ms.ToArray()); 
                        }
                    }
                    else
                    {
                        cashierCmd.Parameters.AddWithValue("@AccountPfp", DBNull.Value);
                    }

                    try
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open(); // Open the connection if it's not already open

                        cashierCmd.ExecuteNonQuery();
                        MessageBox.Show("Account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Log the exception for further investigation if needed
                        // Logging ex: LogError(ex);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close(); // Close the connection when done
                    }
                }
            }
        }















        public static void AddProduct(string Name, int code, string type, decimal Prices, Image image, DateTime date)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string insertQuery = "INSERT INTO foodmenu (FoodPic, FoodName, FoodID, FoodType, FoodPrice, FoodDateCreated) VALUES (@FoodPic, @FoodName, @FoodCode, @FoodType, @FoodPrice, @FoodDateCreated)";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@FoodName", Name);
                    insertCommand.Parameters.AddWithValue("@FoodCode", code); 
                    insertCommand.Parameters.AddWithValue("@FoodType", type);
                    insertCommand.Parameters.AddWithValue("@FoodPrice", Prices);
                    insertCommand.Parameters.AddWithValue("@FoodDateCreated", date);

                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Save(ms, ImageFormat.Jpeg);
                            insertCommand.Parameters.AddWithValue("@FoodPic", ms.ToArray());
                        }
                    }
                    else
                    {
                        insertCommand.Parameters.AddWithValue("@FoodPic", DBNull.Value);
                    }

                    try
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open(); // Open the connection if it's not already open

                        insertCommand.ExecuteNonQuery();
                        // Remove the duplicate MessageBox here to avoid redundancy
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Log the exception for further investigation if needed
                        // Logging ex: LogError(ex);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close(); // Close the connection when done
                    }
                }
            }
        }

        public static void Delete(int Id)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string insertQuery = "DELETE FROM `foodmenu` WHERE FoodID = @FoodID ";

                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@FoodID", Id);


                    try
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open(); // Open the connection if it's not already open

                        insertCommand.ExecuteNonQuery();
                        // Remove the duplicate MessageBox here to avoid redundancy
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Log the exception for further investigation if needed
                        // Logging ex: LogError(ex);
                    }
                }
            }
        }


        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            connection.Close();
        }



        public static DataTable DisplayProduct(string query)
        {
            DataTable dt = new DataTable();

            // Your database connection logic
            MySqlConnection connection = GetConnection();
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

             
                adapter.Fill(dt);
                connection.Close();
            }

            return dt;
        }




            







    }
}



    

