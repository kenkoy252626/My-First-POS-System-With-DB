using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            string name = UserBox.Text.Trim();
            string address = midBox.Text.Trim();
            string lastName = LastBox.Text.Trim();
            string gender = Gender.SelectedItem?.ToString();
            Image image = imageDisplay.Image;
            string email = UserName.Text.Trim();
            DateTime bday = dateTime.Value; // Assuming you have a DateTimePicker named dateTimePicker1 for selecting the birthdate.
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Hash the password before sending it to the registration method.
            string hashedPassword = HashPassword(password);

            ConnectionDB.RegisterUser(name, bday, gender, image, address, email, hashedPassword);

            ClearForm(); // Ensure this method works correctly to clear the form fields.
        }

        private string HashPassword(string password)
        {
            // Implement a secure hashing algorithm (e.g., bcrypt, Argon2) to hash the password.
            // Example using System.Security.Cryptography:

            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }


    }
}
       
    
    


