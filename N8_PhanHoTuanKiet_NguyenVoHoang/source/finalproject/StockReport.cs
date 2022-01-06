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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void view_report_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM GoodsReceived WHERE Import_date BETWEEN '" + from_date.Value.ToString("MM/dd/yyyy") + "' AND '" + to_date.Value.ToString("MM/dd/yyyy") + "'", con);
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

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM DeliveryNote WHERE Delivery_date BETWEEN '" + from_date.Value.ToString("MM/dd/yyyy") + "' AND '" + to_date.Value.ToString("MM/dd/yyyy") + "'", con);
            DataTable data1 = new DataTable();
            sda1.Fill(data1);
            delivery_table.Rows.Clear();
            foreach (DataRow item in data1.Rows)
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
    }
}
