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
    public partial class DealerCustomer : Form
    {
        public DealerCustomer()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DealerCustomerBLL dc = new DealerCustomerBLL();
        DealerCustomerDAL dcDal = new DealerCustomerDAL();

        userDAL uDal = new userDAL();
 
        private void DealerCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDal.Select();
            dgvDealerCustomer.DataSource = dt;
        }

        public void Clear()
        {
            txtDealerCustomerID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = cmbType.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedInUser);

            dc.added_by = usr.id;

            bool success = dcDal.Insert(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer added Successfully.");
                Clear();
                DataTable dt = dcDal.Select();
                dgvDealerCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to add Dealer or Customer!!");
            }
        }

        private void dgvDealerCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtDealerCustomerID.Text = dgvDealerCustomer.Rows[RowIndex].Cells[0].Value.ToString();
            cmbType.Text = dgvDealerCustomer.Rows[RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDealerCustomer.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDealerCustomer.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDealerCustomer.Rows[RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDealerCustomer.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDealerCustomerID.Text);
            dc.type = cmbType.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedInUser);

            dc.added_by = usr.id;

            bool success = dcDal.Update(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update Dealer or Customer!!");
            }

            DataTable dt = dcDal.Select();
            dgvDealerCustomer.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = Convert.ToInt32(txtDealerCustomerID.Text);

            bool success = dcDal.Delete(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer successfully deleted.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete Dealer or Customer!!");
            }
            DataTable dt = dcDal.Select();
            dgvDealerCustomer.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dcDal.Search(keywords);
                dgvDealerCustomer.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Select();
                dgvDealerCustomer.DataSource = dt;
            }
        }
    }
}
