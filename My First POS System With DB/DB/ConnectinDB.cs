﻿
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB
{
    internal class ConnectionDB
    {

        private static string con = "Server=localhost;Port=3306;Database=pointofsale_db;User Id=root;Password='';";
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
                string query = "SELECT * FROM tb_Login WHERE Username = @UserName AND Password = @Password ";

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


        public static void RegisterUser(string firstName, string lastName, string gender, Image image, string middlename, string username, string password)
        {
            using (MySqlConnection connection = ConnectionDB.GetConnection())
            {
                
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into tb_login
                        string loginQuery = "INSERT INTO tb_login (Username, Password) VALUES (@Username, @Password)";

                        using (MySqlCommand loginCmd = new MySqlCommand(loginQuery, connection, transaction))
                        {
                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);

                            loginCmd.ExecuteNonQuery();

                            // Retrieve the Login_ID generated by the database
                            int loginId = (int)loginCmd.LastInsertedId;

                            // Insert into tb_cashier with the corresponding Login_ID
                            string cashierQuery = "INSERT INTO tb_cashier (Login_ID, FirstName, LastName, Gender, PictureCashier, MiddleName) " +
                                                  "VALUES (@Login_ID, @FirstName, @LastName, @Gender, @PictureCashier, @MiddleName)";

                            using (MySqlCommand cashierCmd = new MySqlCommand(cashierQuery, connection, transaction))
                            {
                                cashierCmd.Parameters.AddWithValue("@Login_ID", loginId);
                                cashierCmd.Parameters.AddWithValue("@FirstName", firstName);
                                cashierCmd.Parameters.AddWithValue("@LastName", lastName);
                                cashierCmd.Parameters.AddWithValue("@Gender", gender);
                                cashierCmd.Parameters.AddWithValue("@MiddleName", middlename);

                                if (image != null)
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        image.Save(ms, ImageFormat.Jpeg);
                                        cashierCmd.Parameters.AddWithValue("@PictureCashier", ms.ToArray());
                                    }
                                }
                                else
                                {
                                    cashierCmd.Parameters.AddWithValue("@PictureCashier", DBNull.Value);
                                }

                                cashierCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Record not inserted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




    }
}

       

