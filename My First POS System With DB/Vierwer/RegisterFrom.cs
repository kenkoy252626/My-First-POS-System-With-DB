using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using My_First_POS_System_With_DB;
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


        private void ClearForm()
        {
            // Clear the text boxes, ComboBox, and set the PictureBox image to null
            UserBox.Clear();
            LastBox.Clear();
           Gender.SelectedIndex = -1;
            imageDisplay.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get data from the form
            string firstName = UserBox.Text.Trim();
            string middlename = midBox.Text.Trim();
            string lastName = LastBox.Text.Trim();
            string gender = Gender.SelectedItem?.ToString(); // Assuming you have a ComboBox for gender
            Image image = imageDisplay.Image;// Assuming you have a PictureBox on your form
            string username = UserName.Text.Trim(); // Assuming you have a TextBox for username
            string password = Password.Text.Trim();

            // Validate that all required fields are filled
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) ||
     string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Call the UserRegistration class to handle registration
            ConnectionDB.RegisterUser(firstName, lastName, gender, image,middlename,username,password);

            // You can also clear the form or perform other actions as needed
            ClearForm();
        }

    }
}
       
    
    


