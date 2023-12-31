﻿using My_First_POS_System_With_DB.Vierwer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LoadingBar.Increment(20);
            if(LoadingBar.Value == 100)
            {
                timer1.Enabled = false;
                LoginPage log = new LoginPage();
                log.Show();
                this.Hide();
            }
        }
    }
}
