﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB.Admin
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            
                if (showPass.Checked == true)
                {
                    PassBox.PasswordChar = '\0';
                }
                else
                {
                    PassBox.PasswordChar = '●';
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == "" && UserBox.Text == "")
            {
                DashBoard dash = new DashBoard();
                dash.Show();
            }
        }
    }
    }

