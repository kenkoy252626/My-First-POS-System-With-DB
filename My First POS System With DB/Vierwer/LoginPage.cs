using My_First_POS_System_With_DB.Admin;
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
        
        private ConnectionDB manage = new ConnectionDB();
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
            string user =UserBox.Text;
            string pass = PassBox.Text;

            bool isAuthenticated = manage.Authentication(user, pass);

            if (isAuthenticated)
            {
                this.Hide();
                DashBoardOrder dashBoard = new DashBoardOrder();
                dashBoard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

       

        private void admin_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.TopLevel = false;
            LogPanel.Controls.Add(logIn);
            logIn.BringToFront();
            logIn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterFrom reg = new RegisterFrom();
            reg.Show();
        }
    }
}
