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
    public partial class AddItems : Form
    {
       

        public AddItems()
        {
            InitializeComponent();
        }



        private void Selectimage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Load the image from file
                Image selectedImage = Image.FromFile(imagePath);

                // Now you can use the 'selectedImage' in your application
                // For example, set it as the background of a PictureBox
                pictureitem.Image = selectedImage;

                // Don't forget to dispose of the image when you're done with it
                // selectedImage.Dispose();
            }
        }

        private void ClearForm()
        {
            // Clear the text boxes, ComboBox, and set the PictureBox image to null
            itemname.Clear();
            itemprice.Clear();
            itemCode.Clear();
            combocategory.SelectedIndex = -1;
            pictureitem.Image = null;
        }

        private void Additem_Click(object sender, EventArgs e)
        {
            string Name = itemname.Text.Trim();
            string PriceInput = itemprice.Text.Trim(); // Changed variable name for clarity
            string codeInput = itemCode.Text.Trim();
            string type = combocategory.SelectedItem?.ToString();
            Image image = pictureitem.Image;
            DateTime date = Date.Value;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(PriceInput) || string.IsNullOrEmpty(codeInput))
            {
                MessageBox.Show("Please fill in all the required fields with valid values.");
                return;
            }

            if (!decimal.TryParse(PriceInput, out decimal parsedPrices) || !int.TryParse(codeInput, out int parsedCode))
            {
                MessageBox.Show("Please enter valid numeric values for price and stock.");
                return;
            }

            if (image == null)
            {
                MessageBox.Show("Please select an image for the item.");
                return;
            }

            try
            {
                ConnectionDB.AddProduct(Name, parsedCode, type, parsedPrices, image, date);
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearForm();
        }



        public void Display()
        {
            // Specify the SQL query with the join
            string query = "SELECT * FROM foodmenu";




            // Assuming that DisplayAndSearch takes the query and dataGridView as parameters
            ConnectionDB.DisplayAndSearch(query, itemShow);
        }

        private void AddItems_Shown(object sender, EventArgs e)
        {
            itemShow.Refresh();
            Display();
        }
        private void Search(string searchTerm)
        {
            string query = $"SELECT `FoodPic`, `FoodName`, `FoodID`, `FoodType`, `FoodPrice`, `FoodDateCreated` FROM `foodmenu`" +
    $" WHERE `FoodDateCreated` LIKE '%{searchTerm}%' OR " +
    $" `FoodName` LIKE '%{searchTerm}%' OR " +
    $" `FoodID` LIKE '%{searchTerm}%' OR " +
    $" `FoodType` LIKE '%{searchTerm}%';";



            ConnectionDB.DisplayAndSearch(query, itemShow);
        }


        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search.Text.Trim();
            Search(searchTerm);
        }




        private void itemShow_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = itemShow.Rows[e.RowIndex];

                 itemname.Text = selectedRow.Cells["FoodName"].Value?.ToString();
              itemprice.Text = selectedRow.Cells["FoodPrice"].Value?.ToString();
              itemCode.Text = selectedRow.Cells["FoodID"].Value?.ToString();
                combocategory.Text = selectedRow.Cells["FoodType"].Value?.ToString();


                // Load the image into the PictureBox if available
                object imageDataObj = selectedRow.Cells["FoodPic"].Value;
                if (imageDataObj != DBNull.Value && imageDataObj != null && imageDataObj is byte[] imageData && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureitem.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureitem.Image = null; // No image available or empty byte array
                }


            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
          
            if (itemShow.SelectedRows.Count > 0) // Check if a row is selected
            {
                MessageBox.Show("Are you sure you want to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int foodId = Convert.ToInt32(itemShow.SelectedRows[0].Cells["FoodID"].Value);

                ConnectionDB.Delete(foodId);

                
                MessageBox.Show("Record deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case when no row is selected, show a message, etc.
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}








