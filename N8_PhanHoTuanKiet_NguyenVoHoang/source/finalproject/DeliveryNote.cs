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
    public partial class DeliveryNote : Form
    {
        public DeliveryNote()
        {
            InitializeComponent();
        }

        private void DeliveryNote_Load(object sender, EventArgs e)
        {
            this.ActiveControl = delivery_id;
            loadData();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[DeliveryNote]
           ([Delivery_ID]
           ,[Order_ID]
           ,[Delivery_date]
           ,[Order_status]
           ,[Payment_status])
     VALUES
           ('" + delivery_id.Text + "','" + order_id.Text + "','" + delivery_date.Value.ToString("MM/dd/yyyy") + "','" + order_status.Text + "','" + payment_status.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Đọc dữ liệu từ bảng DeliveryNote
            loadData();
            Reset();
        }

        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DeliveryNote", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            delivery_table.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = delivery_table.Rows.Add();
                delivery_table.Rows[n].Cells[0].Value = n + 1;
                delivery_table.Rows[n].Cells[1].Value = item["Delivery_ID"].ToString();
                delivery_table.Rows[n].Cells[2].Value = item["Order_ID"].ToString();
                delivery_table.Rows[n].Cells[3].Value = item["Delivery_date"].ToString();
                delivery_table.Rows[n].Cells[4].Value = item["Order_status"].ToString();
                delivery_table.Rows[n].Cells[5].Value = item["Payment_status"].ToString();
            }
        }

        private void Reset()
        {
            delivery_id.Clear();
            order_id.Clear();
            delivery_date.Value = DateTime.Now;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure to delete", "Message", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
                var query = "";
                if (checkExists(con, delivery_id.Text))
                {
                    con.Open();
                    query = @"DELETE FROM [DeliveryNote] WHERE Delivery_ID = '" + delivery_id.Text + "'";
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
        private bool checkExists(SqlConnection con, string Delivery_ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 from [DeliveryNote] WHERE [Delivery_ID] = '" + delivery_id.Text + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void delivery_table_DoubleClick(object sender, EventArgs e)
        {
            delivery_id.Text = delivery_table.SelectedRows[0].Cells[1].Value.ToString();
            order_id.Text = delivery_table.SelectedRows[0].Cells[2].Value.ToString();
            delivery_date.Text = delivery_table.SelectedRows[0].Cells[3].Value.ToString();
            order_status.Text = delivery_table.SelectedRows[0].Cells[4].Value.ToString();
            payment_status.Text = delivery_table.SelectedRows[0].Cells[5].Value.ToString();
            delivery_id.Enabled = false;
            order_id.Enabled = false;
            delivery_date.Enabled = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[DeliveryNote] SET [Order_status] = '" + order_status.Text + "', [Payment_status] = '" + payment_status.Text + "' WHERE [Delivery_ID] = '" + delivery_id.Text +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            loadData();
            Reset();
            delivery_id.Enabled = true;
            order_id.Enabled = true;
            delivery_date.Enabled = true;
        }

    }
}
