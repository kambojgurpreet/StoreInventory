using StoreInventory.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.DAL
{
    class productsDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Product from Database

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM table_products";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion

        #region Insert Product into Database

        public bool Insert(productsBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "INSERT INTO table_products (name, category, description, rate, quantity, added_date, added_by) VALUES (@name, @category, @description, @rate, @quantity, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        #endregion

        #region Update Data in Database

        public bool Update(productsBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "UPDATE table_products SET name=@name, category=@category, description=@description, rate=@rate, quantity=@quantity, added_date=@added_date, added_by=@added_by WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        #endregion

        #region Delete Data from Database

        public bool Delete(productsBLL p)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM table_products WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        #endregion

        #region Search Product in Database using Keywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM table_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%' OR rate LIKE '%" + keywords + "%'  OR added_date LIKE '%" + keywords + "%' OR added_by LIKE '%" + keywords + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
