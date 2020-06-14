using StoreInventory.BLL;
using StoreInventory.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            bool success = dal.loginCheck(l);

            if(success == true)
            {
                MessageBox.Show("Login Successfull.");
                loggedIn = l.username;

                switch (l.user_type)
                {
                    case "Admin":
                        {
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            UserDashboard user = new UserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid user type!");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login failed. Try again!!");
            }
        }
    }
}
