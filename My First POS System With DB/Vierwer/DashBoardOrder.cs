using My_First_POS_System_With_DB.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using System.Web.UI;

namespace My_First_POS_System_With_DB.Vierwer
{
    public partial class DashBoardOrder : Form
    {

        public DashBoardOrder()
        {
            InitializeComponent();
            LoadProductsFromDatabase();
            Displays();
        }

        public void Displays()
        {
            // Retrieve image data, item price, and other necessary columns from the database
            string query = "SELECT FoodName, FoodID, FoodPrice FROM foodmenu;"; // Include all columns needed in the query

            ConnectionDB.DisplayAndSearch(query, itemShow);

        }
        // Inside your form or class where FlowLayoutPanel exists

        private void LoadProductsFromDatabase()
        {
            DataTable productsData = ConnectionDB.DisplayProduct("SELECT * FROM foodmenu");

            foreach (DataRow row in productsData.Rows)
            {
                UserControl1 productControl = new UserControl1();

                string productName = row["FoodName"].ToString();
                byte[] imageData = (byte[])row["FoodPic"];
                Image productImage = ImageFromByteArray(imageData);

                productControl.SetProductDetails(productName, productImage);

                flowProduct.Controls.Add(productControl); // Add each instance separately
            }
        }


        // Method to convert byte array to Image
        private Image ImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }



    }
}
 
