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

        public DashBoardOrder()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            // Retrieve image data from the database
            string query = "SELECT ItemPicture FROM tb_item;"; // Assuming ItemPicture stores image binary data

            // Retrieve the DataTable containing image data from the database
            dt = ConnectionDB.DisplayProduct(query); // Assign the returned DataTable to dt

            foreach (DataRow row in dt.Rows)
            {
                byte[] imageData = (byte[])row["ItemPicture"]; // Assuming ItemPicture is of type BLOB/Binary in the database

                // Convert byte array to Image
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = 150; // Set picture box width as needed
                    pictureBox.Height = 150; // Set picture box height as needed
                    pictureBox.Image = Image.FromStream(ms); // Load image from byte array

                    flowProduct.Controls.Add(pictureBox); // Add the PictureBox to the FlowLayoutPanel
                }
            }
        }

    }
}