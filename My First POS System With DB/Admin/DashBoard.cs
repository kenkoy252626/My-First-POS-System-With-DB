using System;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB.Admin
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }



        private void Items_Click(object sender, EventArgs e)
        {
            AddItems it = new AddItems();
            it.TopLevel = false;
            flow.Controls.Add(it);
            it.BringToFront();
            it.Show();

        }
    }
}
