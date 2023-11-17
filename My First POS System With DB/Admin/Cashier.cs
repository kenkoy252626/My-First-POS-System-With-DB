using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB.Admin
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }


        public void Display()
        {
            // Specify the SQL query with the join
            string query = "SELECT tb_cashier.FirstName, tb_cashier.LastName, tb_cashier.Gender, tb_cashier.MiddleName, tb_cashier.PictureCashier, tb_login.Username " +
                "FROM tb_cashier " +
                "INNER JOIN tb_login ON tb_cashier.Login_ID = tb_login.Login_ID;";


            // Assuming that DisplayAndSearch takes the query and dataGridView as parameters
            ConnectionDB.DisplayAndSearch(query, showCashier);
        }

        private void Cashier_Shown(object sender, EventArgs e)
        {
            Display();
        }

        //searching item 
        private void Search(string searchTerm)
        {
            string query = $"SELECT tb_cashier.FirstName, tb_cashier.LastName, tb_cashier.Gender, tb_cashier.MiddleName, tb_cashier.PictureCashier, tb_login.Username " +
                           $"FROM tb_cashier " +
                           $"INNER JOIN tb_login ON tb_cashier.Login_ID = tb_login.Login_ID " +
                           $"WHERE tb_cashier.FirstName LIKE '%{searchTerm}%' OR " +
                           $"tb_cashier.LastName LIKE '%{searchTerm}%' OR " +
                           $"tb_cashier.Gender LIKE '%{searchTerm}%' OR " +
                           $"tb_cashier.MiddleName LIKE '%{searchTerm}%' OR " +
                           $"tb_login.Username LIKE '%{searchTerm}%';";

            ConnectionDB.DisplayAndSearch(query, showCashier);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim();
            Search(searchTerm);
        }

        private void showCashier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = showCashier.Rows[e.RowIndex];

                if (showCashier.Columns.Count >= 6) // Ensure at least 6 columns exist
                {
                    string firstName = selectedRow.Cells["Column2"].Value?.ToString();
                    string lastName = selectedRow.Cells["Column5"].Value?.ToString();
                    string middleName = selectedRow.Cells["Column4"].Value?.ToString();

                    string fullName = $"{firstName} {middleName} {lastName}";

                    // Display the full name in the fullnameText label
                    fullnameText.Text = fullName;

                    // Display other details in respective controls
                   firstnameText.Text = selectedRow.Cells["Column2"].Value?.ToString();
                    genderText.Text = selectedRow.Cells["Column6"].Value?.ToString();
                    userText.Text = selectedRow.Cells["Column3"].Value?.ToString();

                    // Load the image into the PictureBox if available
                    object imageDataObj = selectedRow.Cells["Column1"].Value;
                    if (imageDataObj != DBNull.Value && imageDataObj != null)
                    {
                        if (imageDataObj is byte[] imageData && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null; // No image available or empty byte array
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null; // No image available or NULL value
                    }
                }
            }
        }

    }
}
    
