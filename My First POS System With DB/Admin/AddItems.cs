using ServiceStack;using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;namespace My_First_POS_System_With_DB.Admin{    public partial class AddItems : Form    {        public AddItems()        {            InitializeComponent();        }        private void Selectimage_Click_1(object sender, EventArgs e)        {            OpenFileDialog openFileDialog = new OpenFileDialog();            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";            if (openFileDialog.ShowDialog() == DialogResult.OK)            {                string imagePath = openFileDialog.FileName;                // Load the image from file                Image selectedImage = Image.FromFile(imagePath);                // Now you can use the 'selectedImage' in your application                // For example, set it as the background of a PictureBox                pictureitem.Image = selectedImage;                                // Don't forget to dispose of the image when you're done with it                // selectedImage.Dispose();            }        }        private void ClearForm()        {            // Clear the text boxes, ComboBox, and set the PictureBox image to null            itemname.Clear();            itemprice.Clear();            itemstock.Clear();            combocategory.SelectedIndex = -1;            pictureitem.Image = null;        }        private void Additem_Click(object sender, EventArgs e)        {


                       itemShow.Refresh();            string itemName = itemname.Text.Trim();            string itemPrice = itemprice.Text.Trim();            string itemStock = itemstock.Text.Trim();            string category = combocategory.SelectedItem?.ToString();            Image image = pictureitem.Image;            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemPrice) || string.IsNullOrEmpty(itemStock) || string.IsNullOrEmpty(category))            {                MessageBox.Show("Please fill in all the required fields with valid values.");                return;            }            if (!decimal.TryParse(itemPrice, out decimal itemPrices) || !int.TryParse(itemStock, out int itemStocks))            {                MessageBox.Show("Please enter valid numeric values for price and stock.");                return;            }            if (image == null)            {                MessageBox.Show("Please select an image for the item.");                return;            }            try            {                ConnectionDB.AddProduct(itemName, itemPrices, itemStocks, image, category);                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);            }            catch (Exception ex)            {                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }            ClearForm();        }

        public void Display()
        {
            // Specify the SQL query with the join
            string query = "SELECT tb_item.ItemName ,tb_category.CategoryProduct, tb_item.ItemPrice, tb_item.ItemStock, tb_item.ItemPicture " +
                "FROM tb_item " +
                "INNER JOIN tb_category ON tb_item.Category_ID = tb_category.Category_ID;";

            // Assuming that DisplayAndSearch takes the query and dataGridView as parameters
            ConnectionDB.DisplayAndSearch(query,itemShow);
        }

        private void AddItems_Shown(object sender, EventArgs e)
        {
            Display();
        }

       
    }}