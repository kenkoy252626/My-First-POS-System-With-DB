using My_First_POS_System_With_DB.Admin;
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

namespace My_First_POS_System_With_DB.Vierwer
{
    public partial class DashBoardOrder : Form
    {
        DataTable dt; // Declare the DataTable to store retrieved data
        List<DataRow> selectedItems; // List to store selected items

        public DashBoardOrder()
        {
            InitializeComponent();
            DisplayCategories(); // Call the method to display categories
            Display();
            selectedItems = new List<DataRow>(); // Initialize the list
        }



        public void DisplayCategories()
        {
            // Retrieve distinct category names from the database
            string categoryQuery = "SELECT DISTINCT CategoryProduct, Category_ID FROM tb_category;";
            DataTable categoryDT = ConnectionDB.DisplayProduct(categoryQuery);

            foreach (DataRow categoryRow in categoryDT.Rows)
            {
                string categoryId = categoryRow["Category_ID"].ToString();
                string categoryName = categoryRow["CategoryProduct"].ToString();

                // Create a button for each category
                Button categoryButton = new Button();
                categoryButton.Text = categoryName;
                categoryButton.Tag = categoryId; // Store category ID in the button's Tag property
                categoryButton.Click += CategoryButton_Click;

                // Add the category button to the flow panel
                flowLayoutPanel1.Controls.Add(categoryButton);
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedCategoryButton)
            {
                string selectedCategoryId = clickedCategoryButton.Tag.ToString();

                // Retrieve items for the selected category from the database using INNER JOIN
                string itemsQuery = $"SELECT tb_item.ItemName, tb_item.ItemPrice, tb_item.ItemPicture " +
                                    $"FROM tb_item " +
                                    $"INNER JOIN tb_category ON tb_item.Category_ID = tb_category.Category_ID " +
                                    $"WHERE tb_category.Category_ID = '{selectedCategoryId}';";

                DataTable itemsDT = ConnectionDB.DisplayProduct(itemsQuery);

                if (itemsDT != null && itemsDT.Rows.Count > 0)
                {
                    // Display items in the UI (e.g., create buttons for each item)
                    DisplayItems(itemsDT);
                }
                else
                {
                    MessageBox.Show("No items found for the selected category.");
                }
            }
        }

        // DisplayItems method remains unchanged
        private void DisplayItems(DataTable itemsDataTable)
        {
            flowProduct.Controls.Clear(); // Clear previous items/buttons

            foreach (DataRow itemRow in itemsDataTable.Rows)
            {
                byte[] imageData = (byte[])itemRow["ItemPicture"];

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Button itemButton = new Button();
                    itemButton.BackgroundImageLayout = ImageLayout.Zoom;
                    itemButton.Width = 150;
                    itemButton.Height = 150;
                    itemButton.Image = Image.FromStream(ms);

                    // Add other item details or functionality to the button if needed
                    // ...

                    flowProduct.Controls.Add(itemButton);
                }
            }
        }





























        public void Display()
        {
            // Retrieve image data, item price, and other necessary columns from the database
            string query = "SELECT Item_ID, ItemName, ItemPrice, ItemPicture FROM tb_item;"; // Include all columns needed in the query

            // Retrieve the DataTable containing image data, item price, and other columns from the database
            dt = ConnectionDB.DisplayProduct(query); // Assuming DisplayProduct method fetches data from the database

            // Add a "Quantity" column to the DataTable
            dt.Columns.Add("Quantity", typeof(int));

            foreach (DataRow row in dt.Rows)
            {
                byte[] imageData = (byte[])row["ItemPicture"]; // Assuming ItemPicture is of type BLOB/Binary in the database

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Button button = new Button();
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.Width = 150;
                    button.Height = 150;
                    button.Image = Image.FromStream(ms);

                    button.Click += Button_Click;
                    // Set the Tag property of the button to store the corresponding DataRow
                    button.Tag = row;

                    flowProduct.Controls.Add(button);
                }
            }
        }

        // Click event handler for Buttons
        // Click event handler for Buttons
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                clickedButton.BackColor = Color.Blue;

                if (clickedButton.Tag is DataRow row)
                {
                    if (!selectedItems.Contains(row))
                    {
                        selectedItems.Add(row); // Add the clicked item to the list

                        // Prompt user for quantity
                        int quantity = GetQuantityFromUser();

                        if (quantity > 0) // Check if a valid quantity is entered
                        {
                            // Add the quantity to the DataRow
                            row["Quantity"] = quantity;

                            // Refresh DataGridView with updated data
                            RefreshDataGridView();
                        }
                        else
                        {
                            // Remove the item if quantity is invalid or zero
                            selectedItems.Remove(row);
                        }
                    }
                }
            }
        }

        // Method to refresh DataGridView with updated data
        // Method to refresh DataGridView with updated data
        private void RefreshDataGridView()
        {
            // Create a new DataTable to hold the selected items with quantity and total price
            DataTable selectedData = new DataTable();
            selectedData.Columns.Add("ItemName", typeof(string));
            selectedData.Columns.Add("Quantity", typeof(int)); // Change data type to int for quantity
            selectedData.Columns.Add("ItemPrice", typeof(decimal));
            selectedData.Columns.Add("TotalPrice", typeof(decimal));

            // Calculate total price for each selected item and add to the new DataTable
            foreach (DataRow selectedRow in selectedItems)
            {
                DataRow newRow = selectedData.Rows.Add();
                newRow["ItemName"] = selectedRow["ItemName"];
                newRow["Quantity"] = selectedRow["Quantity"];
                newRow["ItemPrice"] = selectedRow["ItemPrice"];

                // Calculate TotalPrice = Quantity * ItemPrice
                decimal totalPrice = (int)selectedRow["Quantity"] * (decimal)selectedRow["ItemPrice"];
                newRow["TotalPrice"] = totalPrice;
            }

            // Display all selected items in the DataGridView
            itemShow.DataSource = null; // Clear previous data source
            itemShow.DataSource = selectedData;

            // Allow editing for the Quantity column in DataGridView
            itemShow.Columns["Quantity"].ReadOnly = false;
        }



        // This method should prompt the user for the quantity of items selected
        private int GetQuantityFromUser()
        {
            using (QuantityInputDialog quantityDialog = new QuantityInputDialog())
            {
                DialogResult result = quantityDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return quantityDialog.EnteredQuantity;
                }
            }

            return 0; // Return 0 if the user cancels the input or provides an invalid quantity
        }







      



    }
}