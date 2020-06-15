using StoreInventory.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void labelFooter_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            labelLoggedInUser.Text = Login.loggedIn;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.Show();
        }
    }
}
