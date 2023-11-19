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
            Display();
            selectedItems = new List<DataRow>(); // Initialize the list
        }
        public void Display()
        {
            // Retrieve image data and other necessary columns from the database
            string query = "SELECT Item_ID, ItemName, ItemPrice, ItemPicture FROM tb_item;"; // Include all columns needed in the query

            // Retrieve the DataTable containing image data and other columns from the database
            dt = ConnectionDB.DisplayProduct(query); // Assuming DisplayProduct method fetches data from the database

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

                    // Attach a click event handler to each button
                    button.Click += Button_Click;

                    // Set the Tag property of the button to store the corresponding DataRow
                    button.Tag = row;

                    flowProduct.Controls.Add(button);
                }
            }
        }

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

                        DataTable selectedData = dt.Clone();
                        selectedData.ImportRow(row);

                        itemShow.DataSource = null; // Clear previous data source
                        itemShow.DataSource = selectedItems.CopyToDataTable(); // Display all selected items in the DataGridView
                    }
                }
            }

        }

    }
}

