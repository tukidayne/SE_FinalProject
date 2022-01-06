using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Products]
           ([Product_ID]
           ,[Product_Name]
           ,[Brand]
           ,[Price])
            VALUES
           ('"+ id.Text + "','" + name.Text + "','" + pBrand.Text + "','" + pPrice.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Đọc dữ liệu từ bảng products
            loadData();
            Reset();
        }


        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            products_table.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = products_table.Rows.Add();
                products_table.Rows[n].Cells[0].Value = item["Product_ID"].ToString();
                products_table.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                products_table.Rows[n].Cells[2].Value = item["Brand"].ToString();
                products_table.Rows[n].Cells[3].Value = item["Price"].ToString();
            }
        }

        private void products_table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id.Text = products_table.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = products_table.SelectedRows[0].Cells[1].Value.ToString();
            pBrand.Text = products_table.SelectedRows[0].Cells[2].Value.ToString();
            pPrice.Text = products_table.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure to delete", "Message", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
                var query = "";
                if (checkExists(con, id.Text))
                {
                    con.Open();
                    query = @"DELETE FROM [Products] WHERE Product_ID = '" + id.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
                loadData();
                Reset();
            }
        }

        private bool checkExists(SqlConnection con, string Product_ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 from [Products] WHERE [Product_ID] = '" + Product_ID + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void Reset()
        {
            id.Clear();
            name.Clear();
            pBrand.Clear();
            pPrice.Clear();
        }
    }
}
