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
    public partial class LoginPage : Form
    {
        

        public LoginPage()
        {
            InitializeComponent();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
          userText.Hide();
          if (UserBox.Text == "")
            {
                userText.Show();
            }

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            passText.Hide();
            if (PassBox.Text == "")
            {
                passText.Show();
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(showPass.Checked == true)
            {
                PassBox.PasswordChar = '\0';
            }
            else
            {
                PassBox.PasswordChar = '●';
            }
        }

     

        private void Login_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterFrom reg    = new RegisterFrom();
            reg.Show();
        }
    }
}
