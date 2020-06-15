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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if(success == true)
            {
                MessageBox.Show("New Category Inserted Successfully.");
                Clear();
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert new Category!!");
            }
        }

        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            String loggedInUser = Login.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            c.added_by = usr.id;

            bool success = dal.Update(c);

            if (success == true)
            {
                MessageBox.Show("Category successfully updated.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update category!!");
            }

            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtCategoryID.Text);

            bool success = dal.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Category successfully deleted.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete Category!!");
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
