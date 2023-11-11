using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB.Vierwer
{
    public partial class RegisterFrom : Form
    {
        public RegisterFrom()
        {
            InitializeComponent();
        }

        private void imageSet_Click(object sender, EventArgs e)
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
                imageDisplay.Image = selectedImage;

                // Don't forget to dispose of the image when you're done with it
                // selectedImage.Dispose();
            }
        }
    }
}
