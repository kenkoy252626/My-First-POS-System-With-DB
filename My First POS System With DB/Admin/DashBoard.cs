using System;
using System.Web.Caching;
using System.Windows.Forms;

namespace My_First_POS_System_With_DB.Admin
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }



      

        private void items_Click_1(object sender, EventArgs e)
        {
            AddItems it = new AddItems();
            it.TopLevel = false;
            flow.Controls.Add(it);
            it.BringToFront();
            it.Show();
        }

        private void cashier_Click(object sender, EventArgs e)
        {
           Cashier list = new Cashier();
            list.TopLevel = false;
            flow.Controls.Add(list);
            list .BringToFront();
           list.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
