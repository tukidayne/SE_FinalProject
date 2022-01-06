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
    public partial class GoodsReceived : Form
    {
        public GoodsReceived()
        {
            InitializeComponent();
        }

        private void GoodsReceived_Load(object sender, EventArgs e)
        {
            this.ActiveControl = import_id;
            loadData();
        }


        private bool checkExists(SqlConnection con, string Product_ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 from [GoodsReceived] WHERE [Import_ID] = '" + import_id.Text + "'", con);
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

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[GoodsReceived]
           ([Import_ID]
           ,[Product_ID]
           ,[Quantity]
           ,[Import_date])
            VALUES
           ('" + import_id.Text + "','" + id.Text + "','" + quantity.Text + "','" + import_date.Value.ToString("MM/dd/yyyy") + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Đọc dữ liệu từ bảng GoodsReceived
            loadData();
            Reset();
        }

        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM GoodsReceived", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            import_table.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = import_table.Rows.Add();
                import_table.Rows[n].Cells[0].Value = n + 1;
                import_table.Rows[n].Cells[1].Value = item["Import_ID"].ToString();
                import_table.Rows[n].Cells[2].Value = item["Product_ID"].ToString();
                import_table.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                import_table.Rows[n].Cells[4].Value = item["Import_date"].ToString();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure to delete", "Message", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
                var query = "";
                if (checkExists(con, import_id.Text))
                {
                    con.Open();
                    query = @"DELETE FROM [GoodsReceived] WHERE Import_ID = '" + import_id.Text + "'";
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

        private void import_table_DoubleClick(object sender, EventArgs e)
        {
            import_id.Text = import_table.SelectedRows[0].Cells[1].Value.ToString();
            id.Text = import_table.SelectedRows[0].Cells[2].Value.ToString();
            quantity.Text = import_table.SelectedRows[0].Cells[3].Value.ToString();
            import_date.Text = import_table.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Reset()
        {
            import_id.Clear();
            id.Clear();
            quantity.Clear();
            import_date.Value = DateTime.Now;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
