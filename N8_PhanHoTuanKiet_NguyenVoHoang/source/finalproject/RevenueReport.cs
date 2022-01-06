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
    public partial class RevenueReport : Form
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void view_report_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-V3ASV8V\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(Total_price) AS Revenue FROM dbo.Orders WHERE MONTH(Order_date) = '" + month.Value.ToString("MM") + "' AND YEAR(Order_date) ='" + month.Value.ToString("yyyy") + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            revenue_table.Rows.Clear();
            foreach (DataRow item in data.Rows)
            {
                int n = revenue_table.Rows.Add();
                revenue_table.Rows[n].Cells[0].Value = month.Value.ToString("MM");
                revenue_table.Rows[n].Cells[1].Value = month.Value.ToString("yyyy");
                revenue_table.Rows[n].Cells[2].Value = item["Revenue"].ToString();
            }
        }
    }
}
