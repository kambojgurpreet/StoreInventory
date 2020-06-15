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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();
        private void Products_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();

            cmbCategory.DataSource = categoriesDT;

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.quantity = 0;
            p.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            p.added_by = usr.id;

            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("New Product Inserted Successfully.");
                Clear();
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert new Product!!");
            }
        }

        public void Clear()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            txtRate.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtProductID.Text = dgvProducts.Rows[RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[RowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[RowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[RowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtProductID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            p.added_by = usr.id;

            bool success = pdal.Update(p);

            if (success == true)
            {
                MessageBox.Show("Product successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update Product!!");
            }

            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtProductID.Text);

            bool success = pdal.Delete(p);

            if (success == true)
            {
                MessageBox.Show("Product successfully deleted.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete Product!!");
            }
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
