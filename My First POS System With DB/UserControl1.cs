using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Method to set product details inside UserControl1
        public void SetProductDetails(string productName, Image productImage)
        {
            // Assuming you have controls like 'productNameLabel' and 'productPictureBox' on UserControl1
            Producttext.Text = productName;
            Productimage.Image = productImage;
            // You can set other details in a similar manner
        }
    }
}



